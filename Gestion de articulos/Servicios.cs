using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using System.Security.Cryptography;
using Gestor_de_Catalogo;

namespace Gestor
{
    public partial class Servicios : Form
    {
        private List<Articulos1> listaArticulos;
        public Servicios()
        {
            InitializeComponent();

        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_Articulos.CurrentRow == null || Dgv_Articulos.CurrentRow.DataBoundItem == null)
                return;

            Articulos1 seleccionado = (Articulos1)Dgv_Articulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);

            txtCodigo.Text = seleccionado.Codigo;
            txtNombre.Text = seleccionado.Nombre;
            txtDescripcion.Text = seleccionado.Descripcion;
            txtMarca.Text = seleccionado.marca.Descripcion;
            txtCategoria.Text = seleccionado.categorias.Descripcion;
            txtPrecio.Text = seleccionado.Precio.ToString("C");



        }
        private void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                Dgv_Articulos.DataSource = listaArticulos;
                Dgv_Articulos.Columns["ImagenUrl"].Visible = false;
                Dgv_Articulos.Columns["Id"].Visible = false;
                if (listaArticulos.Count > 0)
                    CargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbx_Articulos.Load(imagen);
            }
            catch (Exception)
            {
                pbx_Articulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            Cargar();
        }

        private void Dgv_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (Dgv_Articulos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un artículo.");
                return;
            }

            Articulos1 seleccionado = (Articulos1)Dgv_Articulos.CurrentRow.DataBoundItem;


            frmAgregar modificar = new frmAgregar(seleccionado);

            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulos1 seleccionado;
            try {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar este artículo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes){
                    seleccionado = (Articulos1)Dgv_Articulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eliminado Exitosamente");
            }
        }
    }


}
