using HotelApiProject.Models.Requests;

namespace HotelApiProject.Models;

public class GetCheckinDatesRequest
{
    public int ProductType { get; set; }
    public bool IncludeSubLocations { get; set; }
    public object? Product { get; set; }
    public List<ArrivalLocation> ArrivalLocations { get; set; }
}

