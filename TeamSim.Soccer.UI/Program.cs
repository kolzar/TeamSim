using TeamSim.Soccer.Core.Services.Generators;
using TeamSim.Soccer.UI.Components;

var builder = WebApplication.CreateBuilder(args);

// Configura il logging
builder.Logging.ClearProviders(); // Rimuove i provider predefiniti
builder.Logging.AddConsole();    // Aggiunge il logging alla console
builder.Logging.SetMinimumLevel(LogLevel.Debug); // Imposta il livello minimo di log
builder.Logging.AddFile("Logs/log.txt");

// Percorso del file JSON
string jsonFilePath = "Data/nations.json";

// Registra l'interfaccia e l'implementazione
builder.Services.AddSingleton(new CountryService(jsonFilePath));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

