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
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Threading;

namespace PruebaWIZELL.View
{
    public partial class Inicio : Form
    {
        public static bool nivel = false;
        public Inicio(string user)
        {
            InitializeComponent();
            this.textBoxUser.Text = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                var Login = Acciones.Login(textBoxUser.Text, textBoxPass.Text);
                if (Login.Item1 && Login.Item2)
                {
                    //var t = new Thread(() => Application.Run(new MenuPrincipal(this.textBoxUser.Text)));
                    //t.Start();
                    //Application.Exit();
                    //t.Abort();
                    MenuPrincipal menu = new MenuPrincipal(this.textBoxUser.Text);
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                    textBoxPass.Text = "";
                }
                else
                {
                    MessageBox.Show(Login.Item3);
                }
            }


        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "" && textBoxPass.Text != "")
            {
                var Login = Acciones.Login(textBoxUser.Text, textBoxPass.Text);
                if (Login.Item1 && Login.Item2)
                {
                    if (Login.Item4 == 1)
                    {
                        Registro signin = new Registro();
                        signin.ShowDialog();
                    }
                }
            }
        }
    }
}
