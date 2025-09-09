namespace HotelApiProject.Models.Responses.Autocompletes
{
    public class Header
    {
        public string RequestId { get; set; }
        public bool Success { get; set; }
        public List<Message> Messages { get; set; }
    }
}
