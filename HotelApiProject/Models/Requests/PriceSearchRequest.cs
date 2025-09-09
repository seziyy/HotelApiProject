namespace HotelApiProject.Models.Requests;

public class PriceSearchRequest
{
    public bool checkAllotment { get; set; }
    public bool checkStopSale { get; set; }
    public bool getOnlyDiscountedPrice { get; set; }
    public bool getOnlyBestOffers { get; set; }
    public int productType { get; set; }
    public List<ArrivalLocation> arrivalLocations { get; set; }
    public List<RoomCriteria> roomCriteria { get; set; }
    public string nationality { get; set; }
    public string checkIn { get; set; }
    public int night { get; set; }
    public string currency { get; set; }
    public string culture { get; set; }
}

public class RoomCriteria
{
    public int adult { get; set; }
    public int[]? childAges { get; set; }
}
