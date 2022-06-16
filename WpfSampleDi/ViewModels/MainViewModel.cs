namespace WpfSampleDi.ViewModels;

public sealed class MainViewModel : ViewModelBase
{
    public MainViewModel(ViewModel1 viewModel1, ViewModel2 viewModel2)
    {
        ViewModel1 = viewModel1;
        ViewModel2 = viewModel2;
    }
    
    public ViewModel1 ViewModel1 { get; }
    
    public ViewModel2 ViewModel2 { get; }
}
