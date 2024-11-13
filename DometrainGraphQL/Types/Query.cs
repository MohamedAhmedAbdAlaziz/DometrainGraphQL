namespace DometrainGraphQL.Types
{
    public class Query
    {

        private bool _dog;

        public string GetDogName(Dog dog)
        {
            return dog.Name;
        }
        public IEnumerable<Cat> GetAllCats(CatLives? catLives)
        {
            if (catLives != null) {

                return GetPets().OfType<Cat>().Where(x=>x.Lives == catLives);    
            }

            return GetPets().OfType<Cat>();
        }

        public Book GetBook() =>
           new Book("C# in Depth", new Author("Jon Sallam"));

        public IEnumerable<IPet> GetPets() =>
               new IPet[]
               {
                   new Dog ("Buddy" , "Golden Retriever"),
                   new Cat ("Snowball" , true , CatLives.one),
                   new Cat ("Snowball__2" , true , CatLives.Nine),
                   new Cat ("Snowball__3" , true , CatLives.Three),
                   new Cat ("Snowball" , true , CatLives.one),
                   new Parrot ("Buddy" ,true),
               };

        public IMammal GetCatOrDog()
            {
        _dog= !_dog;
            return _dog
            ? new Dog("Buddy", "Golden Retriever")
            : new Cat("Snowball", true, CatLives.Seven);
    }
}}

[UnionType("Mamml")]
public interface IMammal
{

}