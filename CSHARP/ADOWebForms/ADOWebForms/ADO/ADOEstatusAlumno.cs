using ADOWebForms.ADO;
using ADOWebForms.Entidades;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOWebForm.ADO
{

    internal class ADOEstatusAlumno : ICRUD
    {
        string _cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string _query;
        SqlCommand comando;
   
        public void Actualizar(EstatusAlumno estatusAlumno)
        {
            _query = $"update EstatusAlumnos set clave='{estatusAlumno.Clave}',nombre='{estatusAlumno.Nombre}' where id={estatusAlumno.Id}";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.Parameters.AddWithValue("@clave", estatusAlumno.Clave);
                comando.Parameters.AddWithValue("@nombre", estatusAlumno.Nombre);
                comando.Parameters.AddWithValue("@id", estatusAlumno.Id);
                con.Open();

                int registroActualizado = comando.ExecuteNonQuery();
                if (registroActualizado > 0)
                {
                    Console.WriteLine("Registro insertado correctamente");
                }
                else
                {
                    Console.WriteLine("Error al insertar registro");
                }
                con.Close();
            }
        }

        public int Agregar(EstatusAlumno estatusAlumno)
        {
            _query = $"insert into EstatusAlumnos(clave,nombre) Values('{estatusAlumno.Clave}','{estatusAlumno.Nombre}')";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                con.Open();

                int registroInsertado = comando.ExecuteNonQuery();
                if (registroInsertado > 0)
                {
                    Console.WriteLine("Registro insertado correctamente");
                }
                else if (registroInsertado < 1)
                {
                    Console.WriteLine("Error al insertar registro");
                }
                con.Close();
            }
            return estatusAlumno.Id;
        }

        public EstatusAlumno Consultar(int id)
        {
            EstatusAlumno oEstatus = new EstatusAlumno();
            try
            {
                using (SqlConnection con = new SqlConnection(_cnnString))
                {
                    _query = $"select id,clave,nombre from EstatusAlumnos where id={id}";
                    comando = new SqlCommand(_query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Read();

                    oEstatus.Id = Convert.ToInt32(reader["id"]);
                    oEstatus.Clave = reader["clave"].ToString();
                    oEstatus.Nombre = reader["nombre"].ToString();
                    con.Close();
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error porque algo{ex}");
            }
            return oEstatus;
        }



        public List<EstatusAlumno> ConsultarT()
        {
            List<EstatusAlumno> list = new List<EstatusAlumno>();
            _query = $"select id,clave,nombre from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(
                        new EstatusAlumno()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Clave = reader["clave"].ToString(),
                            Nombre = reader["nombre"].ToString()
                        });
                };
                con.Close();
            }
            return list;
        }

        public void Eliminar(int id)
        {
            EstatusAlumno estatus = new EstatusAlumno();
            _query = $"delete from dbo.EstatusAlumnos where id={id}";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {

                comando = new SqlCommand(_query, con);


                con.Open();

                int registroEliminado = comando.ExecuteNonQuery();
                if (registroEliminado > 0)
                {

                    Console.WriteLine("Registro eliminado correctamente");
                }
                else
                {
                    Console.WriteLine("Error al intentar eliminar registro");
                }
                con.Close();
            }
        }

    }
}



