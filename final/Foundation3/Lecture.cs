namespace Foundation3;
 
class Lecture : Event {
    private string speaker;
    private int capacity;
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }
    public string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
    public string GetShortDescription() {
        return $"\nType: Lecture\nEvent: {title}\nDate: {date.ToShortDateString()}";
        
    }
}
