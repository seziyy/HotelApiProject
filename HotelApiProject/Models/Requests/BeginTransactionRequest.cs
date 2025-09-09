namespace HotelApiProject.Models.Requests
{
    public class BeginTransactionRequest
    {
        public List<string> offerIds { get; set; }
        public string currency { get; set; }
        public string culture { get; set; }
    }
}
