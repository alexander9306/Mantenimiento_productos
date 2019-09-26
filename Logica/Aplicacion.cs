using System;
using System.Collections;

namespace Logica
{
    public class Aplicacion
    {
        private ArrayList listProductos = new ArrayList();
        public void CrearProducto(string codigo, string nombre, string detalle, string costo, string precio,
             DateTime fechaVec, string categoria, bool estado)
        {
            var p = new Producto();
            DateTime fechaCrea = DateTime.Today;
            try
            {
                p.codigo = codigo;
                p.nombre = nombre;
                p.detalle = detalle;
                p.costo = costo;
                p.precio = precio;
                p.fechaCrea = fechaCrea;
                p.fechaVec = fechaVec;
                p.categoria = categoria;
                p.estado = estado;

                listProductos.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public Producto GetProducto(int id)
        {
            return (Producto)listProductos[id];
        }

        public int GetArrayCount()
        {
            return listProductos.Count;
        }

        public void EliminarProducto(int id)
        {
            listProductos.RemoveAt(id);
        }
    }
}
