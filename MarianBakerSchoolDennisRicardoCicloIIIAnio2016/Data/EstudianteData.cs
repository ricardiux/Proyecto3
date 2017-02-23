using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EstudianteData
    {
        private string connectionString;

        public EstudianteData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public LinkedList<Estudiante> ObtenerEstudiantes()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerEstudiantes = "sp_obtener_estudiantes";
            SqlCommand comandoObtenerEstudiantes = new SqlCommand(sqlProcedureObtenerEstudiantes, connection);
            comandoObtenerEstudiantes.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerEstudiantes.ExecuteReader();
                LinkedList<Estudiante> listaEstudiantes = new LinkedList<Estudiante>();
                while (dataReader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.Cedula = dataReader["cedula"].ToString();
                    estudiante.Encargado.Cedula = dataReader["cedulaEncargado"].ToString();
                    estudiante.Nombre = dataReader["nombre"].ToString();
                    estudiante.PrimerApellido = dataReader["primerApellido"].ToString();
                    estudiante.SegundoApellido = dataReader["segundoApellido"].ToString();

                    listaEstudiantes.AddLast(estudiante);
                }
                connection.Close();
                return listaEstudiantes;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }

        public Estudiante ObtenerEstudiante(string cedula)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerEstudiante = "sp_obtener_estudiante";
            SqlCommand comandoObtenerEstudiante = new SqlCommand(sqlProcedureObtenerEstudiante, connection);
            comandoObtenerEstudiante.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerEstudiante.Parameters.Add(new SqlParameter("@cedula", cedula));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerEstudiante.ExecuteReader();
                Estudiante estudiante = new Estudiante();
                while (dataReader.Read())
                {
                    estudiante.Cedula = dataReader["cedula"].ToString();
                    estudiante.Encargado.Cedula = dataReader["cedulaEncargado"].ToString();
                    estudiante.Nombre = dataReader["nombre"].ToString();
                    estudiante.PrimerApellido = dataReader["primerApellido"].ToString();
                    estudiante.SegundoApellido = dataReader["segundoApellido"].ToString();
                }
                connection.Close();
                return estudiante;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertarEstudiante(Estudiante estudiante)
        {
            string slqProcedureInsertarEstudiante = "sp_insertar_estudiante";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdInsertarEstudiante = new SqlCommand(slqProcedureInsertarEstudiante, conexion);
            cmdInsertarEstudiante.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarEstudiante.Parameters.Add(new SqlParameter("@cedula", estudiante.Cedula));
            cmdInsertarEstudiante.Parameters.Add(new SqlParameter("@cedulaEncargado", estudiante.Encargado.Cedula));
            cmdInsertarEstudiante.Parameters.Add(new SqlParameter("@nombre", estudiante.Nombre));
            cmdInsertarEstudiante.Parameters.Add(new SqlParameter("@primerApellido", estudiante.PrimerApellido));
            cmdInsertarEstudiante.Parameters.Add(new SqlParameter("@segundoApellido", estudiante.SegundoApellido));
            try
            {
                conexion.Open();
                cmdInsertarEstudiante.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            string slqProcedureActualizarEstudiante = "sp_actualizar_estudiante";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdActualizarEstudiante = new SqlCommand(slqProcedureActualizarEstudiante, conexion);
            cmdActualizarEstudiante.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarEstudiante.Parameters.Add(new SqlParameter("@cedula", estudiante.Cedula));
            cmdActualizarEstudiante.Parameters.Add(new SqlParameter("@nombre", estudiante.Nombre));
            cmdActualizarEstudiante.Parameters.Add(new SqlParameter("@primerApellido", estudiante.PrimerApellido));
            cmdActualizarEstudiante.Parameters.Add(new SqlParameter("@segundoApellido", estudiante.SegundoApellido));
            try
            {
                conexion.Open();
                cmdActualizarEstudiante.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarEstudiante(string cedula)
        {
            string slqProcedureEliminarEstudiante = "sp_eliminar_estudiante";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdEliminarEstudiante = new SqlCommand(slqProcedureEliminarEstudiante, conexion);
            cmdEliminarEstudiante.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarEstudiante.Parameters.Add(new SqlParameter("@cedula", cedula));
            try
            {
                conexion.Open();
                cmdEliminarEstudiante.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }//Eliminar Estudiante

        public void AsignarEncargadoAlEstudiante(string cedulaEncargado, string cedulaEstudiante)
        {
            string slqProcedureAsignarEncargado = "asignar_encargado_a_estudiante";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdAsignarEncargado = new SqlCommand(slqProcedureAsignarEncargado, conexion);
            cmdAsignarEncargado.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los parametros 
            cmdAsignarEncargado.Parameters.Add(new SqlParameter("@cedulaEncargado", cedulaEncargado));
            cmdAsignarEncargado.Parameters.Add(new SqlParameter("@cedulaEstudiante", cedulaEstudiante));
            try
            {
                conexion.Open();
                cmdAsignarEncargado.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }//AsignarEncargado
        }
    }
}
