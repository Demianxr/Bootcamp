﻿using Core.Entities;
using Core.Models;
using Core.Request;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mappings;

public class MovementMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateMovementModel, Movement>()
           .Map(dest => dest.Description, src =>
                $"{src.Description}," +
                $"Destination Bank: {src.DestinationBankId}," +
                $"Destination Account Number: " + $"{src.DestinationAccountNumber}," +
                $"Destination Document Number: " + $"{src.DestinationDocumentNumber}," +
                $"Currency: " + $"{src.CurrencyId},")

           .Map(dest => dest.Amount, src => src.Amount)
           .Map(dest => dest.TransferredDateTime, src => src.TransferredDateTime)
           .Map(dest => dest.AccountSourceId, src => src.AccountSourceId)
           .Map(dest => dest.AccountDestinationId, src => src.AccountDestinationId);

        config.NewConfig<Movement, MovementDTO>()
           .Map(dest => dest.Id, src => src.Id)
           .Map(dest => dest.Description, src => src.Description)
           .Map(dest => dest.Amount, src => src.Amount)
           .Map(dest => dest.TransferredDateTime, src => src.TransferredDateTime)
           .Map(dest => dest.TransferStatus, src => src.TransferStatus)
           .Map(dest => dest.AccountSource, src => src.AccountSourceId)
           .Map(dest => dest.AccountDestination, src => src.AccountDestinationId);
    }
}