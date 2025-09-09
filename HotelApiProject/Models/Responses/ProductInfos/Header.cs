namespace HotelApiProject.Models.Responses.ProductInfos;

public class Header
{
    public string requestId { get; set; }
    public bool success { get; set; }
    public DateTime responseTime { get; set; }
    public List<Message> messages { get; set; }
}
