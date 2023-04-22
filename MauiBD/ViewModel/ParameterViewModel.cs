

using CommunityToolkit.Mvvm.Input;
using MauiBD.Service;
using MauiBD.View;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class ParameterViewModel:BaseViewModel
{
    LogoutService logoutService;
    public ICommand LogoutCommand { get; private set; }
    public ParameterViewModel(LogoutService logoutService) 
    {
        this.logoutService = logoutService;
        LogoutCommand = new Command(Logout);
    }
    [RelayCommand]
    async void EditPassword()
    {
        //Shell.Current.Navigation.PushAsync(new View.EditPasswordPage());
        await Shell.Current.GoToAsync($"{nameof(EditPasswordPage)}");
    }

    public async void Logout()
    {
        var resultlogout = (await logoutService.logout(Constants.Constant.AuthToken)).Staus;
        if (resultlogout == "true")
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
            // Shell.Current.Navigation.PushAsync(new View.LoginPage());
          //  await Shell.Current.DisplayAlert("val", Constants.Constant.AuthToken, "ok");
        }
        else
        {
            await Shell.Current.DisplayAlert("Erreur", "Vous n'etes pas enregistré pour vouloir vous deconnecter", "OK");
        }
    }
}
