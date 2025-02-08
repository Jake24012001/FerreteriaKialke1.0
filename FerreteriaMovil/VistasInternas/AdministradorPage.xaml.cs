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
            await DisplayAlert("Gestión de Productos", "Navegando a la sección Menu Usuarios.", "OK");
            // Navegar a la página de añadir producto
             await Navigation.PushAsync(new Menues.UsuariosPage());
        }

        private async void MenuProductos(object sender, EventArgs e)
        {
            await DisplayAlert("Gestión de Productos", "Navegando a la sección Menu Productos.", "OK");
            // Navegar a la página de añadir producto
            await Navigation.PushAsync(new Menues.ProductosPage());
        }

        private async void MenuProveedores(object sender, EventArgs e)
        {
            await DisplayAlert("Gestión de Productos", "Navegando a la sección Menu Proveedor.", "OK");
            // Navegar a la página de añadir producto
            await Navigation.PushAsync(new Menues.ProveedorPage());
        }

        private async void MenuOtras(object sender, EventArgs e)
        {
            await DisplayAlert("Gestión de Productos", "Navegando a la sección Menu Otro.", "OK");
            // Navegar a la página de añadir producto
            //await Navigation.PushAsync(new AnadirProveedorPage());
        }
    }
}
