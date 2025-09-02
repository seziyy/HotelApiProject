namespace HotelApiProject.Models
{
    public class SearchModel
    {
        public int ProductType { get; set; } = 2;
        public string Query { get; set; }
        public string Culture { get; set; } = "en-US";
    }
}
