namespace DometrainGraphQL.Types
{
    public class Query
    {
        public Book GetBook() =>
           new Book("C# in Depth", new Author("Jon Sallam"));
    }
}
 