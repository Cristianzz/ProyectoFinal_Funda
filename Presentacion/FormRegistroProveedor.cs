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
    public partial class FormRegistroProveedor : Form
    {
        private NProveedor nProveedor = new NProveedor();
        public FormRegistroProveedor()
        {
            InitializeComponent();
            MostrarProveedores(nProveedor.ListarTodo());
        }
        private void MostrarProveedores(List<Proveedor> proveedors)
        {
            DTGProveedor.DataSource = null;
            if (proveedors.Count == 0)
            {
                return;
            }
            else
            {
                DTGProveedor.DataSource = proveedors;
            }
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "" || tbCorreo.Text == "" )
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Proveedor proveedor = new Proveedor() 
            {
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Telefono = tbTelefono.Text,
                Correo = tbCorreo.Text
                
            };

            String mensaje = nProveedor.Registrar(proveedor);
            MessageBox.Show(mensaje);

            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbTelefono.Text == "" || tbCorreo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

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
            if (DTGProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int proveedorID = int.Parse(DTGProveedor.SelectedRows[0].Cells["ID_Proveedor"].Value.ToString());
            Proveedor proveedor = new Proveedor()
            {
                ID_Proveedor = proveedorID,
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text,
                Telefono = tbTelefono.Text,
                Correo = tbCorreo.Text
            };

            String mensaje = nProveedor.Modificar(proveedor);
            MessageBox.Show(mensaje);


            MostrarProveedores(nProveedor.ListarTodo());

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DTGProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Administrador");
                return;
            }

            int ID_Administrador;
            if (!int.TryParse(DTGProveedor.SelectedRows[0].Cells[0].Value.ToString(), out ID_Administrador))
            {
                MessageBox.Show("El ID del Proveedor seleccionado no es válido");
                return;
            }
            String mensaje = nProveedor.Eliminar(ID_Administrador);
            MessageBox.Show(mensaje);
            MostrarProveedores(nProveedor.ListarTodo());
        }

        private void btProductos_Click(object sender, EventArgs e)
        {
            if (DTGProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Proveedor");
                return;
            }

            int id_proveedor = int.Parse(DTGProveedor.SelectedRows[0].Cells[0].Value.ToString());

            FormRegistroProductos form = new FormRegistroProductos(id_proveedor);
            form.Show();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
