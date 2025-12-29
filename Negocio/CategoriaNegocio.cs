using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categorias> Listar()
        {
            var lista = new List<Categorias>();
            var datos = new AccesoDatos();
            try
            {
               
                datos.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();
         
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
