﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        private DProducto dProducto = new DProducto();

        public String Registrar(Producto producto)
        {
            return dProducto.Registrar(producto);
        }

        public String Modificar(Producto producto)
        {
            return dProducto.Modificar(producto);
        }

        public String Eliminar(int ID_Producto)
        {
            return dProducto.Eliminar(ID_Producto);
        }
        public List<Producto> ListarTodo()
        {
            return dProducto.ListarTodo();
        }
        public List<Producto> ListarTodoxProveedor(int id_producto)
        {
            return dProducto.ListarTodoxProveedor(id_producto);
        }
        public List<Producto> ListarTodoxTipo(String tipo)
        {
            return dProducto.ListarTodoxTipo(tipo);
        }
        public List<Producto> ListarTodoxNombre(String nombre)
        {
            return dProducto.ListarTodoxNombre(nombre);
        }
    }
}
