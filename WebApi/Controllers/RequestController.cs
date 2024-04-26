﻿using Core.Interfaces.Services;
using Core.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class RequestController : BaseApiController
{
    private readonly IRequestService _service;

    public RequestController(IRequestService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateRequestModel request)
    {
        return Ok(await _service.Add(request));
    }


    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var Requests = await _service.GetAll();
        return Ok(Requests);
    }
}