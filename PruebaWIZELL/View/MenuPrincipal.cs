using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaWIZELL.Controller;

namespace PruebaWIZELL.View
{
    public partial class MenuPrincipal : Form
    {
        string Usuario;
        //DateTime ahora = 
        BindingList<Model.ListaAlquiler> Alquiler;
        public static string genero, idjuego;
        public MenuPrincipal(string User)
        {
            InitializeComponent();
            this.label6.Text = DateTime.Now.ToShortDateString();
            Usuario = User;
            Alquiler = new BindingList<Model.ListaAlquiler>();
            this.Text = this.Text + " - " + User;
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonClienteLookup_Click(object sender, EventArgs e)
        {
            Usuarios Clientes = new Usuarios(this.textBoxCliente);
            Clientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Catalogo Juegos = new Catalogo(this.textBoxJuego);
            Juegos.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxJuego.Text != "" && textBoxCliente.Text != "")
            {
                Model.ListaAlquiler LineaAlquiler = new Model.ListaAlquiler();
                LineaAlquiler.IdJuego = Convert.ToInt32(idjuego);
                LineaAlquiler.Titulo = textBoxJuego.Text;
                LineaAlquiler.Genero = genero;
                LineaAlquiler.FechaSalida = dateTimePickerInicio.Value;
                LineaAlquiler.FechaEntrega = dateTimePickerFin.Value;
                if (!Alquiler.Where(x => x.IdJuego == LineaAlquiler.IdJuego).Any())
                    Alquiler.Add(LineaAlquiler);
                dataGridViewPedido.DataSource = Alquiler;

                dataGridViewPedido.Refresh();
                limpiar();
            }
        }

        private void buttonAlquilar_Click(object sender, EventArgs e)
        {
            if(Acciones.PerformAlquiler(Alquiler, textBoxCliente.Text))
            {
                dataGridViewPedido.Rows.Clear();
                dataGridViewPedido.Refresh();
                MessageBox.Show("Se realizo exitosamente el alquiler");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema creando el alquiler");
            }
        }

        private void toolStripMenuItemJuegos_Click(object sender, EventArgs e)
        {
            Catalogo Juegos = new Catalogo(this.textBoxJuego);
            Juegos.ShowDialog();
        }

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alquilados TotalAlquiler = new Alquilados();
            TotalAlquiler.ShowDialog();
        }

        private void dataGridViewPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dataGridViewPedido.Rows.RemoveAt(dataGridViewPedido.CurrentRow.Index);
            }

        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dataGridViewPedido.Rows.RemoveAt(dataGridViewPedido.CurrentRow.Index);
            }
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro register = new Registro(Usuario);
            register.ShowDialog();
        }
        private void limpiar()
        {
            textBoxJuego.Text = "";
            dateTimePickerInicio.Value = DateTime.Today;
            dateTimePickerFin.Value = DateTime.Today;
        }
        
    }
}
