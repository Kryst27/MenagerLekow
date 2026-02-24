using MenagerLekow.INTERFACES;
using MenagerLekow.MVVM.MODEL;
using MenagerLekow.MVVM.VIEWMODEL;
using System.Threading.Tasks;

namespace MenagerLekow.MVVM.VIEW;

public partial class DodajElement : ContentPage
{
    DodajElementViewModel wm;
    private readonly IBazaDanych db;
	public DodajElement(DodajElementViewModel wm, IBazaDanych db)
    {
        this.wm = wm;
        this.db = db;
        InitializeComponent();
        BindingContext = wm;


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
    public async void dodaj()
    {
        Leki l = new Leki();
        l.nazwa = Nazwaleku.Text;
        l.ilosc = 22;
        l.datazakupu = DateTime.Now;
        l.datawaznosci = DateTime.Now;
        try
        {
            wm.DodajNowyElement(l);

        }
        catch (Exception)
        {

          await  DisplayAlertAsync("Nieoczekiwany błąd", "Wystąpił nieoczekiwany błąd", "cofnij");
        }
    }
    

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {

    }

    private void DatePicker_DateSelected_1(object sender, DateChangedEventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
     
        dodaj();
    }


    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        if (lekigrid2.IsVisible == true)
        {
            lekigrid2.IsVisible = false;
           await obraz.RotateTo(90, 500, Easing.Linear);
        }
        else
        {
            lekigrid2.IsVisible = true;
           await obraz.RotateTo(0, 500, Easing.Linear);

        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (lekigrid3.IsVisible == true)
        {
            lekigrid3.IsVisible = false;
            await obraz2.RotateTo(90, 500, Easing.Linear);
        }
        else
        {
            lekigrid3.IsVisible = true;
            await obraz2.RotateTo(0, 500, Easing.Linear);

        }
    }
}
