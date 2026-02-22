using System.Threading.Tasks;

namespace MenagerLekow.MVVM.VIEW;

public partial class DodajElement : ContentPage
{
	public DodajElement()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Shell.Current.FlyoutIsPresented = false;
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Shell.Current.FlyoutIsPresented = false;


    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        ///cofniêcie do Ÿród³a stosu
        ///kolejna modyikacja
    }
}