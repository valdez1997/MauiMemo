namespace MauiBD.View;

public partial class CentreHospitalierPage : ContentPage
{
	public CentreHospitalierPage()
	{
		InitializeComponent();
	}
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Rdv2Page));
    }
}