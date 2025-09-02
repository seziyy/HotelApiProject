namespace HotelApiProject.Models
{
    public class ProductInfoResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Star { get; set; }
        public List<string> Images { get; set; }
        public List<string> Features { get; set; }
     
    }
}
