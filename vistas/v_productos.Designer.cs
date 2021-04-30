﻿
namespace vistas
{
    partial class v_productos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.c_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlDatosProducto = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picProducto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlDatosProducto.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProductos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 287);
            this.panel2.TabIndex = 1;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_id,
            this.c_Codigo,
            this.c_nombre,
            this.c_descripcion,
            this.c_marca,
            this.c_categoria,
            this.c_url,
            this.c_precio,
            this.c_stock,
            this.c_estado});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(544, 287);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // c_id
            // 
            this.c_id.DataPropertyName = "ID";
            this.c_id.HeaderText = "ID";
            this.c_id.Name = "c_id";
            this.c_id.ReadOnly = true;
            this.c_id.Visible = false;
            // 
            // c_Codigo
            // 
            this.c_Codigo.DataPropertyName = "Codigo";
            this.c_Codigo.HeaderText = "Codigo";
            this.c_Codigo.Name = "c_Codigo";
            this.c_Codigo.ReadOnly = true;
            this.c_Codigo.Visible = false;
            // 
            // c_nombre
            // 
            this.c_nombre.DataPropertyName = "Nombre";
            this.c_nombre.HeaderText = "Nombre";
            this.c_nombre.Name = "c_nombre";
            this.c_nombre.ReadOnly = true;
            // 
            // c_descripcion
            // 
            this.c_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_descripcion.DataPropertyName = "Descripcion";
            this.c_descripcion.HeaderText = "Descripcion";
            this.c_descripcion.Name = "c_descripcion";
            this.c_descripcion.ReadOnly = true;
            // 
            // c_marca
            // 
            this.c_marca.DataPropertyName = "Marca";
            this.c_marca.HeaderText = "Marca";
            this.c_marca.Name = "c_marca";
            this.c_marca.ReadOnly = true;
            this.c_marca.Visible = false;
            // 
            // c_categoria
            // 
            this.c_categoria.DataPropertyName = "Categoria";
            this.c_categoria.HeaderText = "Categoria";
            this.c_categoria.Name = "c_categoria";
            this.c_categoria.ReadOnly = true;
            this.c_categoria.Visible = false;
            // 
            // c_url
            // 
            this.c_url.DataPropertyName = "UrlImagen";
            this.c_url.HeaderText = "UrlImagen";
            this.c_url.Name = "c_url";
            this.c_url.ReadOnly = true;
            this.c_url.Visible = false;
            // 
            // c_precio
            // 
            this.c_precio.DataPropertyName = "Precio";
            this.c_precio.HeaderText = "Precio";
            this.c_precio.Name = "c_precio";
            this.c_precio.ReadOnly = true;
            this.c_precio.Visible = false;
            // 
            // c_stock
            // 
            this.c_stock.DataPropertyName = "Stock";
            this.c_stock.HeaderText = "Stock";
            this.c_stock.Name = "c_stock";
            this.c_stock.ReadOnly = true;
            // 
            // c_estado
            // 
            this.c_estado.DataPropertyName = "Estado";
            this.c_estado.HeaderText = "Estado";
            this.c_estado.Name = "c_estado";
            this.c_estado.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.pnlDatosProducto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 108);
            this.panel3.TabIndex = 2;
            // 
            // pnlDatosProducto
            // 
            this.pnlDatosProducto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDatosProducto.Controls.Add(this.panel8);
            this.pnlDatosProducto.Controls.Add(this.label8);
            this.pnlDatosProducto.Controls.Add(this.label7);
            this.pnlDatosProducto.Controls.Add(this.label4);
            this.pnlDatosProducto.Controls.Add(this.label3);
            this.pnlDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosProducto.Name = "pnlDatosProducto";
            this.pnlDatosProducto.Size = new System.Drawing.Size(544, 108);
            this.pnlDatosProducto.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel8.Controls.Add(this.lblPrecio);
            this.panel8.Controls.Add(this.lblMarca);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.lblDescripcion);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.lblCategoria);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.lblNombre);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(544, 108);
            this.panel8.TabIndex = 27;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrecio.Location = new System.Drawing.Point(183, 77);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblPrecio.Size = new System.Drawing.Size(153, 21);
            this.lblPrecio.TabIndex = 38;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMarca.Location = new System.Drawing.Point(15, 76);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblMarca.Size = new System.Drawing.Size(153, 21);
            this.lblMarca.TabIndex = 30;
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(183, 56);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label16.Size = new System.Drawing.Size(153, 21);
            this.label16.TabIndex = 37;
            this.label16.Text = "Precio:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 55);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(153, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Marca:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDescripcion.Location = new System.Drawing.Point(352, 30);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblDescripcion.Size = new System.Drawing.Size(177, 68);
            this.lblDescripcion.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(352, 10);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(177, 21);
            this.label17.TabIndex = 35;
            this.label17.Text = "Descripcion";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCategoria.Location = new System.Drawing.Point(183, 31);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblCategoria.Size = new System.Drawing.Size(153, 21);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(183, 10);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(153, 21);
            this.label13.TabIndex = 35;
            this.label13.Text = "Categoria:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Location = new System.Drawing.Point(15, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(153, 21);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(15, 10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nombre:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(15, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Categoria:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Marca:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(15, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picProducto);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 335);
            this.panel4.TabIndex = 0;
            // 
            // picProducto
            // 
            this.picProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProducto.ErrorImage = global::vistas.Properties.Resources.giferror2;
            this.picProducto.Image = global::vistas.Properties.Resources.logo;
            this.picProducto.InitialImage = global::vistas.Properties.Resources.earth_globe;
            this.picProducto.Location = new System.Drawing.Point(0, 86);
            this.picProducto.Name = "picProducto";
            this.picProducto.Size = new System.Drawing.Size(163, 164);
            this.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProducto.TabIndex = 0;
            this.picProducto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(544, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 395);
            this.panel1.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(0, 335);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(163, 30);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(0, 365);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 30);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.comboBox3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(707, 36);
            this.panel5.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(593, 8);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(104, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(529, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Categoria";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(400, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(357, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Marca";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(280, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 20);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Buscar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(707, 26);
            this.panel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Listado de Productos";
            // 
            // v_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(707, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "v_productos";
            this.Text = "v_productos";
            this.Load += new System.EventHandler(this.v_productos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlDatosProducto.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlDatosProducto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_estado;
    }
}