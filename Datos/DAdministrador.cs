using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAdministrador
    {
        public String Registrar(Administrador administrador)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    context.Administrador.Add(administrador);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Administrador administrador)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Administrador adminTemp = context.Administrador.Find(administrador.ID_Administrador);
                    adminTemp.Nombre = administrador.Nombre;
                    adminTemp.Apellido = administrador.Apellido;
                    adminTemp.Telefono = administrador.Telefono;
                    adminTemp.Sexo = administrador.Sexo;
                    adminTemp.Correo = administrador.Correo;
                    adminTemp.Usuario = administrador.Usuario;
                    adminTemp.Contrasena = administrador.Contrasena;
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

        public String Eliminar(int ID_Administrador)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    Administrador administradorTemp = context.Administrador.Find(ID_Administrador);
                    context.Administrador.Remove(administradorTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Administrador> ListarTodo()
        {
            List<Administrador> administradores = new List<Administrador>();
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    administradores = context.Administrador.ToList();
                }
                return administradores;
            }
            catch (Exception ex)
            {
                return administradores;
            }
        }

        ////////////////////////////////////////////////////


        public String IniciarSesion(string Usuario, string Contrasena)
        {
            try
            {
                using (var context = new DBEFEntities())
                {
                    // Buscar el administrador por usuario y contraseña
                    Administrador administradorTemp = context.Administrador.SingleOrDefault(a => a.Usuario == Usuario && a.Contrasena == Contrasena);
                    // Verificar si se encontró el administrador
                    if (administradorTemp != null)
                    {

                        Sesion.admin = administradorTemp;
                        return "Sesion Iniciada Correctamente";
                        
                    }
                    else
                    {
                        return "Usuario o contraseña incorrectos";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al iniciar sesión: {ex.Message}";
            }
        }

        

    }
}
