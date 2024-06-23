using Datos;
using Datos.Resource;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrarIngreso : Form
    {
        private int id_pedido;
        String entregado = "Entregado";
        private NPedido nPedido = new NPedido();
        private NAlmacen nAlmacen = new NAlmacen();
        private NReposicion nReposicion = new NReposicion();
       
        public FormRegistrarIngreso(int id_pedido)
        {
            InitializeComponent();
            this.id_pedido = id_pedido;
            MostrarAlmacen(nAlmacen.ListarTodo());
            // MostrarPedidos(nPedido.ListarTodoxEstado(entregado));
            MostrarReposicion(nReposicion.ListarTodoxProductoxPedidoxEstado(id_pedido));
        }
        ///////////////////////////////////Mostrar///////////////////////////////////
        private void MostrarReposicion(List<RProductosAlmacen> rProductosAlmacens)
        {
            DTGIngreso.DataSource = null;
            if (rProductosAlmacens.Count == 0)
            {
                return;
            }
            else
            {
                DTGIngreso.DataSource = rProductosAlmacens;
            }
        }
        private void MostrarPedidos(List<Pedido> pedidos)
        {
            DTGIngreso.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                DTGIngreso.DataSource = pedidos;
            }
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
        ///////////////////////////////////Mostrar///////////////////////////////////
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            

            if (tbFecha_Entrega.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;


            }
            if (cbAlmacen.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

           
            /////////////////////////////////////////////////////////////////////
            // int ID_Pedido = int.Parse(DTGIngreso.SelectedRows[0].Cells[0].Value.ToString());
           

            Pedido pedido = new Pedido()
            {
                ID_Pedido = id_pedido,
                Estado = "Entregado",
                Fecha_Entrega = tbFecha_Entrega.Text,
              

            };

            nPedido.Modificar(pedido);
            //MessageBox.Show(mensaje);

           
            ///////////////////////////////////////////////////////////////////
            int ID_Almacen = int.Parse(cbAlmacen.SelectedValue.ToString());
            Reposicion reposicion = new Reposicion()
            {
                ID_Pedido = id_pedido,

                ID_Almacen = ID_Almacen


            };

            String mensaje = nReposicion.AsignarAlmacenXPedido(id_pedido, ID_Almacen);
            MessageBox.Show(mensaje);

            
        }
        private void btAsignarMal_Click(object sender, EventArgs e)
        {
            if (DTGIngreso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }
            int id_producto = int.Parse(DTGIngreso.SelectedRows[0].Cells[0].Value.ToString());
            Reposicion resposicion = new Reposicion()
            {
                ID_Pedido = id_pedido,
                ID_Producto = id_producto,
                Estado = "Defectuoso",

            };
            String mensaje = nReposicion.ModificarxEstado(resposicion);
            MessageBox.Show(mensaje);
            MostrarReposicion(nReposicion.ListarTodoxProductoxPedidoxEstado(id_pedido));
        }
        private void btProductoBueno_Click(object sender, EventArgs e)
        {
            if (DTGIngreso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }
            int id_producto = int.Parse(DTGIngreso.SelectedRows[0].Cells[0].Value.ToString());
            Reposicion resposicion = new Reposicion()
            {
                ID_Pedido = id_pedido,
                ID_Producto = id_producto,
                Estado = "Bueno",

            };
            String mensaje = nReposicion.ModificarxEstado(resposicion);
            MessageBox.Show(mensaje);
            MostrarReposicion(nReposicion.ListarTodoxProductoxPedidoxEstado(id_pedido));
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido()
            {
                ID_Pedido = id_pedido,
                Estado = "Pendiente",
                
            };

            nPedido.Modificar(pedido);

            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
