

using MauiBD.ViewModel;
using Microsoft.Win32.SafeHandles;

namespace MauiBD.Constants;

public static  class Constant
{
    public const string AUTH_TOKEN_KEY = "Auth_Token";
    public const string AUTH_NAME_KEY = "Auth_name";
    public static string AuthToken
    {
        
       get => Preferences.Get(Constants.Constant.AUTH_TOKEN_KEY, string.Empty);
        set => Preferences.Set(Constants.Constant.AUTH_TOKEN_KEY, value);
    }
    public static string AuthName
    {

        get => Preferences.Get(Constants.Constant.AUTH_NAME_KEY, string.Empty);
        set => Preferences.Set(Constants.Constant.AUTH_NAME_KEY, value);
    }
}
