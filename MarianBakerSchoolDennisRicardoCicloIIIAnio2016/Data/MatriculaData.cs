using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MatriculaData
    {
        private string connectionString;

        public MatriculaData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public LinkedList<Matricula> ObtenerMatriculas()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerMatriculas = "sp_obtener_matriculas";
            SqlCommand comandoObtenerMatriculas = new SqlCommand(sqlProcedureObtenerMatriculas, connection);
            comandoObtenerMatriculas.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerMatriculas.ExecuteReader();
                LinkedList<Matricula> listaMatriculas = new LinkedList<Matricula>();
                while (dataReader.Read())
                {
                    Matricula matricula = new Matricula();
                    matricula.Estudiante.Cedula = dataReader["cedulaEstudiante"].ToString();
                    matricula.Grupo.Codigo = dataReader["codigoGrupo"].ToString();
                    matricula.FechaPago = DateTime.Parse(dataReader["fechaPago"].ToString());

                    listaMatriculas.AddLast(matricula);
                }
                connection.Close();
                return listaMatriculas;
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

        public Matricula ObtenerMatricula(string cedulaEstudiante, string codigoGrupo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerMatricula = "sp_obtener_matricula";
            SqlCommand comandoObtenerMatricula = new SqlCommand(sqlProcedureObtenerMatricula, connection);
            comandoObtenerMatricula.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerMatricula.Parameters.Add(new SqlParameter("@cedulaEstudiante", cedulaEstudiante));
            comandoObtenerMatricula.Parameters.Add(new SqlParameter("@codigoGrupo", codigoGrupo));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerMatricula.ExecuteReader();
                Matricula matricula = new Matricula();
                while (dataReader.Read())
                {
                    matricula.Estudiante.Cedula = dataReader["cedulaEstudiante"].ToString();
                    matricula.Grupo.Codigo = dataReader["codigoGrupo"].ToString();
                    matricula.FechaPago = DateTime.Parse(dataReader["fechaPago"].ToString());
                }
                connection.Close();
                return matricula;
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

        public void InsertarMatricula(Matricula matricula)
        {
            string slqProcedureInsertarCurso = "sp_insertar_Matricula";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdInsertarCurso = new SqlCommand(slqProcedureInsertarCurso, conexion);
            cmdInsertarCurso.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@cedulaEstudiante", matricula.Estudiante.Cedula));
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@codigoGrupo", matricula.Grupo.Codigo));
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@fechaPago", matricula.FechaPago));
            try
            {
                conexion.Open();
                cmdInsertarCurso.ExecuteNonQuery();
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

        public void ActualizarMatricula(Matricula matricula)
        {
            string slqProcedureActualizarMatricula = "sp_actualizar_matricula";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdActualizarMatricula = new SqlCommand(slqProcedureActualizarMatricula, conexion);
            cmdActualizarMatricula.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@cedulaEstudiante", matricula.Estudiante.Cedula));
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@codigoGrupo", matricula.Grupo.Codigo));
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@fechaPago", matricula.FechaPago));
            try
            {
                conexion.Open();
                cmdActualizarMatricula.ExecuteNonQuery();
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

        public void EliminarMatricula(string cedulaEstudiante, string codigoGrupo)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            string slqProcedureEliminarMatricula = "sp_eliminar_matricula";
            SqlCommand cmdEliminarMatricula = new SqlCommand(slqProcedureEliminarMatricula, conexion);
            cmdEliminarMatricula.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarMatricula.Parameters.Add(new SqlParameter("@cedulaEstudiante", cedulaEstudiante));
            cmdEliminarMatricula.Parameters.Add(new SqlParameter("@codigoGrupo", codigoGrupo));

            try
            {
                conexion.Open();
                cmdEliminarMatricula.ExecuteNonQuery();
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
    }
}
