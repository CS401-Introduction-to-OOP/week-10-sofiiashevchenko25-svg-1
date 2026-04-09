namespace oopweek10;


using System.Collections;
using System.Collections.Generic;

public class EventColection<Event> : IEnumerable<Event>
{
    
    private List<Event> eventlog = new List<Event>();
    
    public void AddEvent(Event _event)
    {
        eventlog.Add(_event);
    }

    public IEnumerator<Event> GetEnumerator()
    {
        foreach (var character in eventlog)
        {
            yield return character;
        }
    }
    
    
    

    IEnumerator IEnumerable.GetEnumerator()
    {
        return eventlog.GetEnumerator();
    }
}

