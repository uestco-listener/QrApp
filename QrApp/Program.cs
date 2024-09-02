using QrApp;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
var firstStart = new FirstStartFunction();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/json");
    logging.ResponseBodyLogLimit = int.MaxValue;
    logging.RequestBodyLogLimit = int.MaxValue;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyHeader().AllowCredentials().AllowAnyMethod().AllowAnyOrigin().WithOrigins(new string[] { "http://localhost:3000", "http://10.8.0.39:3000", "http://192.168.88.8:3000", "http://172.18.0.5:3000", "http://10.8.0.47:3000", "http://192.168.68.30:3000" }
                                              );
                      });
});
//builder.Host.UseWindowsService();

var app = builder.Build();


app.UseCors(MyAllowSpecificOrigins);
app.UseRouting();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
