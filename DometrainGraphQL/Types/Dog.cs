public class Dog : IPet,IMammal
{
  public  string Name { get; }
    public string DisPlayName() => $"{Name} {Bread}";


    public string Bread
    {
        get;  
    }

     
    public Dog(string name , string bread)
    {
        Name = name;
        Bread = bread;
    }
}
