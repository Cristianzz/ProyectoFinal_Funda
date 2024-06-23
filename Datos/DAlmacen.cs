using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlmacen
    {
        public String Registrar(Almacen almacen)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Almacen.Add(almacen);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String Modificar(Almacen almacen)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Almacen almacenTemp = context.Almacen.Find(almacen.ID_Almacen);
                    almacenTemp.Nombre = almacen.Nombre;
                    almacenTemp.Direccion = almacen.Direccion;
                 
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public String Eliminar(int ID_Almacen)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Almacen almacenTemp = context.Almacen.Find(ID_Almacen);
                    context.Almacen.Remove(almacenTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Almacen> ListarTodo()
        {
            List<Almacen> almacenes = new List<Almacen>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    almacenes = context.Almacen.ToList();
                }
                return almacenes;
            }
            catch (Exception ex)
            {
                return almacenes;
            }
        }

    }
}
