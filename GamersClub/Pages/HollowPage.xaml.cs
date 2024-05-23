namespace GamersClub.Pages;

public partial class HollowPage : ContentPage
{
	public HollowPage()
	{
		InitializeComponent();
	}

    private async void btnOpenSteanAnother_Clicked(object sender, EventArgs e)
    {
        // Link que voc� deseja abrir
        string link = "https://store.steampowered.com/app/367520/Hollow_Knight/?l=brazilian";

        // Abre o link no navegador padr�o do dispositivo
        Launcher.OpenAsync(new Uri(link));
    }

}