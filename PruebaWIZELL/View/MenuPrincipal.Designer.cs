namespace PruebaWIZELL.View
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemJuegos = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.buttonClienteLookup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxJuego = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.IdJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquileresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripSalir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Usuario";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alquileresToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "Clientes";
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(152, 22);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemJuegos});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem3.Text = "Catalogo";
            // 
            // toolStripMenuItemJuegos
            // 
            this.toolStripMenuItemJuegos.Name = "toolStripMenuItemJuegos";
            this.toolStripMenuItemJuegos.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemJuegos.Text = "Juegos";
            this.toolStripMenuItemJuegos.Click += new System.EventHandler(this.toolStripMenuItemJuegos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(89, 53);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(142, 20);
            this.textBoxCliente.TabIndex = 2;
            // 
            // buttonClienteLookup
            // 
            this.buttonClienteLookup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClienteLookup.BackgroundImage")));
            this.buttonClienteLookup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClienteLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClienteLookup.Location = new System.Drawing.Point(237, 53);
            this.buttonClienteLookup.Name = "buttonClienteLookup";
            this.buttonClienteLookup.Size = new System.Drawing.Size(19, 20);
            this.buttonClienteLookup.TabIndex = 3;
            this.buttonClienteLookup.UseVisualStyleBackColor = true;
            this.buttonClienteLookup.Click += new System.EventHandler(this.buttonClienteLookup_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(237, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxJuego
            // 
            this.textBoxJuego.Location = new System.Drawing.Point(89, 79);
            this.textBoxJuego.Name = "textBoxJuego";
            this.textBoxJuego.ReadOnly = true;
            this.textBoxJuego.Size = new System.Drawing.Size(142, 20);
            this.textBoxJuego.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Juego";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(381, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(424, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "fechacorta";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(345, 55);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerInicio.TabIndex = 13;
            this.dateTimePickerInicio.Value = new System.DateTime(2018, 1, 26, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha inicio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha fin";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(345, 81);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(95, 20);
            this.dateTimePickerFin.TabIndex = 15;
            this.dateTimePickerFin.Value = new System.DateTime(2018, 1, 26, 0, 0, 0, 0);
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.Location = new System.Drawing.Point(28, 351);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlquilar.TabIndex = 17;
            this.buttonAlquilar.Text = "Alquilar";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(109, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdJuego,
            this.Titulo,
            this.Genero,
            this.Inicio,
            this.Fin});
            this.dataGridViewPedido.Location = new System.Drawing.Point(28, 129);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.RowHeadersVisible = false;
            this.dataGridViewPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedido.Size = new System.Drawing.Size(454, 183);
            this.dataGridViewPedido.TabIndex = 19;
            this.dataGridViewPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPedido_KeyDown);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.BackgroundImage")));
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgregar.Location = new System.Drawing.Point(462, 109);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(20, 20);
            this.buttonAgregar.TabIndex = 20;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Agregar";
            // 
            // IdJuego
            // 
            this.IdJuego.DataPropertyName = "IdJuego";
            this.IdJuego.HeaderText = "IdJuego";
            this.IdJuego.Name = "IdJuego";
            this.IdJuego.ReadOnly = true;
            this.IdJuego.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "FechaSalida";
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Fin
            // 
            this.Fin.DataPropertyName = "FechaEntrega";
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            // 
            // alquileresToolStripMenuItem
            // 
            this.alquileresToolStripMenuItem.Name = "alquileresToolStripMenuItem";
            this.alquileresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alquileresToolStripMenuItem.Text = "Alquileres";
            this.alquileresToolStripMenuItem.Click += new System.EventHandler(this.alquileresToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 386);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAlquilar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxJuego);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClienteLookup);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemJuegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClienteLookup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textBoxCliente;
        public System.Windows.Forms.TextBox textBoxJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquileresToolStripMenuItem;
    }
}