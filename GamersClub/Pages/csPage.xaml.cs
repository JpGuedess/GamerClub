namespace GamersClub.Pages;

public partial class csPage : ContentPage
{
	public csPage()
	{
		InitializeComponent();
	}

    private async void btnOpenSteanAnother_Clicked(object sender, EventArgs e)
    {
        // Link que voc� deseja abrir
        string link = "https://store.steampowered.com/app/730/CounterStrike_2/?l=brazilian";

        // Abre o link no navegador padr�o do dispositivo
        Launcher.OpenAsync(new Uri(link));
    }
}