using System.Reflection;
using System.Text.Json.Serialization;
using SampleApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddSingleton<PeopleRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlazorTest");
        c.RoutePrefix = "";
        c.DocExpansion(DocExpansion.None);
        c.DefaultModelsExpandDepth(-1);
        c.DisplayRequestDuration();
        c.EnableDeepLinking();
        c.DefaultModelRendering(ModelRendering.Example);
        c.EnableFilter();
        c.ShowExtensions();
        c.EnableValidator();
    });
}

app.UseCors(x => x
    .WithOrigins("http://localhost:8080")
    .AllowAnyMethod()
    .AllowCredentials()
    .AllowAnyHeader());

app.UseAuthorization();
app.MapControllers();
app.Run();