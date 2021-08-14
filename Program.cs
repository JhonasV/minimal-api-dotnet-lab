
using MinApi.Controllers;
using MinApi.Routes;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureServices((webHost, services) => {
    MinApi.Configuration.IocConfiguration.Init(services, webHost.Configuration); 
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

new Routes().Init(app);

app.Run();
