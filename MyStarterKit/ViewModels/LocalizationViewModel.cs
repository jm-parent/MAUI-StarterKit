namespace MyStarterKit.ViewModels;

public partial class LocalizationViewModel : BaseViewModel
{
    public string LocalizedText => MyStarterKit.Resources.Strings.AppResources.HelloMessage;
}
