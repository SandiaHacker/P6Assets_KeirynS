using P6Assets_KeirynS.ViewModels;
using P6Assets_KeirynS.Models;

namespace P6Assets_KeirynS.Views;

public partial class UseerSignUpPage : ContentPage
{
    //para poder comunicarnos con la base de datos debemos pasar las opciones 
    //por medio del ViewModel, que se carga de intermediar dichas opciones

    UserViewModel? vm;
	public UseerSignUpPage()
	{
		InitializeComponent();

        BindingContext = vm = new UserViewModel();

        //Y ahora llamamos a la funcion que se encarga de llenar el picker 
        //con los datos de los roles de usuario

        LoadUserRoles();
	}

    private async void LoadUserRoles()
    {
        CboxUserRole.ItemsSource = await vm.GetUserRolesAsync();
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}