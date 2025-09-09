namespace HotelApiProject.Models.Responses;

public class ResponseMessage
{
    public int id { get; set; }
    public string code { get; set; }
    public int messageType { get; set; }
    public string message { get; set; }
}
