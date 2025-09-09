namespace HotelApiProject.Models.Responses.Autocompletes
{
    public class Item
    {
        public int Type { get; set; }
        public Geolocation Geolocation { get; set; }
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
        public GiataInfo GiataInfo { get; set; }
        public int Provider { get; set; }
    }
}
