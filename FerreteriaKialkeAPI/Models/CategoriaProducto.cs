﻿namespace FerreteriaKialkeAPI.Models
{
    public class CategoriaProducto
    {
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public CategoriaProducto(int id_Categoria, string nombre, string descripcion)
        {
            Id_Categoria = id_Categoria;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
