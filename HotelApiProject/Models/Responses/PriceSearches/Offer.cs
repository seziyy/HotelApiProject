namespace HotelApiProject.Models.Responses.PriceSearches;

public class Offer
{
    public int night { get; set; }
    public bool isAvailable { get; set; }
    public List<Room> rooms { get; set; }
    public bool isRefundable { get; set; }
    public string offerId { get; set; }
    public DateTime checkIn { get; set; }
    public Price price { get; set; }
    public bool ownOffer { get; set; }
}
