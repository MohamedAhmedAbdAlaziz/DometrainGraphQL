using Microsoft.AspNetCore.Authorization.Infrastructure;

public class Cat : IPet, IMammal
{
    public string Name { get; }

    public CatLives Lives { get; }
    public bool IsEveil
    {
        get;
    }


    public Cat(string name, bool isEvil , CatLives catLives)
    {
        Name = name;
        IsEveil = isEvil;
        Lives = catLives;
    }
}
public enum CatLives { one, Two, Three, Four, Five, Six, Seven, Eight, Nine, 
    NineAndAhalf}

