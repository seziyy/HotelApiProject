using HotelApiProject.Services;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using HotelApiProject.Models.Requests;

namespace HotelApiProject.Mcp
{
    [McpServerToolType] 
    public class PriceSearchTool
    {
        private readonly ISantsgApiService _santsgApiService;

        public PriceSearchTool(ISantsgApiService santsgApiService)
        {
            _santsgApiService = santsgApiService;
        }

        [McpServerTool, Description("Fiyat arama işlemi yapar. product type for hotel is 2.")]
        public async Task<object?> SearchPriceAsync(PriceSearchRequest request)
        {
            var result = await _santsgApiService.GetPriceSearchAsync(request);

            if (result == null)
            {
                return new { message = "Hiç sonuç yok." };
            }

            return result;
        }

    }
}