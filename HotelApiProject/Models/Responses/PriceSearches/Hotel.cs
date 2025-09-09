namespace HotelApiProject.Models.Responses.PriceSearches;

public class Hotel
{
    public Geolocation geolocation { get; set; }
    public float stars { get; set; }
    public List<Theme> themes { get; set; }
    public List<Board> boards { get; set; }
    public Country country { get; set; }
    public City city { get; set; }
    public GiataInfo giataInfo { get; set; }
    public Town town { get; set; }
    public Village village { get; set; }
    public List<Offer> offers { get; set; }
    public string address { get; set; }
    public int provider { get; set; }
    public string thumbnail { get; set; }
    public string thumbnailFull { get; set; }
    public Description description { get; set; }
    public string id { get; set; }
    public string name { get; set; }
}
