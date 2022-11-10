namespace MyStarterKit.Views;

public partial class WebViewSamplePage : ContentPage
{
	public WebViewSamplePage(WebViewSampleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
