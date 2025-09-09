namespace HotelApiProject.Models.Responses;

public class HotelDetailResponse
{
    public Header Header { get; set; }
    public Body Body { get; set; }
}

public class Header
{
    public string requestId { get; set; }
    public bool Success { get; set; }
    public DateTime responseTime { get; set; }
    public List<ResponseMessage> Messages { get; set; }
}

public class Body
{
    public Hotel Hotel { get; set; }
}

public class Hotel
{
    public List<Season> Seasons { get; set; }
    public Address Address { get; set; }
    public string faxNumber { get; set; }
    public string phoneNumber { get; set; }
    public string homePage { get; set; }
    public int stopSaleGuaranteed { get; set; }
    public int stopSaleStandart { get; set; }
    public List<object> Handicaps { get; set; }
    public Geolocation Geolocation { get; set; }
    public int Stars { get; set; }
    public double Rating { get; set; }
    public List<Theme> Themes { get; set; }
    public Location Location { get; set; }
    public Country Country { get; set; }
    public City City { get; set; }
    public GiataInfo giataInfo { get; set; }
    public HotelCategory hotelCategory { get; set; }
    public bool hasChannelManagerOffer { get; set; }
    public int Provider { get; set; }
    public string Thumbnail { get; set; }
    public string thumbnailFull { get; set; }
    public Description Description { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Season
{
    public string Name { get; set; }
    public List<TextCategory> textCategories { get; set; }
    public List<FacilityCategory> facilityCategories { get; set; }
    public List<MediaFile> mediaFiles { get; set; }
}

public class TextCategory
{
    public string Name { get; set; }
    public List<Presentation> Presentations { get; set; }
}

public class Presentation
{
    public int textType { get; set; }
    public string Text { get; set; }
}

public class FacilityCategory
{
    public string Name { get; set; }
    public List<Facility> Facilities { get; set; }
}

public class Facility
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool isPriced { get; set; }
}

public class MediaFile
{
    public int fileType { get; set; }
    public string Url { get; set; }
    public string urlFull { get; set; }
}

public class Address
{
    public City City { get; set; }
    public List<string> addressLines { get; set; }
    public string Street { get; set; }
    public string streetNumber { get; set; }
    public Geolocation Geolocation { get; set; }
}

public class Geolocation
{
    public string Longitude { get; set; }
    public string Latitude { get; set; }
}

public class Theme
{
    public string Id { get; set; }
    public string Name { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int Provider { get; set; }
    public bool isTopRegion { get; set; }
    public bool ownLocation { get; set; }
    public string Id { get; set; }
}

public class Country
{
    public string Name { get; set; }
    public int Provider { get; set; }
    public bool isTopRegion { get; set; }
    public bool ownLocation { get; set; }
    public string Id { get; set; }
}

public class City
{
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public int Provider { get; set; }
    public bool isTopRegion { get; set; }
    public bool ownLocation { get; set; }
    public string Id { get; set; }
}

public class GiataInfo
{
    public string hotelId { get; set; }
    public string destinationId { get; set; }
}

public class HotelCategory
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Code { get; set; }
}

public class Description
{
    public string Text { get; set; }
}