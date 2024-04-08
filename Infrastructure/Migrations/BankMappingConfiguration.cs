using Core.Entities;
using Core.Requests;
using Mapster;

namespace Infrastructure.Migrations
{
    public class BankMappingConfiguration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateBankModel, Bank>()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Mail, src => src.Mail)
                .Map(dest => dest.Address, src => src.Address);
            
        }
    }
}
