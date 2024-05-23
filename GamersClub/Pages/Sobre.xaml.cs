using GamersClub.Model;

namespace GamersClub.Pages;

public partial class Sobre : ContentPage
{
    private UserModel _usuario;
    public Sobre(UserModel usuario)
    {
        InitializeComponent();
        _usuario = usuario;

    }

    private async void Button1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));


    }

    private async void Button2_Clicked(object sender, EventArgs e)
    {

        await DisplayAlert("Erro", "você ja esta na pagina", "OK");

    }

    private async void Button3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Favorito(_usuario));


    }

    private async void Button4_Clicked(object sender, EventArgs e)
    {

        
        await Navigation.PushAsync(new Perfil(_usuario));

    }
}