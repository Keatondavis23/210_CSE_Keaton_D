namespace Foundation3;
 
class Event {
    public string title;
    private string description;
    public DateTime date;
    private TimeSpan time;
    private Address address;
    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return
            $"\nEvent: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
    }
}
