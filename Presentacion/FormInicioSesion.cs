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
    public partial class FormInicioSesion : Form
    {
        private NAdministrador nAdministrador = new NAdministrador();
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contrasena = tbContrasena.Text;

            string mensaje = nAdministrador.IniciarSesion(usuario, contrasena);

            MessageBox.Show(mensaje);

            if (mensaje == "Sesion Iniciada Correctamente")
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
        }

        private void btCrearCuenta_Click(object sender, EventArgs e)
        {
            FormCrearCuenta form = new FormCrearCuenta();
            form.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
