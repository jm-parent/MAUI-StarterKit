namespace MyStarterKit.Views;

public partial class ListDetailSampleDetailPage : ContentPage
{
    public ListDetailSampleDetailPage(ListDetailSampleDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
