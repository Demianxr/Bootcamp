using Core.Entities;
using Core.Models;
using Core.Requests;
using Mapster;

namespace Infrastructure.Mappings
{
    public class CreditCardMappingConfiguration
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateCreditCardModel, CreditCard>()
                .Map(dest => dest.Designation, src => src.Designation)
                .Map(dest => dest.IssueDate, src => src.IssueDate)
                .Map(dest => dest.ExpirationDate, src => src.ExpirationDate)
                .Map(dest => dest.CardNumber, src => src.CardNumber)
                .Map(dest => dest.CVV, src => src.CVV)
                .Map(dest => dest.CreditCardStatus, src => src.CreditCardStatus)
                .Map(dest => dest.CreditLimit, src => src.CreditLimit)
                .Map(dest => dest.InterestRate, src => src.InterestRate);

            config.NewConfig<CreditCard, CreditCardDTO>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Designation, src => src.Designation)
                .Map(dest => dest.IssueDate, src => src.IssueDate)
                .Map(dest => dest.ExpirationDate, src => src.ExpirationDate)
                .Map(dest => dest.CreditCardStatus, src => src.CreditCardStatus)
                .Map(dest => dest.CreditLimit, src => src.CreditLimit)
                .Map(dest => dest.InterestRate, src => src.InterestRate)
                .Map(dest => dest.Availablecredit, src => src.Availablecredit)
                .Map(dest => dest.Currentdebt, src => src.Currentdebt);
        }
    }
}
