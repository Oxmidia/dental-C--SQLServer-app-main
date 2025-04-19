using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using dental_C__SQLServer_app.Classes;//Para conectar con la database lol

namespace dental_C__SQLServer_app
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de usuario, para ingresar un nombre
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto:Usuario
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de contrase�a, e ingresar una contrase�a
            if (txtpass.Text == "CONTASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true; //Ocultar contrase�a
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //Mostrar y ocultar la contrase�a que se ha ingresado
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
private void btnRecibos_Click(object sender, EventArgs e)
{
    new ReciboForm().ShowDialog();
}