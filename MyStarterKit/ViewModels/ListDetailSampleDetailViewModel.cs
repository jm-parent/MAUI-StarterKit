namespace MyStarterKit.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailSampleDetailViewModel : BaseViewModel
{
    [ObservableProperty]
    SampleItem item;
}
