using Core.DTOs;
using Core.Entities;
using Core.Models;
using Core.Requests;
using Core.ViewModels;
using Mapster;

namespace Infrastructure.Mappings
{
    public class EnterpriseMappingConfiguration
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateEnterpriseModel, Enterprise>()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Address, src => src.Address)
                .Map(dest => dest.Phone, src => src.Phone)
                .Map(dest => dest.Email, src => src.Email);

            config.NewConfig<Enterprise, EnterpriseDTO>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Address, src => src.Address)
                .Map(dest => dest.Phone, src => src.Phone)
                .Map(dest => dest.Email, src => src.Email);
        }
    }
}
