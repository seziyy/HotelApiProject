namespace HotelApiProject.Models
{
    public class AutocompleteRequest
    {
        public int ProductType { get; set; } = 2;
        public string Query { get; set; }
        public string Culture { get; set; } = "en-US";
    }
}
