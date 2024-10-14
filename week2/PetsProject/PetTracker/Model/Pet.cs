namespace PetTracker.Model;

public class Pet
{
    public string Name { get; set; } = "";
    public string Animal_Type { get; set; } = "";
    public DateOnly Birthday { get; set; } = new DateOnly(1, 1, 0001);

    public Owner PetOwner = new();

    
    
    
    
    
    
    
    
    
    
    
    
    
    public Pet(string Name, string Animal_Type, DateOnly Birthday)
    {
        this.Name = Name;
        this.Animal_Type = Animal_Type;
        this.Birthday = Birthday;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nType: {Animal_Type}\nDOB: {Birthday}";
    }
}