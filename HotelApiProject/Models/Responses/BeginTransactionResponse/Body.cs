namespace HotelApiProject.Models.Responses.BeginTransactionResponse;

public class Body
{
    public string transactionId { get; set; }
    public DateTime expiresOn { get; set; }
    public ReservationData reservationData { get; set; }
    public int Status { get; set; }
    public int transactionType { get; set; }
}


