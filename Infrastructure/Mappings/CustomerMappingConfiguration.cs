using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Models;
using Core.Request;
using Mapster;

namespace Infrastructure.Mappings
{
    public class CustomerMappingConfiguration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateCustomerModel, Customer>()
            .Map(dest => dest.Id, src => src.BankId)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Lastname, src => src.Lastname)
            .Map(dest => dest.DocumentNumber, src => src.DocumentNumber)
            .Map(dest => dest.Address, src => src.Address)
            .Map(dest => dest.Mail, src => src.Mail)
            .Map(dest => dest.Phone, src => src.Phone)
            .Map(dest => dest.CustomerStatus, src => src.CustomerStatus)
            .Map(dest => dest.Birth, src => src.Birth)
            .Map(dest => dest.BankId, src => src.BankId);

            config.NewConfig<Customer, customerDTO>()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.Lastname, src => src.Lastname)
            .Map(dest => dest.DocumentNumber, src => src.DocumentNumber)
            .Map(dest => dest.Address, src => src.Address)
            .Map(dest => dest.Mail, src => src.Mail)
            .Map(dest => dest.Phone, src => src.Phone)
            .Map(dest => dest.CustomerStatus, src => src.CustomerStatus)
            .Map(dest => dest.Birth, src => src.Birth)
            .Map(dest => dest.Bank, src => src.Bank);




        }
    }
}
