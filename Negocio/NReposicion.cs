using Datos;
using Datos.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReposicion
    {
        private DReposicion dReposicion = new DReposicion();

        public String Registrar(Reposicion reposicion)
        {
            return dReposicion.Registrar(reposicion);
        }

        //public String Modificar(Reposicion reposicion)
        //{
        //    return dReposicion.Modificar(reposicion);
        //}

        public String Eliminar(int ID_Pedido, int ID_Producto)
        {
            return dReposicion.Desasignar(ID_Pedido, ID_Producto);
        }

        public List<Reposicion> ListarTodo()
        {
            return dReposicion.ListarTodo();
        }
        public List<RCarroCompras> ListarTodoxPedido(int id_pedido)
        {
            return dReposicion.ListarTodoxPedido(id_pedido);
        }
        //public List<Reposicion> AsignarAlmacenXPedido(int id_pedido, int id_almacen)
        //{
        //    return dReposicion.AsignarAlmacenXPedido(id_pedido, id_almacen);
        //}
        public String AsignarAlmacenXPedido(int id_pedido, int id_almacen)
        {
            return dReposicion.AsignarAlmacenXPedido(id_pedido, id_almacen);
        }
        public String ModificarxEstado(Reposicion reposicion)
        {
            return dReposicion.ModificarxEstado(reposicion);
        }
        public List<RProductosAlmacen> ListarTodoxProductoxPedidoxEstado(int id_pedido)
        {
            return dReposicion.ListarTodoxProductoxPedidoxEstado(id_pedido);
        }
        public List<RAlmacen> ListartodoxAlmacenxEstadoxMAXStock(int id_almacen, String estado, int cantidad)
        {
            return dReposicion.ListartodoxAlmacenxEstadoxMAXStock(id_almacen, estado , cantidad);
        }
        public List<RAlmacen> ListartodoxAlmacenxEstadoxMINStock(int id_almacen, String estado, int cantidad)
        {
            return dReposicion.ListartodoxAlmacenxEstadoxMINStock(id_almacen, estado, cantidad);
        }
        public List<RAlmacen> ListartodoxAlmacenxEstado(int id_almacen, String estado)
        {
            return dReposicion.ListartodoxAlmacenxEstado(id_almacen, estado);
        }
    }
}
