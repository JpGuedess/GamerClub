namespace GamersClub.Pages;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}
    private async void btnOpenSteanAnother_Clicked(object sender, EventArgs e)
    {
        // Link que voc� deseja abrir
        string link = "https://store.steampowered.com/app/1887840/Another_Crabs_Treasure/";

        // Abre o link no navegador padr�o do dispositivo
        Launcher.OpenAsync(new Uri(link));
    }
}