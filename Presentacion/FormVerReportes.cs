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
    public partial class FormVerReportes : Form
    {
        String entregado = "Entregado";
        private NPedido nPedido = new NPedido();
        private NAlmacen nAlmacen = new NAlmacen();
        private NReposicion nReposicion = new NReposicion();
        private NProveedor nProveedor = new NProveedor();
        public FormVerReportes()
        {
            InitializeComponent();
            MostrarAlmacen(nAlmacen.ListarTodo());
        }

        private void MostrarAlmacen(List<Almacen> almacens)
        {
            cbAlmacen.DataSource = null;
            if (almacens.Count == 0)
            {
                return;
            }
            else
            {
                cbAlmacen.DataSource = almacens;
                cbAlmacen.ValueMember = "ID_Almacen";
                cbAlmacen.DisplayMember = "Nombre";
            }
        }
        private void MostrarPedido(List<Pedido> pedidos)
        {
            DTGReportes.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                DTGReportes.DataSource = pedidos;
            }
        }
        private void MostrarReposicion(List<RAlmacen> rProductosAlmacens)
        {
            DTGReportes.DataSource = null;
            if (rProductosAlmacens.Count == 0)
            {
                return;
            }
            else
            {
                DTGReportes.DataSource = rProductosAlmacens;
            }
        }

        private void btPedidosEntr_Click(object sender, EventArgs e)
        {
           
            MostrarPedido(nPedido.ListarTodoxEstado(entregado));
        }

        private void btProduc_Click(object sender, EventArgs e)
        {
            if (cbAlmacen.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int id_almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            String estado = "Bueno";
            MostrarReposicion(nReposicion.ListartodoxAlmacenxEstado(id_almacen, estado));
        }

        private void btDefec_Click(object sender, EventArgs e)
        {
            if (cbAlmacen.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int id_almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            String estado = "Defectuoso";
            MostrarReposicion(nReposicion.ListartodoxAlmacenxEstado(id_almacen, estado));
        }

        private void btMinStock_Click(object sender, EventArgs e)
        {
            if (cbAlmacen.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int id_almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            String estado = "Bueno";
            int cant = int.Parse(tbCantidad.Text);
            MostrarReposicion(nReposicion.ListartodoxAlmacenxEstadoxMINStock(id_almacen, estado, cant));
        }

        private void btMaxStock_Click(object sender, EventArgs e)
        {
            if (cbAlmacen.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            int id_almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            String estado = "Bueno";
            int cant = int.Parse(tbCantidad.Text);
            MostrarReposicion(nReposicion.ListartodoxAlmacenxEstadoxMAXStock(id_almacen, estado, cant));
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
