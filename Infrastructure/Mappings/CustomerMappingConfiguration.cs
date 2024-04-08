using Core.Entities;
using Core.Interfaces.Repositories;
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
            .Map(dest => dest.Lastname, src => src.LastName)
            .Map(dest => dest.DocumentNumber, src => src.DocumentNumer)
            .Map(dest => dest.Address, src => src.Address)
            .Map(dest => dest.Mail, src => src.Mail)
            .Map(dest => dest.Phone, src => src.Phone)
            .Map(dest => dest.CustomerStatus, src => src.customerStatus)
            .Map(dest => dest.Birth, src => src.Birth)
            .Map(dest => dest.BankId, src => src.BankId);

            config.NewConfig<Customer, CustomerDTO>()
            .Map(dest => dest.Id, src => src.BankId)
            .Map(dest => dest.Name, src => src.Name)
            .Map(dest => dest.LastName, src => src.Lastname)
            .Map(dest => dest.DocumentNumber, src => src.DocumentNumber)
            .Map(dest => dest.Address, src => src.Address)
            .Map(dest => dest.Mail, src => src.Mail)
            .Map(dest => dest.Phone, src => src.Phone)
            .Map(dest => dest.CustomerStatus, src => src.CustomerStatus)
            .Map(dest => dest.Birth, src => src.Birth);




        }
    }
}
