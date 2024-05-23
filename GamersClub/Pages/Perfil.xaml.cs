using GamersClub.Model;

namespace GamersClub.Pages;

public partial class Perfil : ContentPage
{
    private UserModel _usuario;
    public Perfil(UserModel usuario)
	{
		InitializeComponent();
        _usuario = usuario;

        lblName.Text = $"{_usuario.Name} ";
        lblEmail.Text = $"{_usuario.Email} ";
        lblPassword.Text = $"{_usuario.Password} ";

        fotoPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var stream = await file.OpenReadAsync();

                    // Converta a imagem para um stream de bytes
                    byte[] imageData;
                    using (var memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        imageData = memoryStream.ToArray();
                    }

                    // Crie uma ImageSource a partir do stream de bytes
                    ImageSource imageSource = ImageSource.FromStream(() => new MemoryStream(imageData));

                    // Defina a fonte da imagem
                    fotoPerfil.Source = imageSource;
                }
            }
        };
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
        await Navigation.PushAsync(new Favorito(_usuario));


    }

    private async void Button4_Clicked(object sender, EventArgs e)
    {

        await DisplayAlert("Erro", "você ja esta na pagina", "OK");


    }

    private async void Btnsair_Clicked(object sender, EventArgs e)
    {
        App.user = null;
        await Navigation.PopToRootAsync();
    }
}