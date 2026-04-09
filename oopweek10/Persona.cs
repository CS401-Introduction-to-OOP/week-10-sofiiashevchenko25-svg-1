namespace oopweek10;

public class Persona
{
    public string name { get; set; }
    public string role { get; set; }
    public int level { get; set; }
    public int hp { get; set; }
    public int gold { get; set; }
    public string Status { get; set; }

    public Persona(string Name, string Role, int Level, int Hp, int Gold, string Status)
    {
        name = Name;
        role = Role;
        level = Level;
        hp = Hp;
        gold = Gold;
        this.Status = Status;
    }
    
    
}