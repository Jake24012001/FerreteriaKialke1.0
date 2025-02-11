using FerreteriaKialke.VSecundary;

namespace FerreteriaKialke
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BotonIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VistaTienda());
        }
    }

}
