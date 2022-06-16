using Microsoft.Extensions.Logging;
using Microsoft.Toolkit.Mvvm.Input;
using System;

namespace WpfSampleDi.ViewModels;

public sealed class ViewModel1 : ViewModelBase
{
    private readonly ILogger<ViewModel1> _logger;
    private string _uriString;
    private Uri _actualUri;

    public ViewModel1(ILogger<ViewModel1> logger)
    {
        _logger = logger;
        SetUriCommand = new RelayCommand(DoSet);
        logger.LogInformation("ViewModel1 created");
    }

    public string UriString
    {
        get => _uriString;
        set => SetProperty(ref _uriString, value);
    }

    public Uri ActualUri
    {
        get => _actualUri;
        set => SetProperty(ref _actualUri, value);
    }

    public IRelayCommand SetUriCommand { get; }

    private void DoSet()
    {
        _logger.LogInformation("User url visit request");

        try
        {
            _logger.LogDebug("User try visiting '{Uri}'", UriString);
            ActualUri = new Uri(UriString, UriKind.Absolute);
        }
        catch (Exception error)
        {
            _logger.LogError(error, "Can't parse URI: '{Uri}'", UriString);
        }
    }
}
