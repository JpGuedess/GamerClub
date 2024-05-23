using GamersClub.Model;

namespace GamersClub.Pages;

public partial class Favorito : ContentPage
{
    private UserModel _usuario;
    public Favorito(UserModel usuario)
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
        await Navigation.PushAsync(new Sobre(_usuario));


    }

    private async void Button3_Clicked(object sender, EventArgs e)
    {
        
        await DisplayAlert("Erro", "você ja esta na pagina", "OK");

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
}