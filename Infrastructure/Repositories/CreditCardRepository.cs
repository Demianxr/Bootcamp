using Core.Interfaces.Repositories;
using Core.Models;
using Core.Requests;
using Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private readonly BootcampContext _context;

        public CreditCardRepository(BootcampContext context)
        {
            _context = context;
        }

        public async Task<CreditCardDTO> Add(CreateCreditCardModel model)
        {
            var creditCardToCreate = model.Adapt<CreditCardDTO>();

            _context.Add(creditCardToCreate);
            await _context.SaveChangesAsync();

            var creditCardDTO = creditCardToCreate.Adapt<CreditCardDTO>();

            return creditCardDTO;
        }

        public async Task<bool> Delete(int id)
        {
            var creditCard = await _context.CreditCards.FindAsync(id);

            if (creditCard == null) throw new Exception("Credit card not found");

            _context.CreditCards.Remove(creditCard);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<List<CreditCardDTO>> GetAll()
        {
            var creditCards = await _context.CreditCards.ToListAsync();

            var creditCardDTOs = creditCards.Adapt<List<CreditCardDTO>>();

            return creditCardDTOs;
        }

        public async Task<CreditCardDTO> GetById(int id)
        {
            var creditCard = await _context.CreditCards.FindAsync(id);

            if (creditCard == null) throw new Exception("Credit card not found");

            var creditCardDTO = creditCard.Adapt<CreditCardDTO>();

            return creditCardDTO;
        }

        public async Task<List<CreditCardDTO>> GetFiltered(FilterCreditCardModel filter)
        {
            var query = _context.CreditCards.AsQueryable();


            var result = await query.ToListAsync();

            var creditCardDTOs = result.Adapt<List<CreditCardDTO>>();

            return creditCardDTOs;
        }

        public async Task<CreditCardDTO> Update(UpdateCreditCardModel model)
        {
            var creditCard = await _context.CreditCards.FindAsync(model.Id);

            if (creditCard == null) throw new Exception("Credit card not found");

            model.Adapt(creditCard);

            _context.CreditCards.Update(creditCard);

            await _context.SaveChangesAsync();

            var creditCardDTO = creditCard.Adapt<CreditCardDTO>();

            return creditCardDTO;
        }

      }

  }


