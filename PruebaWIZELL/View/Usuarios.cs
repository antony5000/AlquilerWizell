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
    public partial class Usuarios : Form
    {
        TextBox Cliente;
        public Usuarios(TextBox textboxCliente)
        {
            InitializeComponent();
            dataGridViewClientes.AutoGenerateColumns = false;
            Cliente = textboxCliente;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = Acciones.Usuarios("");
            dataGridViewClientes.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Cliente.Text = (string)dataGridViewClientes.CurrentRow.Cells[0].Value;
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = Acciones.Usuarios(textBoxBuscar.Text.Trim());
            dataGridViewClientes.Refresh();
        }

        private void textBoxBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(this, new EventArgs());
            }
        }
    }
}
