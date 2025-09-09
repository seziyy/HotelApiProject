namespace HotelApiProject.Models.Responses.ProductInfos;

public class Address
{
    public City city { get; set; }
    public List<string> addressLines { get; set; }
    public string street { get; set; }
    public string streetNumber { get; set; }
    public Geolocation geolocation { get; set; }
}
