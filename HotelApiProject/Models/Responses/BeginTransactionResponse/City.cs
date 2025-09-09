namespace HotelApiProject.Models.Responses.BeginTransactionResponse;

public class City
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string internationalName { get; set; }
    public int? Type { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public string ParentId { get; set; }
    public string CountryId { get; set; }
    public DateTime? ChangeDate { get; set; }
    public int? Provider { get; set; }
    public bool? isTopRegion { get; set; }
    public bool? ownLocation { get; set; }
    public int? displayOrder { get; set; }
}


