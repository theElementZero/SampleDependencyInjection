using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WpfSampleDi.ViewModels;

namespace WpfSampleDi;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private readonly ServiceProvider _serviceProvider;

    public App()
    {
        var serviceCollection = new ServiceCollection();
        
        ConfigureServices(serviceCollection);

        _serviceProvider = serviceCollection.BuildServiceProvider();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddLogging(logging => logging.AddConsole())
            .AddTransient<ViewModel1>()
            .AddTransient<ViewModel2>()
            .AddTransient<MainViewModel>()
            .AddTransient<MainWindow>();
    }

    private void AppOnStartup(object sender, StartupEventArgs e)
    {
        var mainWindow = _serviceProvider.GetService<MainWindow>();
        mainWindow?.Show();
    }
}
