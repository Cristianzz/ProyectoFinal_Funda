using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlmacen
    {
        private DAlmacen dAlmacen = new DAlmacen();

        public String Registrar(Almacen almacen)
        {
            return dAlmacen.Registrar(almacen);
        }

        public String Modificar(Almacen almacen)
        {
            return dAlmacen.Modificar(almacen);
        }

        public String Eliminar(int ID_Almacen)
        {
            return dAlmacen.Eliminar(ID_Almacen);
        }

        public List<Almacen> ListarTodo()
        {
            return dAlmacen.ListarTodo();
        }
    }
}
