namespace DotnetCoreJQuery.Models
{
    public class CitiesInfo
    {
        public List<CountryInfo> countryInfo = new List<CountryInfo>();
        public List<CountryInfo> CountryInfoList
        {
            get { return countryInfo; }
            set {countryInfo = value; }
        }

        public List<StateInfo> stateInfo = new List<StateInfo>();
        public List<StateInfo> StateInfoList
        {
            get { return stateInfo; }
            set { stateInfo = value; }
        }

        public List<CityInfo> cityInfo = new List<CityInfo>();
        public List<CityInfo> CityInfoList
        {
            get { return cityInfo; }
            set { cityInfo = value; }
        }

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
