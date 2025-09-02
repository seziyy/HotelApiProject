namespace HotelApiProject.Models
{
    public class PriceSearchResponse
    {
            public int HotelId { get; set; }
            public List<RoomDetail> AvailableRooms { get; set; }
        
    }
}
