using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProveedor
    {
        public String Registrar(Proveedor proveedor)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Proveedor.Add(proveedor);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Proveedor proveedor)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Proveedor provTemp = context.Proveedor.Find(proveedor.ID_Proveedor);
                    provTemp.Nombre = proveedor.Nombre;
                    provTemp.Direccion = proveedor.Direccion;
                    provTemp.Telefono = proveedor.Telefono;
                    provTemp.Correo = proveedor.Correo;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int ID_Proveedor)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Proveedor proveedorTemp = context.Proveedor.Find(ID_Proveedor);
                    context.Proveedor.Remove(proveedorTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Proveedor> ListarTodo()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    proveedores = context.Proveedor.ToList();
                }
                return proveedores;
            }
            catch (Exception ex)
            {
                return proveedores;
            }
        }
    }
}
