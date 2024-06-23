using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Resource
{
    public class RProductosAlmacen
    {
        public int ID_Producto { get; set; }
        public String NombreProducto { get; set; }
        public String Precio { get; set; }

        public String Estado { get; set; }
        public int Cantidad { get; set; }
    }
}
