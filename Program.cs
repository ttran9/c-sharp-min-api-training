using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

/*
  * The method below sets up header information on your API,
  * like what it's called and the version number.
  */
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todo API", Description = "Keep track of your tasks", Version = "v1" });
   });


var app = builder.Build();

 /*
  * These two code lines tell the API project to use Swagger and 
  * also where to find the specification file swagger.json.
  */
   app.UseSwagger();
app.UseSwaggerUI(c =>
   {
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
   });


app.MapGet("/", () => "Hello World!");

app.Run();
