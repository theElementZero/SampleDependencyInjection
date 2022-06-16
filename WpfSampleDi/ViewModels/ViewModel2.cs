using Microsoft.Extensions.Logging;

namespace WpfSampleDi.ViewModels;

public sealed class ViewModel2 : ViewModelBase
{
    public ViewModel2(ILogger<ViewModel2> logger)
    {
        logger.LogInformation("ViewModel2 created");
    }   
}
