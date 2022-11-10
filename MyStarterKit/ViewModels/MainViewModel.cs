using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.VisualBasic;
using System.Windows.Input;

namespace MyStarterKit.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public IRelayCommand ShowToastCmd => new RelayCommand(async () =>
    {
       await CommunityToolkit.Maui.Alerts.Toast.Make("This is a Toast").Show();
    });
    public IRelayCommand ShowSnackBarCmd => new RelayCommand(async () =>
    {
        //Clicking on Ok open another instance of the app. 
        //Seems to be a Alerts Issue
        await CommunityToolkit.Maui.Alerts.Snackbar.Make("This is a SnackBar").Show();
    });

    [ObservableProperty]
    private string fullPageState;
 

    public IRelayCommand ToggleStateCommand => new RelayCommand(async () =>
    {
        FullPageState =string.IsNullOrEmpty(FullPageState) ? StateKey.Loading : string.Empty;
    });

}

static class StateKey
{
    public const string Loading = "Loading";
    public const string Success = "Success";
    public const string Anything = "StateKey can be anything!";
    public const string ReplaceGrid = "ReplaceGrid";
    public const string NoAnimate = "NoAnimate";
    public const string NotFound = "NotFoundExampleKey";
}
