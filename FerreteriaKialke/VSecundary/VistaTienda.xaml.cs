using CapaLogica.Gestion;

namespace FerreteriaKialke.VSecundary;

public partial class VistaTienda : ContentPage
{
	public VistaTienda()
	{
		InitializeComponent();
        ProductosMoviles.ItemsSource = ProductoLN.listarVistaProductosLN();
    }

    private async void AgregarCarritoButton(object sender, EventArgs e)
    {
       
    }

    //codigo que permite bloquear la opcion de retroceder
    protected override bool OnBackButtonPressed()
    {
        // No permitir navegar hacia atrás
        return true;

    }

    private async void VistaUsuario_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Vistasclientes.VistaUsuario());
    }

    private async void VistaCategoria_Clicked_1(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Vistasclientes.VistaCategoria());
    }

    private async void VistaProductos_Clicked_2(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new VistaMenuClientes());
    }

    private async void VistaFactura_Clicked_3(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new Vistasclientes.VistaFactura());
    }
}