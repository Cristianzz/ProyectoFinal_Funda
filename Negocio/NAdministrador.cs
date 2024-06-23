using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAdministrador
    {
        private DAdministrador dAdministrador = new DAdministrador();

        public String Registrar(Administrador administrador)
        {
            return dAdministrador.Registrar(administrador);
        }

        public String Modificar(Administrador administrador)
        {
            return dAdministrador.Modificar(administrador);
        }

        public String Eliminar(int ID_Administrador)
        {
            return dAdministrador.Eliminar(ID_Administrador);
        }

        public List<Administrador> ListarTodo()
        {
            return dAdministrador.ListarTodo();
        }


        public String IniciarSesion(string Usuario, string Contrasena)
        {
            return dAdministrador.IniciarSesion(Usuario, Contrasena);
        }
    }
}
