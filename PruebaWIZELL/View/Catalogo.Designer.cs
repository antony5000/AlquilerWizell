namespace PruebaWIZELL.View
{
    partial class Catalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
            this.dataGridViewJuegos = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxConsola = new System.Windows.Forms.ComboBox();
            this.labelConsola = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelngreso = new System.Windows.Forms.Label();
            this.dateTimePickerIngreso = new System.Windows.Forms.DateTimePicker();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar2 = new System.Windows.Forms.Button();
            this.IdJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJuegos
            // 
            this.dataGridViewJuegos.AllowUserToAddRows = false;
            this.dataGridViewJuegos.AllowUserToDeleteRows = false;
            this.dataGridViewJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdJuego,
            this.Titulo,
            this.Cant,
            this.Description,
            this.Genero,
            this.Consola,
            this.Ingreso,
            this.Estatus});
            this.dataGridViewJuegos.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewJuegos.Name = "dataGridViewJuegos";
            this.dataGridViewJuegos.ReadOnly = true;
            this.dataGridViewJuegos.RowHeadersVisible = false;
            this.dataGridViewJuegos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJuegos.Size = new System.Drawing.Size(422, 204);
            this.dataGridViewJuegos.TabIndex = 24;
            this.dataGridViewJuegos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewJuegos_KeyDown);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar.Location = new System.Drawing.Point(378, 97);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(19, 20);
            this.buttonBuscar.TabIndex = 29;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            this.buttonBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonBuscar_KeyDown);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(76, 98);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(296, 20);
            this.textBoxBuscar.TabIndex = 28;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(9, 101);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(33, 13);
            this.labelBuscar.TabIndex = 27;
            this.labelBuscar.Text = "Titulo";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(129, 12);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(57, 65);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.Location = new System.Drawing.Point(12, 12);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(52, 65);
            this.buttonAceptar.TabIndex = 25;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(70, 12);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(53, 65);
            this.buttonAgregar.TabIndex = 30;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(9, 126);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 31;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(9, 152);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 32;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Simulacion",
            "RPG",
            "Aventura",
            "Terror",
            "Carreras",
            "Deportes",
            "Plataforma",
            "Lucha"});
            this.comboBoxGenero.Location = new System.Drawing.Point(282, 123);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(142, 21);
            this.comboBoxGenero.TabIndex = 34;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(218, 126);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 33;
            this.labelGenero.Text = "Genero";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(76, 123);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(136, 20);
            this.textBoxTitulo.TabIndex = 35;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(76, 149);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(136, 54);
            this.textBoxDescripcion.TabIndex = 36;
            // 
            // comboBoxConsola
            // 
            this.comboBoxConsola.FormattingEnabled = true;
            this.comboBoxConsola.Items.AddRange(new object[] {
            "Nintendo 64",
            "Nintendo GameCube",
            "Nintendo Wii",
            "Nintendo WiiU",
            "Nintendo Switch",
            "PC",
            "Playstation One",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "Xbox",
            "Xbox 360",
            "Xbox One"});
            this.comboBoxConsola.Location = new System.Drawing.Point(282, 150);
            this.comboBoxConsola.Name = "comboBoxConsola";
            this.comboBoxConsola.Size = new System.Drawing.Size(142, 21);
            this.comboBoxConsola.TabIndex = 37;
            // 
            // labelConsola
            // 
            this.labelConsola.AutoSize = true;
            this.labelConsola.Location = new System.Drawing.Point(218, 153);
            this.labelConsola.Name = "labelConsola";
            this.labelConsola.Size = new System.Drawing.Size(45, 13);
            this.labelConsola.TabIndex = 38;
            this.labelConsola.Text = "Consola";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(282, 177);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.ReadOnly = true;
            this.textBoxCantidad.Size = new System.Drawing.Size(47, 20);
            this.textBoxCantidad.TabIndex = 39;
            this.textBoxCantidad.Text = "0";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(218, 180);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 40;
            this.labelCantidad.Text = "Cantidad";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(335, 177);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRemove.BackgroundImage")));
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Location = new System.Drawing.Point(361, 177);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(20, 20);
            this.buttonRemove.TabIndex = 42;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelngreso
            // 
            this.labelngreso.AutoSize = true;
            this.labelngreso.Location = new System.Drawing.Point(9, 211);
            this.labelngreso.Name = "labelngreso";
            this.labelngreso.Size = new System.Drawing.Size(42, 13);
            this.labelngreso.TabIndex = 43;
            this.labelngreso.Text = "Ingreso";
            // 
            // dateTimePickerIngreso
            // 
            this.dateTimePickerIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIngreso.Location = new System.Drawing.Point(76, 211);
            this.dateTimePickerIngreso.Name = "dateTimePickerIngreso";
            this.dateTimePickerIngreso.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerIngreso.TabIndex = 44;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(76, 253);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 45;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar2
            // 
            this.buttonCancelar2.Location = new System.Drawing.Point(157, 253);
            this.buttonCancelar2.Name = "buttonCancelar2";
            this.buttonCancelar2.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar2.TabIndex = 46;
            this.buttonCancelar2.Text = "Cancelar";
            this.buttonCancelar2.UseVisualStyleBackColor = true;
            this.buttonCancelar2.Click += new System.EventHandler(this.buttonCancelar2_Click);
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
            // Cant
            // 
            this.Cant.DataPropertyName = "Cantidad";
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Descripcion";
            this.Description.HeaderText = "descripcion";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Consola
            // 
            this.Consola.DataPropertyName = "Consola";
            this.Consola.HeaderText = "Consola";
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            // 
            // Ingreso
            // 
            this.Ingreso.DataPropertyName = "FechaIngreso";
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            this.Ingreso.Visible = false;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 349);
            this.Controls.Add(this.dataGridViewJuegos);
            this.Controls.Add(this.buttonCancelar2);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dateTimePickerIngreso);
            this.Controls.Add(this.labelngreso);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelConsola);
            this.Controls.Add(this.comboBoxConsola);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.Click += new System.EventHandler(this.Catalogo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJuegos;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxConsola;
        private System.Windows.Forms.Label labelConsola;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelngreso;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngreso;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}