//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reposicion
    {
        public int ID_Reposicion { get; set; }
        public string Estado { get; set; }
        public Nullable<int> ID_Pedido { get; set; }
        public Nullable<int> ID_Producto { get; set; }
        public Nullable<int> ID_Almacen { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
