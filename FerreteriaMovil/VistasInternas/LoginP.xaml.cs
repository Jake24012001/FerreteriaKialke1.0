using FerreteriaMovil.Models;
using Microsoft.Maui.Controls;

namespace FerreteriaMovil.VistasInternas
{
    public partial class LoginP : ContentPage
    {
        public LoginP()
        {
            InitializeComponent();
        }

        private async void Ingresar_Clicked(object sender, EventArgs e)
        {
            string correo = CorreoU.Text;
            string password = ContraU.Text;

            if (correo == null  && password == null)
            {   
                await DisplayAlert("atencion", "datos sin llenar", "OK");
            }
            else if(correo == "inge" && password == "123")
            {
                await Navigation.PushAsync(new VistaMenuClientes());
            }
        }

        private async void Registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroP());
        }

        private async void Administrador_Clicked(object sender, EventArgs e)
        {
            string correoadmin = CorreoU .Text;
            string contrasenaadmin = ContraU.Text;

            if (correoadmin == "kvargas4@utmachala.edu.ec" && contrasenaadmin == "5678")
            {
                // Redirigir a la página del administrador
                await Navigation.PushAsync(new AdministradorPage());
            }
            else
            {
                await DisplayAlert("Atención", "Credenciales de administrador incorrectas.", "OK");
            }
        }
    }
}
