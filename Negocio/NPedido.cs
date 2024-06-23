using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPedido
    {

        private DPedido dPedido = new DPedido();

        public String Registrar(Pedido pedido)
        {
            return dPedido.Registrar(pedido);
        }

        public String Modificar(Pedido pedido)
        {
            return dPedido.Modificar(pedido);
        }
        public String ModificarEstado(Pedido pedido)
        {
            return dPedido.ModificarEstado(pedido);
        }
        public String Eliminar(int ID_Pedido)
        {
            return dPedido.Eliminar(ID_Pedido);
        }

        public List<Pedido> ListarTodo()
        {
            return dPedido.ListarTodo();
        }
        public List<Pedido> ListarTodoxEstado(String estado)
        {
            return dPedido.ListarTodoxEstado(estado);
        }
    }
}
