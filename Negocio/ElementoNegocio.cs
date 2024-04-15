using Classdominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ElementoNegocio
    {
        //crear el metodo listar para mostrar la BD
        public List<Elemento> listar()
        {
            //crear el objeto lista y el objeto de la conexion (que tiene las funciones 
            //para establecer la conexion, el comando para hacer consultas y el lector
            //para mostrar la informacion)
            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos= new AccesoDatos();
            try
			{
                //del objeto datos (de tipo accesodatos) invoca al metodo setearconsulta, y ejecutar consulta
                datos.setearConsulta("SELECT id, Descripcion FROM ELEMENTOS");
                datos.ejecutarConsulta();

                //while para leer la lista
                while (datos.Lector.Read())
                {
                    //crear un objeto aux para guardar la informacion de cada dato.
                    Elemento aux = new Elemento();
                    aux.id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    //agregar el objeto a la lista
                    lista.Add(aux);

                }
                return lista;

            }
			catch (Exception ex)
			{

				throw ex;
			}
            //cerrar la conexion en un finally para que siempre se ejecute
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
