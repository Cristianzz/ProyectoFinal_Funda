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
    public partial class FormRegistroPedido : Form
    {
        String pendiente = "Sin Realizar";
        int ID_Pedido;
        private NPedido nPedido = new NPedido();
        private NProducto nProducto = new NProducto();
        private NReposicion nReposicion = new NReposicion();
        private NProveedor nProveedor = new NProveedor();
        public FormRegistroPedido()
        {
            InitializeComponent();
            MostrarProveedores(nProveedor.ListarTodo());
            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
            MostrarProducto(nProducto.ListarTodo());
            //MostrarReposicion(nReposicion.ListarTodo());
            //label6.Text = Sesion.admin.ID_Administrador.ToString();

        }
        /////////////////////////////////////Mostrar///////////////////////////////////
        private void MostrarProveedores(List<Proveedor> proveedors)
        {
            cbProveedor.DataSource = null;
            if (proveedors.Count == 0)
            {
                return;
            }
            else
            {
                cbProveedor.DataSource = proveedors;
                cbProveedor.ValueMember = "ID_Proveedor";
                cbProveedor.DisplayMember = "Nombre";
            }
        }

        private void MostrarPedido(List<Pedido> pedidos)
        {
            DTGPedido.DataSource = null;
            if (pedidos.Count == 0)
            {
                return;
            }
            else
            {
                DTGPedido.DataSource = pedidos;
            }
        }
        private void MostrarProducto(List<Producto> productos)
        {
            DTGProductos.DataSource = null;
            if (productos.Count == 0)
            {
                return;
            }
            else
            {
                DTGProductos.DataSource = productos;
            }
        }
        private void MostrarReposicion(List<RCarroCompras> rCarroCompras)
        {
            DTGCarro.DataSource = null;
            if (rCarroCompras.Count == 0)
            {
                return;
            }
            else
            {
                DTGCarro.DataSource = rCarroCompras;
            }
        }
        /////////////////////Botones/////////////////////////////////////
        private void btCrear_Click(object sender, EventArgs e)
        {



            Pedido pedido = new Pedido()
            {

                Fecha_Pedido = DateTime.Now,
                Estado = "Sin Realizar",
                ID_Administrador = Sesion.admin.ID_Administrador

            };

            String mensaje = nPedido.Registrar(pedido);
            MessageBox.Show(mensaje);

            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
            //////////////////////////////////////////


        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (DTGPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Pedido");
                return;
            }

            int id_pedido;
            if (!int.TryParse(DTGPedido.SelectedRows[0].Cells[0].Value.ToString(), out id_pedido))
            {
                MessageBox.Show("El ID del Pedido seleccionado no es válido");
                return;
            }
            String mensaje = nPedido.Eliminar(id_pedido);
            MessageBox.Show(mensaje);
            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
        }
        /////////////////////Producto/////////////////////////////////////
        private void btEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DTGCarro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Producto del Carrito de Compras");
                return;
            }

            //int id_pedido = int.Parse(DTGPedido.SelectedRows[0].Cells[0].Value.ToString());
            int id_producto = int.Parse(DTGCarro.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nReposicion.Eliminar(ID_Pedido, id_producto);
    

            MostrarReposicion(nReposicion.ListarTodoxPedido(ID_Pedido));
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (DTGPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Pedido");
                return;
            }
            if (DTGProductos.SelectedRows.Count == 0)
            {

                MessageBox.Show("Seleccione un Producto");
                return;
            }
            ID_Pedido = int.Parse(DTGPedido.SelectedRows[0].Cells[0].Value.ToString());
            int id_producto = int.Parse(DTGProductos.SelectedRows[0].Cells[0].Value.ToString());


            Reposicion reposicion = new Reposicion() 
            {
                ID_Pedido = ID_Pedido,
                ID_Producto = id_producto,
                Estado = "Bueno",
            };

            String mensaje = nReposicion.Registrar(reposicion);
         

            MostrarReposicion(nReposicion.ListarTodoxPedido(ID_Pedido));
        }
        private void btVerProducPedido_Click(object sender, EventArgs e)
        {
            if (DTGPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Pedido");
                return;
            }
            ID_Pedido = int.Parse(DTGPedido.SelectedRows[0].Cells[0].Value.ToString());
            MostrarReposicion(nReposicion.ListarTodoxPedido(ID_Pedido));
        }
        /////////////////////Filtro/////////////////////////////////////
        private void btBucarProveedor_Click(object sender, EventArgs e)
        {
            if (cbProveedor.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }

            int proveedor = int.Parse(cbProveedor.SelectedValue.ToString());

            MostrarProducto(nProducto.ListarTodoxProveedor(proveedor));
        }
        private void btBucarTipo_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }

            String tipo = cbTipo.Text;

            MostrarProducto(nProducto.ListarTodoxTipo(tipo));
        }
        private void btBucarNombre_Click(object sender, EventArgs e)
        {
            if (tbNombreP.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }

            String nombre = tbNombreP.Text;

            MostrarProducto(nProducto.ListarTodoxNombre(nombre));
        }
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            MostrarProducto(nProducto.ListarTodo());
        }
        private void btRealizarPedido_Click(object sender, EventArgs e)
        {
            if (DTGPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Pedido");
                return;
            }
            ID_Pedido = int.Parse(DTGPedido.SelectedRows[0].Cells[0].Value.ToString());
            Pedido pedido = new Pedido()
            {
                ID_Pedido = ID_Pedido,
                Estado = "Pendiente",

            };

            nPedido.ModificarEstado(pedido);
                       
            MessageBox.Show("Pedido Realizado");
            MostrarPedido(nPedido.ListarTodoxEstado(pendiente));
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
         

        
    }
}
