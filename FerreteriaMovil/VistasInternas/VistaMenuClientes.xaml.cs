using CapaLogica.Gestion;
using System.Collections.ObjectModel;

namespace FerreteriaMovil.VistasInternas;

public partial class VistaMenuClientes : ContentPage
{
    
        public ObservableCollection<CapaEntidades.Gestion.Producto> Productos { get; set; }
    public VistaMenuClientes()
    {
        InitializeComponent();

        //var productos = new List<Producto>
        //{
        //    new Producto { Imagen = "martillo.png", Nombre = "Martillo", Descripcion = "Martillo de acero", Precio = "$10.00" },
        //    new Producto { Imagen = "taladro.png", Nombre = "Taladro", Descripcion = "Taladro el�ctrico", Precio = "$50.00" },
        //    new Producto { Imagen = "https://bpecuador.com/wp-content/uploads/2024/03/palan-puntona-mango-plastico-1.png", Nombre = "Pala", Descripcion = "Palitas", Precio = "$00.00" },
        //    // A�ade m�s productos aqu�
        //};

        ProductosCollectionView.ItemsSource = ProductoLN.filtrarVistaProductosLN("");
    }


    private async  void AgregarCarritoButton(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Alerta", "�Desea agregar el producto al carrito?", "S�", "No");
        if (answer)
        {
            // El usuario seleccion� "S�"
            // Aqu� puedes agregar el c�digo para agregar el producto al carrito
            bool confirmacion = await DisplayAlert("Alerta", "Usted ha elegido este producto para comprarlo", "Seguir comprando", "Finalizar compra");
            if (confirmacion)
            {
                //El usuario continuo comprando
            }
            else
            {
                //El usuario Finalizo Compra
                await Navigation.PushAsync(new Vistasclientes.VistaCarrito());
            }
        }
        else
        {
            // El usuario seleccion� "No"
            // Aqu� puedes agregar el c�digo para manejar la respuesta negativa
            await DisplayAlert("", "Suerte la proxima vez", "OK");
        }
    }

    //codigo que permite bloquear la opcion de retroceder
    protected override bool OnBackButtonPressed()
    {
        // No permitir navegar hacia atr�s
        return true;

    }

    private async void VistaUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Vistasclientes.VistaUsuario());
    }

    private async void VistaCategoria_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Vistasclientes.VistaCategoria());
    }

    private async void VistaProductos_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VistaMenuClientes());
    }

    private async void VistaFactura_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Vistasclientes.VistaFactura());
    }
}