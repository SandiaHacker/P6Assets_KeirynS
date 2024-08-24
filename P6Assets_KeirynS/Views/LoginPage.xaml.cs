namespace P6Assets_KeirynS.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void SwVerPassword_Toggled(object sender, ToggledEventArgs e)
    {
        if (SwVerPassword.IsToggled)
        {
            TxtPassword.IsPassword = false;
        }
        else
        {
            TxtPassword.IsPassword = true;
        }
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        //TODO: agregar llamada el API para consultar el usuario por 
        //el correo y contraseña

        //si la respuesta es correcta entonces mostramos la pagina de
        //selección de opciones

        await Navigation.PushAsync(new LoginOptions());
    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UseerSignUpPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void BtnRecovery_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnRecovery_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RecoveryPassword());
    }
}