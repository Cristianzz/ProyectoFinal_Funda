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
    public partial class FormRegistroAlmacen : Form
    {
        private NAlmacen nAlmacen = new NAlmacen();
        public FormRegistroAlmacen()
        {
            InitializeComponent();
            MostrarAlmacen(nAlmacen.ListarTodo());
        }
        private void MostrarAlmacen(List<Almacen> almacens)
        {
            DTGAlmacen.DataSource = null;
            if (almacens.Count == 0)
            {
                return;
            }
            else
            {
                DTGAlmacen.DataSource = almacens;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "" )
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Almacen almacen = new Almacen()
            {
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text
            };             

            String mensaje = nAlmacen.Registrar(almacen);
            MessageBox.Show(mensaje);

            MostrarAlmacen(nAlmacen.ListarTodo());
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbDireccion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validacion de selección
            if (DTGAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int almacenID = int.Parse(DTGAlmacen.SelectedRows[0].Cells["ID_Almacen"].Value.ToString());
            Almacen almacen = new Almacen()
            {
                ID_Almacen = almacenID,
                Nombre = tbNombre.Text,
                Direccion = tbDireccion.Text,
                
            };

            String mensaje = nAlmacen.Modificar(almacen);
            MessageBox.Show(mensaje);


            MostrarAlmacen(nAlmacen.ListarTodo());
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DTGAlmacen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Administrador");
                return;
            }

            int ID_Ingreso;
            if (!int.TryParse(DTGAlmacen.SelectedRows[0].Cells[0].Value.ToString(), out ID_Ingreso))
            {
                MessageBox.Show("El ID del Almacen seleccionado no es válido");
                return;
            }
            String mensaje = nAlmacen.Eliminar(ID_Ingreso);
            MessageBox.Show(mensaje);
            MostrarAlmacen(nAlmacen.ListarTodo());
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
