using GamersClub.Data;
using GamersClub.Model;
using SQLite;

namespace GamersClub.Pages;

public partial class HomePage : ContentPage
{

    private UserModel _usuario;
    public HomePage(UserModel usuario)
	{

		InitializeComponent();
        _usuario = usuario;

        lblUserName.Text = $"{_usuario.Name}";

    }

    private async void Button1_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Erro", "você ja esta na pagina", "OK");


    }

    private async void Button2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre(_usuario));


    }

    private async void Button3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Favorito(_usuario));


    }

    private async void Button4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Perfil(_usuario));


    }

    private async void gmAnother(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AnotherPage());
    } 
    private async void gmHollow(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HollowPage());
    }

    private async void gmCS(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new csPage());
    } 
    private async void gmDead(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new deadPage());
    }

}