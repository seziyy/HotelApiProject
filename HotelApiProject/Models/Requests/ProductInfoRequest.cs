namespace HotelApiProject.Models;

public class ProductInfoRequest
{
    public int ProductType { get; set; }
    public int OwnerProvider { get; set; }
    public string Product { get; set; }
    public string Culture { get; set; }
}