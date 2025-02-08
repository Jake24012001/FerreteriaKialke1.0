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
        await Navigation.PushAsync(new VistaUsuario());
    }

    private async void CategoriaVista_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaCategoria());
    }

    private async void FacturaVista_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaFactura());
    }

    //codigo que permite bloquear la opcion de retroceder
    protected override bool OnBackButtonPressed()
    {
        // No permitir navegar hacia atrás
        return true;

    }
}