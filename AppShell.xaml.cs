using Elian_App.Views;
namespace Elian_App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(GifPage), typeof(GifPage));
    }
}
