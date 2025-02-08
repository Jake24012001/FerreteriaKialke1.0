using FerreteriaMovil.Models;
using FerreteriaMovil.VistasInternas.Menues;
using Microsoft.Maui.Controls;

namespace FerreteriaMovil.VistasInternas
{
    public partial class AdministradorPage : ContentPage
    {
        public AdministradorPage()
        {
            InitializeComponent();
        }
        private async void MenuUsuarios(object sender, EventArgs e)
        {
            await DisplayAlert("Gesti�n de Productos", "Navegando a la secci�n Menu Usuarios.", "OK");
            // Navegar a la p�gina de a�adir producto
             await Navigation.PushAsync(new Menues.UsuariosPage());
        }

        private async void MenuProductos(object sender, EventArgs e)
        {
            await DisplayAlert("Gesti�n de Productos", "Navegando a la secci�n Menu Productos.", "OK");
            // Navegar a la p�gina de a�adir producto
            await Navigation.PushAsync(new Menues.ProductosPage());
        }

        private async void MenuProveedores(object sender, EventArgs e)
        {
            await DisplayAlert("Gesti�n de Productos", "Navegando a la secci�n Menu Proveedor.", "OK");
            // Navegar a la p�gina de a�adir producto
            await Navigation.PushAsync(new Menues.ProveedorPage());
        }

        private async void MenuOtras(object sender, EventArgs e)
        {
            await DisplayAlert("Gesti�n de Productos", "Navegando a la secci�n Menu Otro.", "OK");
            // Navegar a la p�gina de a�adir producto
            //await Navigation.PushAsync(new AnadirProveedorPage());
        }
    }
}
