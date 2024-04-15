using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Classdominio;

namespace Negocio
{
    public class PokemonsNegocio
    {
        //funcion para traer la lista de Pokemos de la BD
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "server=DESKTOP-I8TCKH4\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.id = P.IdTipo and D.Id = P.IdDebilidad AND P.Activo = 1";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();
                //while para recorrer la lista
                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //Validar si el dato de la columna es Null
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];
                    
                    
                    aux.tipo = new Elemento();
                    aux.tipo.id = (int)lector["IdTipo"];
                    aux.tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.tipo.id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["debilidad"];

                    lista.Add(aux);


                }
                conexion.Close();
                
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //funcion para agregar un pokemon a la BD
        public void agregar(Pokemon nuevo)
        {
            //crear un objeto de acceso a datos 
            AccesoDatos datos = new AccesoDatos();

            try
            {

                //dentro de los values se concatena el objeto con cada una de sus propiedades ente "++" si es un int,y '"++"', si es un string,
                //otro modo para pasar datos a la BD es @nombre del parametro.
                datos.setearConsulta("insert into POKEMONS (Numero, Nombre,Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.Numero +",'" + nuevo.Nombre +"','" + nuevo.Descripcion +"',1, @idTipo, @idDebilidad, @urlImagen)");
                //se invoca al metodo  de acceso a datos, setear parametro que recibe un nombre y un valor
                //como nombre se pasa @nombre del parametro y el valor es el objeto en este caso nuevo es 
                // un Pokemon del cual pasamos el tipo y el id y la debilidad y el id
                datos.setearParametro("@idTipo", nuevo.tipo.id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.id);
                datos.setearParametro("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        //funcion para modificar 
        public void modificar(Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");
                datos.setearParametro("@numero", poke.Numero);
                datos.setearParametro("@nombre", poke.Nombre);
                datos.setearParametro("@desc", poke.Descripcion);
                datos.setearParametro("@img", poke.UrlImagen);
                datos.setearParametro("@idTipo", poke.tipo.id);
                datos.setearParametro("@idDebilidad", poke.Debilidad.id);
                datos.setearParametro("@id", poke.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("delete from POKEMONS where Id = @id");
                datos.setearParametro("@id", id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void eliminarLogico(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("update POKEMONS set Activo = 0  where Id = @id");
                datos.setearParametro("@id", id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
        //filtro avanzado
        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            //se crea una lista 
            List<Pokemon> lista = new List<Pokemon>();
            //se crea una conexion a la bd
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //variable para guardar la consulta
                string consulta =  "select Numero, Nombre, P.Descripcion, UrlImagen,E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.id = P.IdTipo and D.Id = P.IdDebilidad AND P.Activo = 1 AND ";
                //swich para manejar todas las posibilidades de buqueda
                switch (campo)
                {
                    case "Numero":
                        switch (criterio)
                        {
                            //en cada case se le agrega a la variable consulta el criterio + el filtro
                            case "Mayor a":
                                consulta += "Numero > " + filtro;
                                break;

                            case "Menor a":
                                consulta += "Numero < " + filtro;
                                break;

                            default:
                                
                                consulta += "Numero = " + filtro;

                                break;
                        }
                    break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;


                    default: //DESCRIPCION


                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "P.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "P.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "P.Descripcion like '%" + filtro + "%'";
                                break;
                        }


                        break;

                    
                }

                //se envia la consulta a la bd
                datos.setearConsulta( consulta );
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    //Validar si el dato de la columna es Null
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];


                    aux.tipo = new Elemento();
                    aux.tipo.id = (int)datos.Lector["IdTipo"];
                    aux.tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.tipo.id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["debilidad"];

                    lista.Add(aux);


                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
     



