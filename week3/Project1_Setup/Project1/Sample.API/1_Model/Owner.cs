namespace Sample.API.Model;

public class Owner
{
    public int Id {get;set;}
    public string Name {get;set;} = "";

    public List<Pet> Pets {get;set;} = [];
}