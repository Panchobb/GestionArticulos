namespace Gestor_de_Catalogo
{
    partial class frmAgregar
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
            txtCodigo = new TextBox();
            LblCodigo = new Label();
            lblNombre = new Label();
            textBox1 = new TextBox();
            lblMarca = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblCategoria = new Label();
            cbxMarca = new ComboBox();
            cbxCategoria = new ComboBox();
            lblUrlImagen = new Label();
            txtUrlImagen = new TextBox();
            pbcxArticulo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbcxArticulo).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(225, 72);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(93, 23);
            txtCodigo.TabIndex = 0;
            // 
            // LblCodigo
            // 
            LblCodigo.Font = new Font("Arial", 12F);
            LblCodigo.ForeColor = SystemColors.ButtonHighlight;
            LblCodigo.Location = new Point(128, 75);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(81, 20);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Arial", 12F);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(128, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 23);
            textBox1.TabIndex = 2;
            // 
            // lblMarca
            // 
            lblMarca.Font = new Font("Arial", 12F);
            lblMarca.ForeColor = SystemColors.ButtonHighlight;
            lblMarca.Location = new Point(138, 192);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(81, 20);
            lblMarca.TabIndex = 5;
            lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Arial", 12F);
            lblDescripcion.ForeColor = SystemColors.ButtonHighlight;
            lblDescripcion.Location = new Point(97, 276);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(103, 20);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(225, 276);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(218, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(99, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(327, 383);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(225, 312);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(108, 23);
            txtPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.Font = new Font("Arial", 12F);
            lblPrecio.ForeColor = SystemColors.ButtonHighlight;
            lblPrecio.Location = new Point(138, 312);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(81, 20);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.Font = new Font("Arial", 12F);
            lblCategoria.ForeColor = SystemColors.ButtonHighlight;
            lblCategoria.Location = new Point(119, 232);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(81, 20);
            lblCategoria.TabIndex = 13;
            lblCategoria.Text = "Categoria";
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(225, 192);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(121, 23);
            cbxMarca.TabIndex = 14;
            cbxMarca.SelectedIndexChanged += cbxMarca_SelectedIndexChanged;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(225, 232);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 15;
            // 
            // lblUrlImagen
            // 
            lblUrlImagen.Font = new Font("Arial", 12F);
            lblUrlImagen.ForeColor = SystemColors.ButtonHighlight;
            lblUrlImagen.Location = new Point(128, 151);
            lblUrlImagen.Name = "lblUrlImagen";
            lblUrlImagen.Size = new Size(81, 20);
            lblUrlImagen.TabIndex = 17;
            lblUrlImagen.Text = "Imagen";
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(225, 151);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(93, 23);
            txtUrlImagen.TabIndex = 16;
            txtUrlImagen.Leave += txtUrlImagen_Leave;
            // 
            // pbcxArticulo
            // 
            pbcxArticulo.Location = new Point(564, 72);
            pbcxArticulo.Name = "pbcxArticulo";
            pbcxArticulo.Size = new Size(275, 310);
            pbcxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbcxArticulo.TabIndex = 18;
            pbcxArticulo.TabStop = false;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(894, 456);
            Controls.Add(pbcxArticulo);
            Controls.Add(lblUrlImagen);
            Controls.Add(txtUrlImagen);
            Controls.Add(cbxCategoria);
            Controls.Add(cbxMarca);
            Controls.Add(lblCategoria);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblMarca);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Controls.Add(LblCodigo);
            Controls.Add(txtCodigo);
            Name = "frmAgregar";
            Text = "Agregar";
            Load += frmAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)pbcxArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label LblCodigo;
        private Label lblNombre;
        private TextBox textBox1;
        private Label lblMarca;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private ComboBox cbxMarca;
        private ComboBox cbxCategoria;
        private Label lblUrlImagen;
        private TextBox txtUrlImagen;
        private PictureBox pbcxArticulo;
    }
}