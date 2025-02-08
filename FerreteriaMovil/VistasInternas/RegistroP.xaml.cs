using FerreteriaMovil.Models;
using System.Collections.Generic;

namespace FerreteriaMovil.VistasInternas;

public partial class RegistroP : ContentPage
{
    
    public RegistroP()
    {
        InitializeComponent();
    }

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        Guardar();
    }

    private async void Guardar()
    {
        
    }

    private async void Cancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
