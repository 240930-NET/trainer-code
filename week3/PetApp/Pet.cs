public class Pet{

    public int PetId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Age { get; set; }

    public string PrintPet(){
        return $"Pet Name: {Name}, Type: {Type}, Age: {Age}";
    }

}