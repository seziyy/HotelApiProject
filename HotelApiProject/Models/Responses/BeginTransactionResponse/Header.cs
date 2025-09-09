namespace HotelApiProject.Models.Responses.BeginTransactionResponse;

public class Header
{
    public string requestId { get; set; }
    public bool Success { get; set; }
    public DateTime responseTime { get; set; }
    public List<ResponseMessage> Messages { get; set; }
}


