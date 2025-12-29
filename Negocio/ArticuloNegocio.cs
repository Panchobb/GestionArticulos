using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Net;

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
                                             a.ImagenUrl, m.Descripcion AS Marca, c.Descripcion AS Categoria
                                      FROM ARTICULOS a
                                      LEFT JOIN MARCAS m ON a.IdMarca = m.Id
                                      LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id");
                datos.EjecutarLectura();

                // Usar la propiedad pública Lector de AccesoDatos en lugar de una variable inexistente 'lector'
                SqlDataReader lector = datos.Lector;

                while (lector.Read())
                {
                    Articulos1 aux = new Articulos1();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    Marca marca = new Marca();
                    aux.marca = new Marca();
                    aux.marca.Descripcion = (string)lector["Marca"];
                    Categorias categoria = new Categorias();
                    aux.categorias = new Categorias();
                    aux.categorias.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    aux.ImagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(aux);
                }

                return lista;
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

        public void agregar(Articulos1 nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Usar parámetros correctamente para evitar SQL injection y errores de concatenación
                datos.SetearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) " +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @ImagenUrl, @IdMarca, @IdCategoria)");
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.SetearParametro("@IdMarca", nuevo.marca);
                datos.SetearParametro("@IdCategoria", nuevo.categorias);

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