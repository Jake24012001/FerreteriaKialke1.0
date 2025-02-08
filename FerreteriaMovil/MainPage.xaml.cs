namespace FerreteriaMovil
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BotonIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VistasInternas.LoginP());

        }
    }

}
