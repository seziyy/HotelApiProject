namespace HotelApiProject.Models
{
    public class ProductInfoRequest
    {
        public class GetOffersRequest
        {
            public int productType { get; set; }
            public int ownerProvider { get; set; }
            public string product { get; set; }
            public string culture { get; set; }
        }

    }
}
