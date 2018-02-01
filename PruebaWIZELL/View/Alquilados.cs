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
    public partial class Alquilados : Form
    {
        public Alquilados()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = Acciones.ConsultaAlquileres("");
            dataGridViewClientes.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = Acciones.ConsultaAlquileres(textBoxBuscar.Text.Trim());
            dataGridViewClientes.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
