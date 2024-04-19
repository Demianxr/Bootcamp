using AutoMapper;
using Core.Constants;
using Core.Entities;
using Core.Models;
using Core.Requests;

namespace Infrastructure.Mappings
{
    public class MovementMappingConfiguration : Profile
    {
        public MovementMappingConfiguration()
        {
            CreateMap<Movement, MovementDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.TransferredDateTime, opt => opt.MapFrom(src => src.TransferredDateTime))
                .ForMember(dest => dest.TransferStatus, opt => opt.MapFrom(src => src.TransferStatus.ToString()))
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId));

            CreateMap<CreateMovementModel, Movement>()
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId))
                .ForMember(dest => dest.TransferredDateTime, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.TransferStatus, opt => opt.MapFrom(src => TransferStatus.Pending));

            CreateMap<UpdateMovementModel, Movement>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId));
        }
    }
}
