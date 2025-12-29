namespace Gestor
{
    partial class Servicios
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
            Dgv_Articulos = new DataGridView();
            pbx_Articulos = new PictureBox();
            lbl_ListaArticulos = new Label();
            Lbl_Buscar = new Label();
            Lbl_Linea = new Label();
            Lbl_Detalle = new Label();
            Lbl_Codigo1 = new Label();
            LblMarca = new Label();
            LblDescripcion = new Label();
            LblCategoria = new Label();
            txtCodigo = new TextBox();
            txtMarca = new TextBox();
            txtDescripcion = new TextBox();
            txtCategoria = new TextBox();
            txtNombre = new TextBox();
            LblNombre = new Label();
            txtBuscar = new TextBox();
            btnFiltro = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtPrecio = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv_Articulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Articulos).BeginInit();
            SuspendLayout();
            // 
            // Dgv_Articulos
            // 
            Dgv_Articulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Articulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Articulos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            Dgv_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Articulos.Location = new Point(-1, 128);
            Dgv_Articulos.Name = "Dgv_Articulos";
            Dgv_Articulos.Size = new Size(704, 486);
            Dgv_Articulos.TabIndex = 4;
            Dgv_Articulos.CellContentClick += Dgv_Articulos_CellContentClick;
            Dgv_Articulos.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // pbx_Articulos
            // 
            pbx_Articulos.Location = new Point(734, 88);
            pbx_Articulos.Name = "pbx_Articulos";
            pbx_Articulos.Size = new Size(213, 269);
            pbx_Articulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Articulos.TabIndex = 5;
            pbx_Articulos.TabStop = false;
            // 
            // lbl_ListaArticulos
            // 
            lbl_ListaArticulos.AutoSize = true;
            lbl_ListaArticulos.BackColor = Color.FromArgb(64, 64, 64);
            lbl_ListaArticulos.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ListaArticulos.ForeColor = SystemColors.ButtonHighlight;
            lbl_ListaArticulos.Location = new Point(13, 12);
            lbl_ListaArticulos.Margin = new Padding(4, 0, 4, 0);
            lbl_ListaArticulos.Name = "lbl_ListaArticulos";
            lbl_ListaArticulos.Size = new Size(247, 33);
            lbl_ListaArticulos.TabIndex = 6;
            lbl_ListaArticulos.Text = "Listado de Articulos";
            lbl_ListaArticulos.Click += label1_Click;
            // 
            // Lbl_Buscar
            // 
            Lbl_Buscar.AutoSize = true;
            Lbl_Buscar.BackColor = Color.FromArgb(64, 64, 64);
            Lbl_Buscar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Buscar.ForeColor = SystemColors.ButtonHighlight;
            Lbl_Buscar.Location = new Point(13, 88);
            Lbl_Buscar.Margin = new Padding(5, 0, 5, 0);
            Lbl_Buscar.Name = "Lbl_Buscar";
            Lbl_Buscar.Size = new Size(88, 25);
            Lbl_Buscar.TabIndex = 7;
            Lbl_Buscar.Text = "Buscar : ";
            // 
            // Lbl_Linea
            // 
            Lbl_Linea.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Linea.Location = new Point(709, 9);
            Lbl_Linea.Name = "Lbl_Linea";
            Lbl_Linea.Size = new Size(2, 609);
            Lbl_Linea.TabIndex = 8;
            // 
            // Lbl_Detalle
            // 
            Lbl_Detalle.BackColor = Color.FromArgb(64, 64, 64);
            Lbl_Detalle.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Detalle.ForeColor = SystemColors.ButtonHighlight;
            Lbl_Detalle.Location = new Point(726, 30);
            Lbl_Detalle.Margin = new Padding(4, 0, 4, 0);
            Lbl_Detalle.Name = "Lbl_Detalle";
            Lbl_Detalle.Size = new Size(248, 34);
            Lbl_Detalle.TabIndex = 9;
            Lbl_Detalle.Text = "Detalles del Articulo";
            // 
            // Lbl_Codigo1
            // 
            Lbl_Codigo1.AutoSize = true;
            Lbl_Codigo1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Codigo1.ForeColor = Color.White;
            Lbl_Codigo1.Location = new Point(751, 407);
            Lbl_Codigo1.Name = "Lbl_Codigo1";
            Lbl_Codigo1.Size = new Size(71, 18);
            Lbl_Codigo1.TabIndex = 10;
            Lbl_Codigo1.Text = "Codigo : ";
            // 
            // LblMarca
            // 
            LblMarca.AutoSize = true;
            LblMarca.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMarca.ForeColor = Color.White;
            LblMarca.Location = new Point(759, 489);
            LblMarca.Name = "LblMarca";
            LblMarca.Size = new Size(63, 18);
            LblMarca.TabIndex = 20;
            LblMarca.Text = "Marca : ";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripcion.ForeColor = Color.White;
            LblDescripcion.Location = new Point(717, 527);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(105, 18);
            LblDescripcion.TabIndex = 21;
            LblDescripcion.Text = "Descripcion : ";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.ForeColor = Color.White;
            LblCategoria.Location = new Point(733, 561);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(89, 18);
            LblCategoria.TabIndex = 23;
            LblCategoria.Text = "Categoria : ";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(64, 64, 64);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtCodigo.ForeColor = SystemColors.Info;
            txtCodigo.Location = new Point(828, 403);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(170, 22);
            txtCodigo.TabIndex = 24;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(64, 64, 64);
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtMarca.ForeColor = SystemColors.Info;
            txtMarca.Location = new Point(828, 484);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(170, 22);
            txtMarca.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtDescripcion.ForeColor = SystemColors.Info;
            txtDescripcion.Location = new Point(828, 523);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(262, 22);
            txtDescripcion.TabIndex = 26;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.FromArgb(64, 64, 64);
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtCategoria.ForeColor = SystemColors.Info;
            txtCategoria.Location = new Point(828, 561);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(189, 22);
            txtCategoria.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(64, 64, 64);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtNombre.ForeColor = SystemColors.Info;
            txtNombre.Location = new Point(828, 441);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 22);
            txtNombre.TabIndex = 29;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = Color.White;
            LblNombre.Location = new Point(746, 445);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(76, 18);
            LblNombre.TabIndex = 28;
            LblNombre.Text = "Nombre : ";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(99, 90);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(207, 23);
            txtBuscar.TabIndex = 30;
            // 
            // btnFiltro
            // 
            btnFiltro.AutoSize = true;
            btnFiltro.BackColor = Color.Gray;
            btnFiltro.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltro.ForeColor = SystemColors.ButtonHighlight;
            btnFiltro.Location = new Point(324, 88);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(89, 34);
            btnFiltro.TabIndex = 31;
            btnFiltro.Text = "Filtro";
            btnFiltro.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.Gray;
            btnAgregar.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(717, 652);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 34);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.BackColor = Color.Gray;
            btnModificar.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(845, 652);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 34);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.Gray;
            btnEliminar.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(965, 652);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 34);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(64, 64, 64);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtPrecio.ForeColor = SystemColors.Info;
            txtPrecio.Location = new Point(828, 592);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(189, 22);
            txtPrecio.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(756, 597);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 35;
            label1.Text = "Precio : ";
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1102, 708);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnFiltro);
            Controls.Add(txtBuscar);
            Controls.Add(txtNombre);
            Controls.Add(LblNombre);
            Controls.Add(txtCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(txtMarca);
            Controls.Add(txtCodigo);
            Controls.Add(LblCategoria);
            Controls.Add(LblDescripcion);
            Controls.Add(LblMarca);
            Controls.Add(Lbl_Codigo1);
            Controls.Add(Lbl_Detalle);
            Controls.Add(Lbl_Linea);
            Controls.Add(Lbl_Buscar);
            Controls.Add(lbl_ListaArticulos);
            Controls.Add(pbx_Articulos);
            Controls.Add(Dgv_Articulos);
            Name = "Servicios";
            Text = "Gestor de Catalogo";
            Load += Servicios_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv_Articulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Articulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Dgv_Articulos;
        private PictureBox pbx_Articulos;
        private Label lbl_ListaArticulos;
        private Label Lbl_Buscar;
        private Label Lbl_Linea;
        private Label Lbl_Detalle;
        private Label Lbl_Codigo1;
        private Label LblMarca;
        private Label LblDescripcion;
        private Label LblCategoria;
        private TextBox txtCodigo;
        private TextBox txtMarca;
        private TextBox txtDescripcion;
        private TextBox txtCategoria;
        private TextBox txtNombre;
        private Label LblNombre;
        private TextBox txtBuscar;
        private Button btnFiltro;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtPrecio;
        private Label label1;
    }
}