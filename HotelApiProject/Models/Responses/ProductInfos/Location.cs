namespace HotelApiProject.Models.Responses.ProductInfos;

public class Location
{
    public string name { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public int provider { get; set; }
    public bool isTopRegion { get; set; }
    public bool ownLocation { get; set; }
    public string id { get; set; }
}
