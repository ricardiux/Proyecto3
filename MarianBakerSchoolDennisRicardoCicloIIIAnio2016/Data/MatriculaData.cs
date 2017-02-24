using Domain;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlDataAdapter dataAdapterMatriculas;
            DataSet dataSetMatriculas;
            try
            {
                connection.Open();
                dataAdapterMatriculas = new SqlDataAdapter();
                dataSetMatriculas = new DataSet();
                dataAdapterMatriculas.SelectCommand = comandoObtenerMatriculas;
                dataAdapterMatriculas.Fill(dataSetMatriculas, "Matricula");
                LinkedList<Matricula> listaMatriculas = new LinkedList<Matricula>();
                Matricula matricula;

                string sqlProcedureObtenerEstudiante = "sp_obtener_estudiante";
                SqlCommand comandoObtenerEstudiante;
                SqlDataAdapter dataAdapterEspecialidades;
                DataSet dataSetEspecialidades;

                foreach (DataRow fila in dataSetMatriculas.Tables["Matricula"].Rows)
                {
                    matricula = new Matricula();
                    matricula.Estudiante.Cedula = fila["cedulaEstudiante"].ToString();
                    matricula.Grupo.Codigo = fila["codigoGrupo"].ToString();
                    matricula.FechaPago = DateTime.Parse(fila["fechaPago"].ToString());
                    matricula.Monto = float.Parse(fila["monto"].ToString());

                    //estudiante de la matricula
                    comandoObtenerEstudiante = new SqlCommand(sqlProcedureObtenerEstudiante, connection);
                    comandoObtenerEstudiante.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerEstudiante.Parameters.Add(new SqlParameter("@cedula", matricula.Estudiante.Cedula));

                    dataSetEspecialidades = new DataSet();
                    dataAdapterEspecialidades = new SqlDataAdapter();
                    dataAdapterEspecialidades.SelectCommand = comandoObtenerEstudiante;
                    dataAdapterEspecialidades.Fill(dataSetEspecialidades, "Estudiante");

                    foreach (DataRow filaEst in dataSetEspecialidades.Tables["Estudiante"].Rows)
                    {
                        matricula.Estudiante.Nombre = filaEst["nombre"].ToString();
                        matricula.Estudiante.PrimerApellido = filaEst["primerApellido"].ToString();
                        matricula.Estudiante.SegundoApellido = filaEst["segundoApellido"].ToString();
                    }
                    
                    listaMatriculas.AddLast(matricula);
                }
                connection.Close();
                return listaMatriculas;
            }
            catch (SqlException ex)
            {
                throw ex;
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
            string slqProcedureInsertarMatricula = "sp_insertar_matricula";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdInsertarMatricula = new SqlCommand(slqProcedureInsertarMatricula, conexion);
            cmdInsertarMatricula.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarMatricula.Parameters.Add(new SqlParameter("@cedulaEstudiante", matricula.Estudiante.Cedula));
            cmdInsertarMatricula.Parameters.Add(new SqlParameter("@codigoGrupo", matricula.Grupo.Codigo));
            cmdInsertarMatricula.Parameters.Add(new SqlParameter("@fechaPago", matricula.FechaPago));
            cmdInsertarMatricula.Parameters.Add(new SqlParameter("@monto", matricula.Monto));
            try
            {
                conexion.Open();
                cmdInsertarMatricula.ExecuteNonQuery();
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

        public void ActualizarFechaMatricula(Matricula matricula)
        {
            string slqProcedureActualizarMatricula = "sp_actualizar_fecha_matricula";
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

        public void ActualizarMontoMatricula(Matricula matricula)
        {
            string slqProcedureActualizarMatricula = "sp_actualizar_monto_matricula";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdActualizarMatricula = new SqlCommand(slqProcedureActualizarMatricula, conexion);
            cmdActualizarMatricula.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@cedulaEstudiante", matricula.Estudiante.Cedula));
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@codigoGrupo", matricula.Grupo.Codigo));
            cmdActualizarMatricula.Parameters.Add(new SqlParameter("@monto", matricula.Monto));
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
