namespace Foundation3;
 
class OutdoorGathering : Event {
    private string weatherForecast;
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address) {
        this.weatherForecast = weatherForecast;
    }
    public string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
    public string GetShortDescription() {
        return $"\nType: Outdoor Gathering\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}
