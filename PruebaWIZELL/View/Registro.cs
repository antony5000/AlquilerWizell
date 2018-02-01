using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaWIZELL.Controller;

namespace PruebaWIZELL.View
{
    public partial class Registro : Form
    {
        bool status = false;
        public Registro()
        {
            InitializeComponent();



        }
        public Registro(string usuario)
        {
            InitializeComponent();
            Model.Usuarios UserDetail = new Model.Usuarios();
            UserDetail = Acciones.BuscaUser(usuario);
            if (UserDetail != null)
            {
                textBoxUsuario.Text = usuario;
                textBoxUsuario.ReadOnly = true;
                textBoxPassword.Text = UserDetail.Contrasena;
                comboBoxTipo.Text = UserDetail.Tipo;
                textBoxNombre.Text = UserDetail.Nombre;
                textBoxApellido.Text = UserDetail.Apellido;
                textBoxTelefono.Text = UserDetail.telefono;
                textBoxDireccion.Text = UserDetail.direccion;
                status = UserDetail.estatus;
                textBoxStatus.Text = status.ToString();
            }
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Usuarios Clientes = new Usuarios(this.textBoxUsuario);
            Clientes.ShowDialog();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            Model.Usuarios UserDetail = new Model.Usuarios();
            UserDetail = Acciones.BuscaUser(textBoxUsuario.Text);
            if (UserDetail != null)
            {
                textBoxUsuario.ReadOnly = true;
                textBoxPassword.Text = UserDetail.Contrasena;
                comboBoxTipo.Text = UserDetail.Tipo;
                textBoxNombre.Text = UserDetail.Nombre;
                textBoxApellido.Text = UserDetail.Apellido;
                textBoxTelefono.Text = UserDetail.telefono;
                textBoxDireccion.Text = UserDetail.direccion;
                status = UserDetail.estatus;
                textBoxStatus.Text = status.ToString();
            }

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
            if (status)
            {
                buttonBloquear.BringToFront();
            }
            else
            {
                buttonBloquear.SendToBack();
            }
        }

        private void buttonBloquear_Click(object sender, EventArgs e)
        {
            status = false;
            textBoxStatus.Text = status.ToString();
        }

        private void buttonReactivar_Click(object sender, EventArgs e)
        {
            status = true;
            textBoxStatus.Text = status.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Model.Usuarios User = new Model.Usuarios();

            User.UserId = textBoxUsuario.Text;
            User.Nombre = textBoxNombre.Text;
            User.Apellido = textBoxApellido.Text;
            User.Contrasena = textBoxPassword.Text;
            User.direccion = textBoxDireccion.Text;
            User.telefono = textBoxTelefono.Text;
            if (textBoxStatus.Text == "")
                User.estatus = true;
            else
                User.estatus = status;
            User.Tipo = comboBoxTipo.Text;
            if (Acciones.NuevoUser(User))
            {
                MessageBox.Show("Usuario creado exitosamente");
                limpiar();
            }
            else
            {

            }
        }
        private void limpiar()
        {
            textBoxUsuario.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxPassword.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            status = false;
            textBoxStatus.Text = "";
            comboBoxTipo.Text = "";
        }
    }
}
