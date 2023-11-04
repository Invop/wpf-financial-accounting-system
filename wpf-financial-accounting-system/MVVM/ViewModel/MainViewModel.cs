using wpf_financial_accounting_system.Core;

namespace wpf_financial_accounting_system.MVVM.ViewModel;

internal class MainViewModel : Base.ViewModel
{
    public RelayCommand DashboardViewCommand { get; set; }
    public RelayCommand SettingsViewCommand { get; set; }
    public RelayCommand SpreadsheetViewCommand { get; set; }
    public DashboardViewModel DashboardVm { get; set; }
    public SettingsViewModel SettingsVM { get; set; }
    public SpreadsheetViewModel SpreadsheetVM { get; set; }
    private object _currentView;
    public object CurrentView
    {
        get => _currentView;
        set { _currentView = value; OnPropertyChanged(); }
    }

    public MainViewModel()
    {
        DashboardVm = new DashboardViewModel();
        SettingsVM = new SettingsViewModel();
        SpreadsheetVM = new SpreadsheetViewModel();
        CurrentView = DashboardVm;
        SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            }
        );
        DashboardViewCommand = new RelayCommand(o =>
            {
                CurrentView = DashboardVm;
            }
        );
        SpreadsheetViewCommand = new RelayCommand(o =>
            {
                CurrentView = SpreadsheetVM;
            }
        );
    }
}