namespace MyStarterKit;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ListDetailSampleDetailPage), typeof(ListDetailSampleDetailPage));
	}
}
