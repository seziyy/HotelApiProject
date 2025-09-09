namespace HotelApiProject.Models.Responses.ProductInfos;

public class Season
{
    public string name { get; set; }
    public List<TextCategory> textCategories { get; set; }
    public List<FacilityCategory> facilityCategories { get; set; }
    public List<MediaFile> mediaFiles { get; set; }
}
