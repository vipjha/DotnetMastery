namespace DotnetCoreJQuery.Models
{
    public class CitiesInfo
    {
    }

    public class CountryInfo
    {
        public int CId { get; set; }
        public string CName { get; set; }
    }

    public class StateInfo
    {
        public int SId { get; set; } 
        public string SName { get; set; } 
        public int CId { get; set; }
    }

    public class CityInfo
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int SId { get; set; }

    }
}
