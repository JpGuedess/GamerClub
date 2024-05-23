namespace GamersClub.Pages;

public partial class deadPage : ContentPage
{
	public deadPage()
	{
		InitializeComponent();
	}
    private async void btnOpenSteanAnother_Clicked(object sender, EventArgs e)
    {
        // Link que você deseja abrir
        string link = "https://store.steampowered.com/app/1693980/Dead_Space/?l=brazilian";

        // Abre o link no navegador padrão do dispositivo
        Launcher.OpenAsync(new Uri(link));
    }
}