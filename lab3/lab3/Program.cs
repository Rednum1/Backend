using WebApplication3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<ITimeService, ShortTimeService>();
builder.Services.AddTransient<ICalcService, CalcService>();


var app = builder.Build();

app.UseMiddleware<TimeMiddleware>();
app.UseMiddleware<CalcServiceMiddleware>();

app.Run();
