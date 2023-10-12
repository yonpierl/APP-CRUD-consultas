using WAP2._1.views;

namespace WAP2._1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(AddCategoria),typeof(AddCategoria));
		
    }
}
