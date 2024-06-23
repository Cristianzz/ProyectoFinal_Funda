using Datos;
using Datos.Resource;
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
    public partial class FormRegistroProductos : Form
    {
        private int id_proveedor;
        private NProducto nProducto = new NProducto();

        public FormRegistroProductos(int id_proveedor)
        {
            InitializeComponent();
            this.id_proveedor = id_proveedor;
            MostrarProductos(nProducto.ListarTodoxProveedor(id_proveedor));
        }
        private void MostrarProductos(List<Producto> productos)
        {
            DTGProducto.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                DTGProducto.DataSource = productos;
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecio.Text == "" || tbDescripcion.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int precio = 0;
            try
            {
                precio = int.Parse(tbPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campso correctamente");
                return;
            }

            Producto producto = new Producto() 
            {
                Nombre = tbNombre.Text,
                Precio = tbPrecio.Text,
                Descripcion = tbDescripcion.Text,
                Tipo = cbTipo.Text,
                // Setear el FK
                ID_Proveedor = id_proveedor
            };

            String mensaje = nProducto.Registrar(producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodoxProveedor(id_proveedor));
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecio.Text == "" || tbDescripcion.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validacion de selección
            if (DTGProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int productoID = int.Parse(DTGProducto.SelectedRows[0].Cells["ID_Producto"].Value.ToString());
            Producto producto = new Producto()
            {
                ID_Producto = productoID,
                Nombre = tbNombre.Text,
                Precio = tbPrecio.Text,
                Descripcion = tbDescripcion.Text,
                Tipo = cbTipo.Text,
                ID_Proveedor = id_proveedor
            };

            String mensaje = nProducto.Modificar(producto);
            MessageBox.Show(mensaje);


            MostrarProductos(nProducto.ListarTodo());
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DTGProducto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_producto = int.Parse(DTGProducto.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nProducto.Eliminar(id_producto);
            MessageBox.Show(mensaje);

            MostrarProductos(nProducto.ListarTodoxProveedor(id_proveedor));
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


    }
}
