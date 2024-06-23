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
    public partial class FormMenu : Form
    {
        String pendiente = "Pendiente";
        private NPedido nPedido = new NPedido();
        public FormMenu()
        {
            InitializeComponent();

            lbNombre.Text = Sesion.admin.Nombre + " " + Sesion.admin.Apellido;
            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
            //MostrarPedido(nPedido.ListarTodo());
        }
        private void MostrarPedido(List<Pedido> pedidos)
        {
            DTGMenu.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                DTGMenu.DataSource = pedidos;
            }
        }
        private void btAlmacen_Click(object sender, EventArgs e)
        {
            FormRegistroAlmacen form = new FormRegistroAlmacen();
            form.Show();
        }

        private void btProveedores_Click(object sender, EventArgs e)
        {
            FormRegistroProveedor form = new FormRegistroProveedor();
            form.Show();
        }

        private void btPedidos_Click(object sender, EventArgs e)
        {
            FormRegistroPedido form = new FormRegistroPedido();
            form.Show();
        }
        private void btIngreso_Click(object sender, EventArgs e)
        {
            if (DTGMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el pedido");
                return;
            }
            int ID_Pedido = int.Parse(DTGMenu.SelectedRows[0].Cells[0].Value.ToString());
            Pedido pedido = new Pedido()
            {
                ID_Pedido = ID_Pedido,
                Estado = "Entregado",
              
            };

            nPedido.Modificar(pedido);

            FormRegistrarIngreso form = new FormRegistrarIngreso(ID_Pedido);
            form.Show();
        }
        private void Reportes_Click(object sender, EventArgs e)
        {
            FormVerReportes form = new FormVerReportes();
            form.Show();
        }
        private void btRecarga_Click(object sender, EventArgs e)
        {
            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
            //MostrarPedido(nPedido.ListarTodo());
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            FormInicioSesion form = new FormInicioSesion();
            form.Show();
            this.Close();
        }

        


    }
}
