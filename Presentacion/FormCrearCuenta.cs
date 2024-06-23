using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCrearCuenta : Form
    {

        private NAdministrador nAdministrador = new NAdministrador();

        public FormCrearCuenta()
        {
            InitializeComponent();
            MostrarAdministradores(nAdministrador.ListarTodo());
        }

        private void MostrarAdministradores(List<Administrador> administradors)
        {
            DTGAdministrador.DataSource = null;
            if (administradors.Count == 0)
            {
                return;
            }
            else
            {
                DTGAdministrador.DataSource = administradors;
            }
        }


        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbTelefono.Text == "" || cbSexo.Text == "" || tbCorreo.Text == "" || tbNombre.Text == "" || tbContrasena.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Administrador administrador = new Administrador()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Telefono = tbTelefono.Text,
                Sexo = cbSexo.Text,
                Correo = tbCorreo.Text,
                Usuario = tbUsuario.Text,
                Contrasena = tbContrasena.Text
            };

            String mensaje = nAdministrador.Registrar(administrador);
            MessageBox.Show(mensaje);

            MostrarAdministradores(nAdministrador.ListarTodo());
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbTelefono.Text == "" || cbSexo.Text == "" || tbCorreo.Text == "" || tbNombre.Text == "" || tbContrasena.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación entrada numérica
            int Telefono = 0;
            try
            {
                Telefono = int.Parse(tbTelefono.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese los campos correctamente");
                return;
            }

            // Validacion de selección
            if (DTGAdministrador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int adminID = int.Parse(DTGAdministrador.SelectedRows[0].Cells["ID_Administrador"].Value.ToString());
            Administrador administrador = new Administrador()
            {
                ID_Administrador = adminID,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Telefono = tbTelefono.Text,
                Sexo = cbSexo.Text,
                Correo = tbCorreo.Text,
                Usuario = tbUsuario.Text,
                Contrasena = tbContrasena.Text
            };

            String mensaje = nAdministrador.Modificar(administrador);
            MessageBox.Show(mensaje);

            
            MostrarAdministradores(nAdministrador.ListarTodo());
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DTGAdministrador.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Administrador");
                return;
            }

            int ID_Administrador;
            if (!int.TryParse(DTGAdministrador.SelectedRows[0].Cells[0].Value.ToString(), out ID_Administrador))
            {
                MessageBox.Show("El ID del Usuario seleccionado no es válido");
                return;
            }
            String mensaje = nAdministrador.Eliminar(ID_Administrador);
            MessageBox.Show(mensaje);
            MostrarAdministradores(nAdministrador.ListarTodo());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
