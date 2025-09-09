using HotelApiProject.Models;
using HotelApiProject.Models.Requests;
using HotelApiProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly ISantsgApiService _santsgApiService;


        public BookingController(ISantsgApiService a)
        {
            _santsgApiService = a;
        }

        [HttpPost("begintransaction")]
        public async Task<IActionResult> GetBeginTransaction([FromBody] BeginTransactionRequest request)
        {
            var result = await _santsgApiService.GetBeginTransactionAsync(request);

            if (result == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);

        }

        [HttpPost("committransaction")]
        public async Task<IActionResult> GetCommitTransaction([FromBody] CommitTransactionRequest request)
        {
            var result = await _santsgApiService.GetCommitTransactionAsync(request);

            if (result == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);

        }

        [HttpPost("setreservationinfo")]
        public async Task<IActionResult> GetSetReservationInfo([FromBody] SetReservationRequest request)
        {
            // Map SetReservationRequest to SetReservationInfoRequest
            var infoRequest = new HotelApiProject.Services.SetReservationInfoRequest();
            // If you add properties, map them here

            var result = await _santsgApiService.GetSetReservationInfoAsync(infoRequest);

            if (result == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);
        }

    }
}
