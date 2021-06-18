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
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader leer;

        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=.\\SQLEXPRESS; initial catalog=Predio; integrated security=sspi");
            comando = new SqlCommand();
        }

        public void SetearConsulta(string Consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = Consulta;        
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            conexion.Open();
            leer = comando.ExecuteReader();
        }

        public SqlDataReader Leer
        {
            get { return leer; }
        }

        internal void EjectutarAccion()
        {
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
        }

        public void CerraConexion()
        {
            if (leer != null)
            {
                leer.Close();

            }

            conexion.Close();
        }

    }
}
