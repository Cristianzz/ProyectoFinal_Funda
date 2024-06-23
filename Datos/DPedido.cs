using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPedido
    {
        public String Registrar(Pedido pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Pedido.Add(pedido);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int ID_Pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(ID_Pedido);
                    context.Pedido.Remove(pedidoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Pedido pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(pedido.ID_Pedido);
                    pedidoTemp.Estado = pedido.Estado;
                    pedidoTemp.Fecha_Entrega = pedido.Fecha_Entrega;
                
                    context.SaveChanges();
                }
                return "Ingresado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String ModificarEstado(Pedido pedido)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Pedido pedidoTemp = context.Pedido.Find(pedido.ID_Pedido);
                    pedidoTemp.Estado = pedido.Estado;


                    context.SaveChanges();
                }
                return "Pedido Realizado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Pedido> ListarTodo()
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    pedidos = context.Pedido.ToList();
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                return pedidos;
            }
        }
        public List<Pedido> ListarTodoxEstado(String estado)
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    pedidos = context.Pedido.Where(v => v.Estado == estado).ToList();
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                return pedidos;
            }

        }
       
    }
}
