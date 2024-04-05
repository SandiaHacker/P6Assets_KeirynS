namespace P6Assets_KeirynS.Views;

public partial class UseerSignUpPage : ContentPage
{
	public UseerSignUpPage()
	{
		InitializeComponent();
	}

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}