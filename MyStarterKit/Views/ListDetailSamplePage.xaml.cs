namespace MyStarterKit.Views;

public partial class ListDetailSamplePage : ContentPage
{
    ListDetailSampleViewModel ViewModel;

    public ListDetailSamplePage(ListDetailSampleViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = ViewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}
