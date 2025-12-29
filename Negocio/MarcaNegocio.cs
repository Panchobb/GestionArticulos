using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            var lista = new List<Marca>();
            var datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = datos.Lector["Id"] != DBNull.Value ? Convert.ToInt32(datos.Lector["Id"]) : 0;
                    aux.Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? Convert.ToString(datos.Lector["Descripcion"]) : string.Empty;
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

