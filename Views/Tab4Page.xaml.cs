namespace Elian_App.Views;

public partial class Tab4Page : ContentPage
{
    private bool _isClockRunning;

    public Tab4Page()
    {
        InitializeComponent();
    }

    private async void OnStartClockButtonClicked(object sender, EventArgs e)
    {
        _isClockRunning = !_isClockRunning;
        ((Button)sender).Text = _isClockRunning ? "Arrêter l'horloge" : "Démarrer l'horloge";

        while (_isClockRunning)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            await Task.Delay(1000);
        }
    }

    private void OnChangeColorClicked(object sender, EventArgs e)
    {
        var r = new Random();
        BackgroundColor = Color.FromRgb(r.Next(256), r.Next(256), r.Next(256));
    }
}