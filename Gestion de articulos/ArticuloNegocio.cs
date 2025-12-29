using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulos1> listar()
        {
            List<Articulos1> lista = new List<Articulos1>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, 
                                         a.ImagenUrl, a.IdMarca, a.IdCategoria,
                                         m.Descripcion AS Marca, c.Descripcion AS Categoria
                                  FROM ARTICULOS a
                                  LEFT JOIN MARCAS m ON a.IdMarca = m.Id
                                  LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos1 articulo = new Articulos1();
                    articulo.Codigo = datos.Lector["Codigo"] != DBNull.Value ? (string)datos.Lector["Codigo"] : string.Empty;
                    articulo.Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : string.Empty;
                    articulo.Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : string.Empty;
                    articulo.Precio = datos.Lector["Precio"] != DBNull.Value ? Convert.ToDecimal(datos.Lector["Precio"]) : 0;
                    articulo.ImagenUrl = datos.Lector["ImagenUrl"] != DBNull.Value ? (string)datos.Lector["ImagenUrl"] : string.Empty;

                    articulo.marca = new Marca();
                    articulo.marca.Id = datos.Lector["IdMarca"] != DBNull.Value ? Convert.ToInt32(datos.Lector["IdMarca"]) : 0;
                    articulo.marca.Descripcion = datos.Lector["Marca"] != DBNull.Value ? (string)datos.Lector["Marca"] : string.Empty;

                    articulo.categorias = new Categorias();
                    articulo.categorias.Id = datos.Lector["IdCategoria"] != DBNull.Value ? Convert.ToInt32(datos.Lector["IdCategoria"]) : 0;
                    articulo.categorias.Descripcion = datos.Lector["Categoria"] != DBNull.Value ? (string)datos.Lector["Categoria"] : string.Empty;

                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void agregar(Articulos1 nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) " +
                             "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @ImagenUrl, @IdMarca, @IdCategoria)");

                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@ImagenUrl",
    string.IsNullOrEmpty(nuevo.ImagenUrl) ? (object)DBNull.Value : nuevo.ImagenUrl);

                
                datos.SetearParametro("@IdMarca", nuevo.marca.Id);
                datos.SetearParametro("@IdCategoria", nuevo.categorias.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}