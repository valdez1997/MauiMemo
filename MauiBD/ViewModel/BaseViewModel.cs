

using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiBD.ViewModel;

public partial class BaseViewModel:ObservableObject
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    [ObservableProperty]
    string authName;

    public bool IsNotBusy => !IsBusy;

    [ObservableProperty]
    string title;

   

}
