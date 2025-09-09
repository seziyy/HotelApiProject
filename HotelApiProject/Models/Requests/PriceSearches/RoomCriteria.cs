namespace HotelApiProject.Models.Requests.PriceSearches;

public class RoomCriteria
{
    public int adult { get; set; }
    public List<int> childAges { get; set; }
}
