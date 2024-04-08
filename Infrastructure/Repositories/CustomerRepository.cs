using Core.Constants;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BootcampContext _context;

        public CustomerRepository(BootcampContext context)
        {
            _context = context;

        }


        public async Task<List<CustomerDTO>> GetFiltered(FilterCustomersModel filter)
        {
            var query = _context.Customers
                .Include(c => c.Bank)
                .AsQueryable();

            if (filter.BirthYearFrom is not null)
            {
                query = query.Where(x =>
                    x.Birth != null &&
                    x.Birth.Value.Year >= filter.BirthYearFrom);
            }

            if (filter.BirthYearTo is not null)
            {
                query = query.Where(x =>
                    x.Birth != null &&
                    x.Birth.Value.Year <= filter.BirthYearTo);
            }

            var result = await query.ToListAsync();

            return result.Select(x => new CustomerDTO
            {
                Id = x.Id,
                Name = x.Name,
                Lastname = x.Lastname,
                DocumentNumber = x.DocumentNumber,
                Address = x.Address,
                Mail = x.Mail,
                Phone = x.Phone,
                CustomerStatus = nameof(x.CustomerStatus),
                Birth = x.Birth,
                Bank = new BankDTO
                {
                    Id = x.Bank.Id,
                    Name = x.Bank.Name,
                    Phone = x.Bank.Phone,
                    Mail = x.Bank.Mail,
                    Address = x.Bank.Address
                }
            }).ToList();

        }

        public async Task<CustomerDTO> Add(CreateCustomerModel model, CustomerDTO customerDTO)
        {
            var CustomerCreate = new Customer
            {
                Name = model.Name,
                Lastname = model.LastName,
                DocumentNumber = model.DocumentNumer,
                Address = model.Address,
                Mail = model.Mail,
                Phone = model.Phone,
                CustomerStatus = model.customerStatus,
                BankId = model.BankId,
                Birth = model.Bank,

            };

            _context.Customers.Add(CustomerCreate);

            await _context.SaveChangesAsync();
            var customer = new Customer
            {
                Name = CustomerCreate.Name,
                Lastname = CustomerCreate.Lastname,
                DocumentNumber = CustomerCreate.DocumentNumber,
                Address = CustomerCreate.Address,
                Mail = CustomerCreate.Mail,
                Phone = CustomerCreate.Phone,
                CustomerStatus = CustomerCreate.CustomerStatus,
                BankId = CustomerCreate.BankId,
                Birth = CustomerCreate.Birth,

            };

            return customerDTO;

        }

        public async Task<bool> Delate(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) throw new Exception("customer not found");
            _context.Customers.Remove(customer);
            var result = await _context.SaveChangesAsync();
            return result > 0 && result < 1;
        }


        public async Task<List<CustomerDTO>> GetAll(List<CustomerDTO> CustomerDTO)
        {
            var customers = await _context.Customers.ToListAsync();

            var CustomersDTO = customers.Select(customers => new customerDTO
            {
                Name = customers.Name,
                Lastname = customers.Lastname,
                DocumentNumber = customers.DocumentNumber,
                Address = customers.Address,
                Mail = customers.Mail,
                Phone = customers.Phone,
                Birth = customers.Birth,
            }).ToList();

            return CustomerDTO;
        }


        public async Task<CustomerDTO> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer is null) throw new Exception("customer not found");

            var customerDTO = new CustomerDTO
            {
                Name = customer.Name,
                Lastname = customer.Lastname,
                DocumentNumber = customer.DocumentNumber,
                Address = customer.Address,
                Mail = customer.Mail,
                Phone = customer.Mail,
                Birth = customer.Birth,
            };

            return customerDTO;

        }

        public async Task<bool> NameIsAlreadyTaken(string name)
        {
            return await _context.Customers.AnyAsync(Customer => Customer.Name == name);
        }

        public async Task<CustomerDTO> Update(UpdateCustomerModel model)
        {
            var customer = await _context.Customers.FindAsync(model.Id);

            if (customer is null) throw new Exception("Bank was not found");

            customer.Name = model.Name;
            customer.Lastname = model.Lastname;
            customer.DocumentNumber = model.DocumentNumber;
            customer.Address = model.Address;
            customer.Mail = model.Mail;
            customer.Phone = model.Phone;
            customer.CustomerStatus = model.CustomerStatus;
            customer.BankId = model.BankId;
            customer.Birth = model.Birth;

            _context.Customers.Update(customer);

            await _context.SaveChangesAsync();

            var customerDTO = new CustomerDTO
            {
                Name = customer.Name,
                Lastname = customer.Lastname,
                DocumentNumber = customer.DocumentNumber,
                Address = customer.Address,
                Mail = customer.Mail,
                Phone = customer.Phone,
                Birth = customer.Birth,
            };

            return customerDTO;
        }

        public Task<CustomerDTO> Add(CreateCustomerModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BankDTO> Add(CreateBankModel model)
        {
            throw new NotImplementedException();
        }
    }
}



