using HotelApiProject.Models.Responses;

namespace HotelApiProject.Models;

public class PriceSearchResponse
{
    public Header header { get; set; }
    public HotelApiProject.Models.Responses.PriceSearches.Body body { get; set; }
}
