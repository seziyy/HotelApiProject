namespace HotelApiProject.Models.Responses.PriceSearches;

public class Body
{
    public string searchId { get; set; }
    public DateTime expiresOn { get; set; }
    public List<Hotel> hotels { get; set; }
    public Details details { get; set; }
}
