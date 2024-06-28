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
    public class DAlumno
    {
        string _cnnString = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string _query;
        SqlCommand comando;

        public List<Alumno> Consultar()
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            _query = $"consultarAlumnos2";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaAlumno.Add(new Alumno()
                    {
                        id = Convert.ToInt16(reader["id"]),
                        nombre = reader["nombre"].ToString(),
                        primerApellido = reader["primerApellido"].ToString(),
                        segundoApellido = reader["segundoApellido"].ToString(),
                        correo = reader["correo"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]),
                        curp = reader["curp"].ToString(),
                        sueldoMensual = reader["sueldoMensual"] == DBNull.Value?0: Convert.ToDecimal(reader["sueldoMensual"]),
                        idEstadoOrigen = Convert.ToInt16(reader["idEstadoOrigen"]),
                        idEstatus = Convert.ToInt16(reader["idEstatus"])

                    });
                }
                con.Close();
            }
            return listaAlumno;

        }
        public Alumno Consultar(int id)
        {
            Alumno oAlumno = new Alumno();
            _query = $"consultarAlumnos2";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                oAlumno.id = Convert.ToInt16(reader["id"]);
                oAlumno.nombre = reader["nombre"].ToString();
                oAlumno.primerApellido = reader["primerApellido"].ToString();
                oAlumno.segundoApellido = reader["segundoApellido"].ToString();
                oAlumno.correo = reader["correo"].ToString();
                oAlumno.telefono = reader["telefono"].ToString();
                oAlumno.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                oAlumno.curp = reader["curp"].ToString();
                oAlumno.sueldoMensual = reader["sueldoMensual"]== DBNull.Value ? 0 : Convert.ToDecimal(reader["sueldoMensual"]);
                oAlumno.idEstadoOrigen = Convert.ToInt16(reader["idEstadoOrigen"]);
                oAlumno.idEstatus = Convert.ToInt16(reader["idEstatus"]);
                con.Close();
            }
            return oAlumno;
        }
        public void Agregrar(Alumno alumno)
        {

            _query = $"agregarAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldoMensual", alumno.sueldoMensual);
                comando.Parameters.AddWithValue("@idEstadoOrigen", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Actualizar(Alumno alumno)
        {
            _query = $"actualizarAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", alumno.id);
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldoMensual", alumno.sueldoMensual);
                comando.Parameters.AddWithValue("@idEstadoOrigen", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Eliminar(int id)
        {
            _query = $"EliminarAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        /*Agregar a la Clase DAlumno el método ConsultarTablaISR, la cual 
regresará una LIST<ItemTablaISR> cargándola desde la tabla TablaISR de 
la base de datos*/
        public List<ItemTablaISR> ConsultarTablaISR()
        {
            List<ItemTablaISR> oListTablaISR = new List<ItemTablaISR>();
            _query = $"consultarISR";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(_query, con);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    oListTablaISR.Add(new ItemTablaISR()
                    {
                        LimiteInferior = Convert.ToDecimal(reader["LimInf"]),
                        LimiteSuperior = Convert.ToDecimal(reader["LimSup"]),
                        CuotaFija = Convert.ToDecimal(reader["CuotaFija"]),
                        Excedente = Convert.ToDecimal(reader["ExedLimInf"]),
                        Subsidio = Convert.ToDecimal(reader["Subsidio"]),
                        ISR = 0
                    });
                }
                con.Close();
            }
            return oListTablaISR;
        }
    }
}
