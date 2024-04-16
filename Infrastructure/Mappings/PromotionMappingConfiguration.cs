using Core.Entities;
using Core.Models;
using Mapster;
using Core.Requests;
using Core.ViewModels;
using Core.DTOs;

namespace Infrastructure.Mappings
{
    public class PromotionMappingConfiguration
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreatePromotionModel, Promotion>()
                .Map(dest => dest.Start, src => src.Start)
                .Map(dest => dest.End, src => src.End);


            config.NewConfig<Promotion, PromotionDTO>()
                .Map(dest => dest.Id, src => src.Id);
        }
    }
}
