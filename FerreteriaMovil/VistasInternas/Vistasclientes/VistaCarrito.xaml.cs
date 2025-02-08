using System.Collections.ObjectModel;

namespace FerreteriaMovil.VistasInternas.Vistasclientes;

public partial class VistaCarrito : ContentPage
{
    public VistaCarrito()
    {
        InitializeComponent();
    }

    private async void CarritoVista_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCarrito());
    }

    private async void UsarioVista_Clicked(object sender, EventArgs e)
    {
       // await Navigation.PushAsync(new VistaCarrito());
    }

    private async void CategoriaVista_Clicked(object sender, EventArgs e)
    {
       // await Navigation.PushAsync(new ViewCategoria());
    }

    private async void FacturaVista_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new VistaCarrito());
    }
}