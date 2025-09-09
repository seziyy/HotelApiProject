namespace HotelApiProject.Models;

public class GetCheckinDatesResponse
{
    public CheckinDatesBody Body { get; set; }
    public ResponseHeader Header { get; set; }
}

public class CheckinDatesBody
{
    public List<DateTime> Dates { get; set; }
}

public enum ProductType
{
    Excursion = 0,
    Transfer = 1
}