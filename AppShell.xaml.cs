using MenagerLekow.MVVM.VIEW;
using System.Threading.Tasks;

namespace MenagerLekow
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("Dodaj Lek", typeof(DodajElement));
            Routing.RegisterRoute("Glowna", typeof(StronaGlowna));

            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Dodaj Lek");
        }
    }
}
