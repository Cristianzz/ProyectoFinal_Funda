using Datos.Resource;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReposicion
    {
        public String Registrar(Reposicion reposicion)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Reposicion.Add(reposicion);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Desasignar(int ID_Pedido, int ID_Producto)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Encuentra la reposición con el menor ID_Reposicion que coincida con el ID_Pedido y ID_Producto
                    var reposicionTemp = context.Reposicion
                        .Where(r => r.ID_Pedido == ID_Pedido && r.ID_Producto == ID_Producto)
                        .OrderBy(r => r.ID_Reposicion)
                        .FirstOrDefault();

                    if (reposicionTemp != null)
                    {
                        context.Reposicion.Remove(reposicionTemp);
                        context.SaveChanges();
                        return "Eliminado correctamente";
                    }
                    else
                    {
                        return "No se encontró ninguna reposición con los criterios especificados";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
      
        public List<Reposicion> ListarTodo()
        {
            List<Reposicion> reposiciones = new List<Reposicion>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    reposiciones = context.Reposicion.ToList();
                }
                return reposiciones;
            }
            catch (Exception ex)
            {
                return reposiciones;
            }
        }
        public List<RCarroCompras> ListarTodoxPedido(int id_pedido)
        {
            List<RCarroCompras> rCarroCompras = new List<RCarroCompras>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    rCarroCompras = context.Reposicion
                        .Where(v => v.ID_Pedido == id_pedido)
                        .GroupBy(r => new { r.Producto, r.Pedido }) // Agrupa por nombre de producto
                        .Select(g => new RCarroCompras
                        {
                            ID_Producto = g.Key.Producto.ID_Producto,
                            NombreProducto = g.Key.Producto.Nombre,

                       
                            Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
                        })
                        .ToList();
                }
                return rCarroCompras;
            }
            catch (Exception ex)
            {
                return rCarroCompras;
            }
        }

        public string AsignarAlmacenXPedido(int id_pedido, int id_almacen)
        {
            List<Reposicion> reposicions = new List<Reposicion>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    reposicions = context.Reposicion
                        .Where(v => v.ID_Pedido == id_pedido)
                        //.Include(r => r.Almacen)
                        //.Include(r => r.Pedido)
                        //.Include(r => r.Producto)
                        .ToList();
                    reposicions.ForEach(v => v.ID_Almacen = id_almacen);
                    context.SaveChanges();
                }
                return "Correctamente Ingresado";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public String ModificarxEstado(Reposicion reposicion)
        {
            if(reposicion.Estado == "Defectuoso")
            {
                try
                {
                    using (var context = new DBEFEntities())
                    {
                        // Solución error en DatagriView
                        context.Configuration.LazyLoadingEnabled = false;

                        // Buscar las reposiciones que coincidan con ID_Pedido e ID_Producto
                        List<Reposicion> reposicionsTemp = context.Reposicion
                            .Where(v => v.ID_Pedido == reposicion.ID_Pedido && v.ID_Producto == reposicion.ID_Producto
                                    && v.Estado == "Bueno")
                            .ToList();

                        // Modificar el estado de la primera reposición encontrada
                        Reposicion reposicionAModificar = reposicionsTemp.FirstOrDefault();
                        if (reposicionAModificar != null)
                        {
                            reposicionAModificar.Estado = reposicion.Estado;
                            context.SaveChanges();
                        }
                    }
                    return "Correctamente Ingresado";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
            else
            {
                try
                {
                    using (var context = new DBEFEntities())
                    {
                        // Solución error en DatagriView
                        context.Configuration.LazyLoadingEnabled = false;

                        // Buscar las reposiciones que coincidan con ID_Pedido e ID_Producto
                        List<Reposicion> reposicionsTemp = context.Reposicion
                            .Where(v => v.ID_Pedido == reposicion.ID_Pedido && v.ID_Producto == reposicion.ID_Producto
                                    && v.Estado == "Defectuoso")
                            .ToList();

                        // Modificar el estado de la primera reposición encontrada
                        Reposicion reposicionAModificar = reposicionsTemp.FirstOrDefault();
                        if (reposicionAModificar != null)
                        {
                            reposicionAModificar.Estado = reposicion.Estado;
                            context.SaveChanges();
                        }
                    }
                    return "Correctamente Ingresado";
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
           
        }

        public List<RProductosAlmacen> ListarTodoxProductoxPedidoxEstado(int id_pedido)
        {
            List<RProductosAlmacen> rProductosAlmacens = new List<RProductosAlmacen>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    rProductosAlmacens = context.Reposicion
                        .Where(v => v.ID_Pedido == id_pedido)
                        .GroupBy(r => new { r.Producto, r.Pedido, r.Estado }) // Agrupa por nombre de producto
                        .Select(g => new RProductosAlmacen
                        {
                            ID_Producto = g.Key.Producto.ID_Producto,
                            NombreProducto = g.Key.Producto.Nombre,
                            Precio = g.Key.Producto.Precio,
                            Estado = g.Key.Estado,
                            Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
                        })
                        .ToList();
                }
                return rProductosAlmacens;
            }
            catch (Exception ex)
            {
                return rProductosAlmacens;
            }
        }


        public List<RAlmacen> ListartodoxAlmacenxEstado(int id_almacen, String estado)
        {
            List<RAlmacen> rProductosAlmacens = new List<RAlmacen>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    rProductosAlmacens = context.Reposicion
                        .Where(v => v.ID_Almacen == id_almacen && v.Estado == estado)
                        .GroupBy(r => new { r.Producto, r.Estado }) // Agrupa por nombre de producto
                        .Select(g => new RAlmacen
                        {
                            ID_Producto = g.Key.Producto.ID_Producto,
                            NombreProducto = g.Key.Producto.Nombre,
                            Precio = g.Key.Producto.Precio,
                            Estado = g.Key.Estado,
                            Proveedor = g.Key.Producto.Proveedor.Nombre,
                            Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
                        })
                        .ToList();
                }
                return rProductosAlmacens;
            }
            catch (Exception ex)
            {
                return rProductosAlmacens;
            }
        }
        public List<RAlmacen> ListartodoxAlmacenxEstadoxMINStock(int id_almacen, String estado, int cantidad)
        {

            List<RAlmacen> rProductosAlmacens = new List<RAlmacen>();

            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    var AuxrProductosAlmacens = context.Reposicion
                        .Where(v => v.ID_Almacen == id_almacen && v.Estado == estado)
                        .GroupBy(r => new { r.Producto, r.Estado }) // Agrupa por nombre de producto
                        .Select(g => new RAlmacen
                        {
                            ID_Producto = g.Key.Producto.ID_Producto,
                            NombreProducto = g.Key.Producto.Nombre,
                            Precio = g.Key.Producto.Precio,
                            Estado = g.Key.Estado,
                            Proveedor = g.Key.Producto.Proveedor.Nombre,
                            Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
                        })
                        .ToList();
                    rProductosAlmacens = AuxrProductosAlmacens
                        .Where(p => p.Cantidad <= cantidad)
                            .ToList();
                }
                return rProductosAlmacens;
            }
            catch (Exception ex)
            {
                return rProductosAlmacens;
            }
        }
        public List<RAlmacen> ListartodoxAlmacenxEstadoxMAXStock(int id_almacen, String estado, int cantidad)
        {
            
            List<RAlmacen> rProductosAlmacens = new List<RAlmacen>();
     
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    var AuxrProductosAlmacens = context.Reposicion
                        .Where(v => v.ID_Almacen == id_almacen && v.Estado == estado)
                        .GroupBy(r => new { r.Producto, r.Estado }) // Agrupa por nombre de producto
                        .Select(g => new RAlmacen
                        {
                            ID_Producto = g.Key.Producto.ID_Producto,
                            NombreProducto = g.Key.Producto.Nombre,
                            Precio = g.Key.Producto.Precio,
                            Estado = g.Key.Estado,
                            Proveedor = g.Key.Producto.Proveedor.Nombre,
                            Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
                        })
                        .ToList();
                    rProductosAlmacens = AuxrProductosAlmacens
                        .Where(p => p.Cantidad >= cantidad)
                            .ToList();
                }
                return rProductosAlmacens;
            }
            catch (Exception ex)
            {
                return rProductosAlmacens;
            }
        }
        //public List<RAlmacen> ListartodoxAlmacen(int id_almacen)
        //{
        //    List<RAlmacen> rProductosAlmacens = new List<RAlmacen>();
        //    try
        //    {
        //        using (var context = new DBEFEntities())
        //        {
        //            // Solución error en DatagriView
        //            context.Configuration.LazyLoadingEnabled = false;
        //            rProductosAlmacens = context.Reposicion
        //                .Where(v => v.ID_Almacen == id_almacen)
        //                .GroupBy(r => new { r.Producto,  r.Estado }) // Agrupa por nombre de producto
        //                .Select(g => new RAlmacen
        //                {
        //                    ID_Producto = g.Key.Producto.ID_Producto,
        //                    NombreProducto = g.Key.Producto.Nombre,
        //                    Precio = g.Key.Producto.Precio,
        //                    Estado = g.Key.Estado,
        //                    Proveedor = g.Key.Producto.Proveedor.Nombre,
        //                    Cantidad = g.Count() // Cuenta de cuántas veces aparece el producto
        //                })
        //                .ToList();
        //        }
        //        return rProductosAlmacens;
        //    }
        //    catch (Exception ex)
        //    {
        //        return rProductosAlmacens;
        //    }
        //}

        /////////////////////////////////////////////////////////////////
        //public List<Reposicion> AsignarAlmacenXPedido(int id_pedido, int id_almacen)
        //{
        //    List<Reposicion> reposicions = new List<Reposicion>();
        //    try
        //    {
        //        using (var context = new DBEFEntities())
        //        {
        //            // Solución error en DatagriView
        //            context.Configuration.LazyLoadingEnabled = false;
        //            reposicions = context.Reposicion
        //                .Where(v => v.ID_Pedido == id_pedido)
        //                //.Include(r => r.Almacen)
        //                //.Include(r => r.Pedido)
        //                //.Include(r => r.Producto)

        //                .ToList();
        //            reposicions.ForEach(v => v.ID_Almacen = id_almacen);
        //            context.SaveChanges();
        //        }
        //        return reposicions;
        //    }
        //    catch (Exception ex)
        //    {
        //        return reposicions;
        //    }
        //}

        //public String Eliminar(int ID_Reposicion)
        //{
        //    try
        //    {
        //        using (var context = new DBEFEntities())
        //        {
        //            Reposicion reposicionTemp = context.Reposicion.Find(ID_Reposicion);
        //            context.Reposicion.Remove(reposicionTemp);
        //            context.SaveChanges();
        //        }
        //        return "Eliminado correctamente";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
    }
}
