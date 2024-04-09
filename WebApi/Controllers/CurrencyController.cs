﻿using Core.Interfaces.Services;
using Core.Request;
using Core.Requests;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CurrencyController : BaseApiController
    {
        private readonly IcurrencyService _currencyService;

        public CurrencyController(IcurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpGet("filtered")]
        public async Task<IActionResult> GetFiltered([FromQuery] FilterCurrencyModel filter)
        {
            var currency = await _currencyService.GetFiltered(filter);
            return Ok(currency);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCurrencyModel request)
        {
            return Ok(await _currencyService.Add(request));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var currency = await _currencyService.GetById(id);
            return Ok(currency);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCurrencyModel request)
        {
            return Ok(await _currencyService.Update(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _currencyService.Delete(id));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var currency = await _currencyService.GetAll();
            return Ok(currency);
        }
    }
}
