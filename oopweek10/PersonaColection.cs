namespace oopweek10;

using System.Collections;
using System.Collections.Generic;

public class PersonaColection : IEnumerable<Persona>
{
    private List<Persona> party = new List<Persona>();
    

    public void AddCharacter(Persona character)
    {
        party.Add(character);
    }



    public IEnumerator<Persona> GetEnumerator()
    {
        foreach (var character in party)
        {
            yield return character;
        }
    }
    
    public IEnumerator<Persona> GetCharacterByStatus(string status)
    {
        foreach (var character in party)
        {
            if (character.Status == status)
            {
                yield return character;
            }
        }
    }

    public IEnumerable CharacterLevel(int level)
    {
        var result = party.Where(x => x.level == level);
        return result;
    }

    public IEnumerable SortByHP()
    {
        var sorted = party.OrderBy(x => x.hp);
        return sorted;
    }

    public IEnumerable Names()
    {
        var names = party.Select(x => x.name);
        return names;
    }

    public int maxGold()
    {
        int max = party.Max(s => s.gold);
        return max;
    }

    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return party.GetEnumerator();
    }
}
