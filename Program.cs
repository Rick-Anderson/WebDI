using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureServices(services =>
{
    services.TryAddSingleton<IService, Service1>();
});

builder.Services.TryAddSingleton<IService2, Service2>();


builder.Services.AddRazorPages();

var app = builder.Build();

Console.WriteLine(app.Services.GetRequiredService<IService>());
Console.WriteLine(app.Services.GetRequiredService<IService2>());

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

class Service1 : IService
{
    public void WriteMessage(string message)
    {
        Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
    }
}

class Service2 : IService2
{
    public void WriteMessage(string message)
    {
        Console.WriteLine($"MyDependency.WriteMessage Message: {message}");
    }
}

public interface IService
{
    void WriteMessage(string message);
}

public interface IService2
{
    void WriteMessage(string message);
}