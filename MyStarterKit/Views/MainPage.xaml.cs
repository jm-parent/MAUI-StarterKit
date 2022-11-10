namespace MyStarterKit.Views;

public partial class MainPage : BasePage
{
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
