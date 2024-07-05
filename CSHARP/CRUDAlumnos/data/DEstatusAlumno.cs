using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace data
{
    public class DEstatusAlumno 
    {
        string _cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string _query;
        SqlCommand comando;
         public List<EstatusAlumno> Consultar()
        {

            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
            _query = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaEstatus.Add(new EstatusAlumno()
                    {
                        id = Convert.ToInt16(reader["id"]),
                        nombre = reader["nombre"].ToString()
                    });
                }
                con.Close();
            }
            return listaEstatus;
        }

    }
}
