using HotelApiProject.Models.Responses.PriceSearches;

namespace HotelApiProject.Models;

public class Room
{
    public string roomId { get; set; }
    public string roomName { get; set; }
    public List<object> roomGroups { get; set; }
    public string accomId { get; set; }
    public string accomName { get; set; }
    public string boardId { get; set; }
    public string boardName { get; set; }
    public List<object> boardGroups { get; set; }
    public int allotment { get; set; }
    public int stopSaleGuaranteed { get; set; }
    public int stopSaleStandart { get; set; }
    public Price price { get; set; }
    public List<Traveller> travellers { get; set; }
}
