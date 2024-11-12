using DometrainGraphQL.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer().
    AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGraphQL();
 
app.Run();

