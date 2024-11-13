using DometrainGraphQL.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer().
    AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Dog>()
    .AddType<Cat>()
    .AddType<Parrot>()
     .AddUnionType<IMammal>()
    .ModifyOptions(x => x.StripLeadingIFromInterface = true);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
 
app.Run();

