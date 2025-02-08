using System.Collections.ObjectModel;

namespace FerreteriaMovil.VistasInternas.Vistasclientes;

public partial class VistaCarrito : ContentPage
{
    public VistaCarrito()
    {
        InitializeComponent();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCarrito());
    }

    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCarrito());
    }

    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCarrito());
    }

    private async void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCarrito());
    }
}