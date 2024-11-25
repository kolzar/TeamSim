using TeamSim.Components;

var builder = WebApplication.CreateBuilder(args);

// Configura il logging
builder.Logging.ClearProviders(); // Rimuove i provider predefiniti
builder.Logging.AddConsole();    // Aggiunge il logging alla console
builder.Logging.SetMinimumLevel(LogLevel.Debug); // Imposta il livello minimo di log
builder.Logging.AddFile("Logs/log.txt");

// Add services to the container.
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddLocalization(options => options.ResourcesPath = "Locales");

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



// Configura localizzazione
var supportedCultures = new[] { "it" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("it")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
