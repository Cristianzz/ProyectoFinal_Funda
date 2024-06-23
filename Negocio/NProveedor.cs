using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProveedor
    {
        private DProveedor dProveedor = new DProveedor();

        public String Registrar(Proveedor proveedor)
        {
            return dProveedor.Registrar(proveedor);
        }

        public String Modificar(Proveedor proveedor)
        {
            return dProveedor.Modificar(proveedor);
        }

        public String Eliminar(int ID_Proveedor)
        {
            return dProveedor.Eliminar(ID_Proveedor);
        }

        public List<Proveedor> ListarTodo()
        {
            return dProveedor.ListarTodo();
        }
    }
}
