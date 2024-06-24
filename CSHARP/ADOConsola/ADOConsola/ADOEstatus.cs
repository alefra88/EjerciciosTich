using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOConsola
{
    internal class ADOEstatus : ICRUDEstatus
    {
        string _cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string _query;
        SqlCommand comando;
        public List<Estatus> ConsultarT()
        {
            List<Estatus> _ListaEstatus = new List<Estatus>();
            _query = $"select id,clave,nombre from EstatusAlumnos";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _ListaEstatus.Add(
                        new Estatus()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Clave = reader["clave"].ToString(),
                            Nombre = reader["nombre"].ToString()
                        });
                };
                con.Close();
            }
            return _ListaEstatus;
        }
        public Estatus Consultar(int id)
        {
            Estatus oEstatus = new Estatus();
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
        public int Agregar(Estatus estatus)
        {
        
            _query = $"insert into EstatusAlumnos(clave,nombre) Values('{estatus.Clave}','{estatus.Nombre}')";

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
            return estatus.Id;
        }
        public void Actualizar(Estatus estatus)
        {
        
            _query = $"update EstatusAlumnos set clave='{estatus.Clave}',nombre='{estatus.Nombre}' where id={estatus.Id}";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                con.Open();

                int registroActualizado = comando.ExecuteNonQuery();
                if (registroActualizado > 0)
                {
                    Console.WriteLine("Registro insertado correctamente");
                }
                else if (registroActualizado < 1)
                {
                    Console.WriteLine("Error al insertar registro");
                }
                con.Close();
            }
        }
        public void Eliminar(int id)
        {
     
            _query = $"delete from EstatusAlumnos where id=@id";

            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.Parameters.AddWithValue("@id", id);

                con.Open();

                int registroInsertado = comando.ExecuteNonQuery();
                if (registroInsertado < 0)
                {
                    Console.WriteLine("Registro eliminado correctamente");
                }
                else if (registroInsertado > 1)
                {
                    Console.WriteLine("Error al intentar eliminar registro");
                }
                con.Close();
            }
        }
    }
}
