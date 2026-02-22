using System.Threading.Tasks;

namespace MenagerLekow.MVVM.VIEW;

public partial class DodajElement : ContentPage
{
	public DodajElement()
	{
		InitializeComponent();
	}
    //Zwijanie Flyout'u przy przejsciu na tą stronę
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Shell.Current.FlyoutIsPresented = false;
    }
   

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
        ///cofniêcie do Ÿród³a stosu
        ///kolejna modyikacja
		//modyfikacja z gita
    }
    

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void DatePicker_DateSelected_1(object sender, DateChangedEventArgs e)
    {

    }
}
