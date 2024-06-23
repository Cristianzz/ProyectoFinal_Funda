using Datos.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProducto
    {
        public String Registrar(Producto producto)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Producto producto)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Producto prodTemp = context.Producto.Find(producto.ID_Producto);
                    prodTemp.Nombre = producto.Nombre;
                    prodTemp.Descripcion = producto.Descripcion;
                    prodTemp.Precio = producto.Precio;
                    prodTemp.Tipo = producto.Tipo;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Eliminar(int ID_Producto)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Producto productoTemp = context.Producto.Find(ID_Producto);
                    context.Producto.Remove(productoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //public List<Videojuego> ListarTodo(int id_desarrollador)
        //{
        //    List<Videojuego> videojuegos = new List<Videojuego>();
        //    try
        //    {
        //        using (var context = new BDEFEntities())
        //        {
        //            // Solución error en DatagriView
        //            context.Configuration.LazyLoadingEnabled = false;
        //            videojuegos = context.Videojuego.Where(v => v.Id_Desarrollador == id_desarrollador).ToList();
        //        }
        //        return videojuegos;
        //    }
        //    catch (Exception ex)
        //    {
        //        return videojuegos;
        //    }
        //}

        public List<Producto> ListarTodo()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
        }

        public List<Producto> ListarTodoxProveedor(int id_proveedor)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(v => v.ID_Proveedor == id_proveedor).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }
            
        }
        public List<Producto> ListarTodoxTipo(String tipo)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(v => v.Tipo == tipo).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }

        }
        public List<Producto> ListarTodoxNombre(String nombre)
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    productos = context.Producto.Where(v => v.Nombre == nombre).ToList();
                }
                return productos;
            }
            catch (Exception ex)
            {
                return productos;
            }

        }

    }
}
