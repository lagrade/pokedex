using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        //atributos
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //propiedad lector, para poder acceder al lector
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        //contructor del objeto AccesoDatos, se le pasa por parametro la direcion de la BD,
        //se crea un objeto comando
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=DESKTOP-I8TCKH4\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();

        }
        //funcion para hacer una consulta a la BD
        public void setearConsulta(string consulta)
        {
            //asiganarle al comando el tipo de de dato
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        //funcion para ejecutar la consulta
        public void ejecutarConsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        //funcion para agregar un pokeon a la base de datos
        public void ejecutarAccion ()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        //funcion para pasar parametros
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        //funcion para cerrar la conexion y el lector.que valida si el lector tiene informacion
        public void cerrarConexion()
        {
            if (lector != null)
                    lector.Close();
            conexion.Close();
        }
    }
   
}
