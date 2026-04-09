namespace oopweek10;

public class Event
{
    
    public string description { get; set; }
    public int number { get; set; }
    public string type { get; set; }
    

    public void Persone(string Description, int Number, string Type)
    {
        description = Description;
        number = Number;
        type = Type;
        
    }
    
    
}