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
    public partial class Catalogo : Form
    {
        TextBox JuegoN;
        int Cantidad = 0;
        int IdJuegoSelected = 0;
        bool estatus = false;
        public Catalogo(TextBox juego)
        {
            InitializeComponent();
            JuegoN = juego;
            dataGridViewJuegos.AutoGenerateColumns = false;
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            dataGridViewJuegos.DataSource = Acciones.Catalogo("");
            dataGridViewJuegos.Refresh();
            dataGridViewJuegos.ClearSelection();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewJuegos.DataSource = Acciones.Catalogo(textBoxBuscar.Text.Trim());
            dataGridViewJuegos.Refresh();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJuegos.CurrentRow.Selected)
            {
                IdJuegoSelected = (int)dataGridViewJuegos.CurrentRow.Cells[0].Value;
                textBoxTitulo.Text = (string)dataGridViewJuegos.CurrentRow.Cells[1].Value;
                textBoxCantidad.Text = dataGridViewJuegos.CurrentRow.Cells[2].Value.ToString();
                textBoxDescripcion.Text = (string)dataGridViewJuegos.CurrentRow.Cells[3].Value;
                comboBoxGenero.Text = (string)dataGridViewJuegos.CurrentRow.Cells[4].Value;
                comboBoxConsola.Text = (string)dataGridViewJuegos.CurrentRow.Cells[5].Value;
                dateTimePickerIngreso.Value = (DateTime)dataGridViewJuegos.CurrentRow.Cells[6].Value;
                estatus = (bool)dataGridViewJuegos.CurrentRow.Cells[7].Value;
            }
            dataGridViewJuegos.Visible = false;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Model.Catalogo Juego = new Model.Catalogo();
            if (IdJuegoSelected != 0) Juego.IdJuego = IdJuegoSelected;
            Juego.Titulo = textBoxTitulo.Text.TrimEnd();
            Juego.Genero = comboBoxGenero.Text;
            Juego.Consola = comboBoxConsola.Text;
            Juego.Descripcion = textBoxDescripcion.Text.TrimEnd();
            Juego.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
            if (Juego.Cantidad > 0) Juego.Estatus = true;
            else Juego.Estatus = false;
            Juego.FechaIngreso = dateTimePickerIngreso.Value;
            Acciones.NuevoJuego(Juego);
            dataGridViewJuegos.DataSource = Acciones.Catalogo("");
            dataGridViewJuegos.Refresh();
            LimpiarCatalogo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Cantidad = Convert.ToInt32(textBoxCantidad.Text);
            Cantidad++;
            textBoxCantidad.Text = Cantidad.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (Cantidad > 0)
            {
                Cantidad--;
                textBoxCantidad.Text = Cantidad.ToString();
            }
        }

        private void buttonCancelar2_Click(object sender, EventArgs e)
        {
            LimpiarCatalogo();
        }
        private void LimpiarCatalogo()
        {

            dataGridViewJuegos.BringToFront();
            IdJuegoSelected = 0;
            textBoxTitulo.Text = "";
            textBoxCantidad.Text = "0";
            textBoxDescripcion.Text = "";
            comboBoxGenero.Text = "";
            comboBoxConsola.Text = "";
            dateTimePickerIngreso.Value = DateTime.Today;
            Cantidad = 0;
            estatus = false;
            dataGridViewJuegos.Visible = true;
        }

        private void Catalogo_Click(object sender, EventArgs e)
        {
            dataGridViewJuegos.ClearSelection();
        }

        private void dataGridViewJuegos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dataGridViewJuegos.ClearSelection();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            JuegoN.Text = (string)dataGridViewJuegos.CurrentRow.Cells[1].Value;
            MenuPrincipal.genero = (string)dataGridViewJuegos.CurrentRow.Cells[4].Value;
            MenuPrincipal.idjuego = dataGridViewJuegos.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void buttonBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBuscar_Click(this, new EventArgs());
            }
        }
    }
}
