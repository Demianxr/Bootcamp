using Core.Entities;
using Core.Models;
using Core.Request;
using Mapster;

namespace Infrastructure.Mappings
{
    public class TransferMappingConfiguration : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateTransferModel, Transfer>()
                .Map(dest => dest.OriginAccountId, src => src.OriginAccountId)
                .Map(dest => dest.DestinationAccountId, src => src.DestinationAccountId)
                .Map(dest => dest.Amount, src => src.Amount);

            config.NewConfig<Transfer, TransferDTO>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.OriginAccountId, src => src.OriginAccountId)
                .Map(dest => dest.DestinationAccountId, src => src.DestinationAccountId)
                .Map(dest => dest.Amount, src => src.Amount)
                .Map(dest => dest.TransferDate, src => src.TransferDate);
        }
    }
}
