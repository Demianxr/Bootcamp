﻿using Core.Models;
using Core.Requests;

namespace Core.Interfaces.Repositories;
public interface ICreditCardRepository
{
    Task<List<CreditCardDTO>> GetFiltered(FilterCreditCardModel filter);
    Task<CreditCardDTO> Add(CreateCreditCardModel model);
    Task<CreditCardDTO> GetById(int id);
    Task<CreditCardDTO> Update(UpdateCreditCardModel model);
    Task<bool> Delete(int id);
    Task<List<CreditCardDTO>> GetAll();
}
