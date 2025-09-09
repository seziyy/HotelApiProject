namespace HotelApiProject.Models.Responses.BeginTransactionResponse;

public class Address
{
    public ContactPhone contactPhone { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string address { get; set; }
    public string zipCode { get; set; }
    public City City { get; set; }
    public Country Country { get; set; }
}


