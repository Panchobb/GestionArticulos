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
               
                datos.SetearConsulta(
                    "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion AS Marca, c.Descripcion AS Categoria, a.ImagenUrl, a.Precio, a.IdMarca, a.IdCategoria " +
                    "FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE m.Id = a.IdMarca AND c.Id = a.IdCategoria");

                datos.EjecutarLectura();

                SqlDataReader lector = datos.Lector;

                while (lector.Read())
                {
                    Articulos1 aux = new Articulos1();
                   aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    Marca marca = new Marca();
                    aux.marca = new Marca();
                    aux.marca.Id = (int)lector["IdMarca"];
                    aux.marca.Descripcion = (string)lector["Marca"];
                    Categorias categoria = new Categorias();
                    aux.categorias = new Categorias();
                    aux.categorias.Id = (int)lector["IdCategoria"];
                    aux.categorias.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    if (!lector.IsDBNull(lector.GetOrdinal("ImagenUrl")))
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
            if (nuevo.marca == null)
                throw new Exception("La marca no puede ser nula.");
            if (nuevo.categorias == null)
                throw new Exception("La categoría no puede ser nula.");

            AccesoDatos datos = new AccesoDatos();
            try
            {
               
                datos.SetearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) " +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @ImagenUrl, @IdMarca, @IdCategoria)");
                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@Precio", nuevo.Precio);
                datos.SetearParametro("@ImagenUrl", nuevo.ImagenUrl);
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
        public void modificado(Articulos1 aux)
        {
          AccesoDatos datos = new AccesoDatos();
            try
            {
                 
                datos.SetearConsulta(
                    "UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, ImagenUrl = @ImagenUrl, IdMarca = @IdMarca, IdCategoria = @IdCategoria " +
                    "WHERE Id = @Id");
                datos.SetearParametro("@Codigo", aux.Codigo);
                datos.SetearParametro("@Nombre", aux.Nombre);
                datos.SetearParametro("@Descripcion", aux.Descripcion);
                datos.SetearParametro("@Precio", aux.Precio);
                datos.SetearParametro("@ImagenUrl", aux.ImagenUrl);
                datos.SetearParametro("@IdMarca", aux.marca.Id);
                datos.SetearParametro("@IdCategoria", aux.categorias.Id);
                datos.SetearParametro("@Id", aux.Id);
    
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
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.SetearParametro("@Id", id);
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
    