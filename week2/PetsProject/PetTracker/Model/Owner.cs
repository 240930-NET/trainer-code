namespace PetTracker.Model;

public class Owner
{
    public string Name { get; set; } = "";
    public string Phone_Number { get; set; } = "";
    public string Address { get; set; } = "";

    public override string ToString()
    {
        return $"Name: {Name}\nPhone: {Phone_Number}\nAddress: {Address}";
    }
}