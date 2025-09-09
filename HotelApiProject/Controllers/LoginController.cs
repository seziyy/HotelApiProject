using HotelApiProject.Models;
using HotelApiProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly ISantsgApiService _santsgApiService;

    public LoginController(ISantsgApiService santsgApiService)
    {
        _santsgApiService = santsgApiService;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        await _santsgApiService.LoginAsync(request);

        return Ok();
    }
  
}