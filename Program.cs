using EldaraaApi.Data;
using Microsoft.EntityFrameworkCore;

// Detectar si se está corriendo en Docker (esto lo setea la imagen base oficial)
var isRunningInDocker = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EldaraaDbContext>(options =>
    options.UseSqlite("Data Source=eldaraa.db"));


// Configuración de Kestrel
builder.WebHost.ConfigureKestrel(options =>
{
    if (isRunningInDocker)
    {
        // 🐳 Docker: sólo HTTP puerto 80
        options.ListenAnyIP(80);
    }
    else
    {
        try
        {
            var certPath = Path.Combine(AppContext.BaseDirectory, "localhost.pfx");
            var certPassword = "27982218"; 
            if (File.Exists(certPath))
            {
                options.ListenLocalhost(64010, listenOptions =>
                {
                    listenOptions.UseHttps(certPath, certPassword);
                });

                options.ListenLocalhost(64011); // HTTP opcional
            }
            else
            {
                Console.WriteLine("⚠️ No se encontró el certificado. Usando solo HTTP local.");
                options.ListenLocalhost(64011);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"💥 Error configurando HTTPS: {ex.Message}");
            options.ListenLocalhost(64011); // fallback a HTTP
        }
    }
});

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger solo en dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.MapControllers();
app.Run();
