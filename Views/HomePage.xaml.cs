namespace Elian_App.Views;

public partial class HomePage : ContentPage
{
    int count = 0;

    public HomePage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Cliqué {count} fois";
        else
            CounterBtn.Text = $"Cliqué {count} fois";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}