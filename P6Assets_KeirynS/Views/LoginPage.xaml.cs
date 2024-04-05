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

    private void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        
    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UseerSignUpPage());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}