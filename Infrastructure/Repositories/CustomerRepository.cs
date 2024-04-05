using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Requests;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BootcampContext _context;

        public CustomerRepository(BootcampContext context)
        {
            _context = context;

        }

        public async Task<CustomerDTO> Add(CreateCustomerModel model)
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
                Birth = model.Birth,

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

            return CustomerDTO;

        }


        public async Task<bool> Delate(int id)
        { 
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) throw new Exception("customer not found");
            _context.Customers.Remove(customer);
            var result = await _context.SaveChangesAsync();
            return result > 0 && result < 1;








        }
       }
    }



