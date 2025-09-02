using HotelApiProject.Models;
using HotelApiProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.Controllers
{

    [ApiController]

    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ISanTsqApi _santsgApiService;


        public SearchController(ISanTsqApi a)
        {
            _santsgApiService = a;
        }

        [HttpPost("autocomplete")]
        public async Task<IActionResult> GetAutocomplete([FromBody] AutocompleteRequest request)
        {
            var result = await _santsgApiService.GetAutocompleteAsync(request);

            if (result == null || result.Body == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);

        } [HttpPost("getproductinfo")]
        public async Task<IActionResult> GetProductInfo([FromBody] ProductInfoRequest request)
        {
            var result = await _santsgApiService.GetProductInfoAsync(request);

            if (result == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);
        }


        [HttpPost("pricesearch")]
        public async Task<IActionResult> GetPriceSearch([FromBody] PriceSearchRequest request)
        {

            var result = await _santsgApiService.GetPriceSearchAsync(request);

            if (result == null)
            {
                return NotFound("Hiç sonuç bulunamadı.");
            }

            return Ok(result);
        }



        [HttpPost("checkin-dates")]
        public async Task<IActionResult> GetCheckinDates(GetCheckinDatesRequest request)
        {
            var result = await _santsgApiService.GetCheckinDatesAsync(request);

            if (result == null || result.AvailableDates == null || !result.AvailableDates.Any())
            {
                return NotFound("Müsait giriş tarihi bulunamadı.");
            }

            return Ok(result);
        }
    }
}
