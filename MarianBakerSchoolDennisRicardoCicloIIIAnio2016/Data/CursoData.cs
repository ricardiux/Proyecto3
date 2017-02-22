using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CursoData
    {
        private string stringConexion;

        public CursoData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public LinkedList<Curso> ObtenerCursos()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerCursos = "sp_obtener_cursos";
            SqlCommand comandoObtenerCursos = new SqlCommand(sqlProcedureObtenerCursos, connection);
            comandoObtenerCursos.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReader = comandoObtenerCursos.ExecuteReader();
            LinkedList<Curso> listaCursos = new LinkedList<Curso>();
            while (dataReader.Read())
            {
                Curso curso = new Curso();
                curso.Codigo = dataReader["codigo"].ToString();
                curso.Nombre = dataReader["nombreCurso"].ToString();
                curso.Docente.Cedula = dataReader["cedulaDocente"].ToString();
                curso.Docente.Nombre = dataReader["nombreDocente"].ToString();
                curso.Docente.PrimerApellido = dataReader["primerApellido"].ToString();

                listaCursos.AddLast(curso);
            }
            connection.Close();
            if (listaCursos.Count == 0)
            {
                return null;
            }
            return listaCursos;
        }

        public Curso ObtenerCurso(string codigoCurso)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerCurso = "sp_obtener_curso";
            SqlCommand comandoObtenerCurso = new SqlCommand(sqlProcedureObtenerCurso, connection);
            comandoObtenerCurso.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerCurso.Parameters.Add(new SqlParameter("@codigo", codigoCurso));
            connection.Open();
            SqlDataReader dataReader = comandoObtenerCurso.ExecuteReader();
            Curso curso = new Curso();
            while (dataReader.Read())
            {
                curso.Codigo = dataReader["codigo"].ToString();
                curso.Nombre = dataReader["nombreCurso"].ToString();
                curso.Docente.Cedula = dataReader["cedulaDocente"].ToString();
                curso.Docente.Nombre = dataReader["nombreDocente"].ToString();
                curso.Docente.PrimerApellido = dataReader["primerApellido"].ToString();
            }
            connection.Close();
            if (curso.Codigo == "")
            {
                return null;
            }
            return curso;
        }

        public void InsertarCurso(Curso curso)
        {
            string slqProcedureInsertarCurso = "sp_insertar_curso";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdInsertarCurso = new SqlCommand(slqProcedureInsertarCurso, conexion);
            cmdInsertarCurso.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@codigo", curso.Codigo));
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@nombre", curso.Nombre));
            cmdInsertarCurso.Parameters.Add(new SqlParameter("@cedulaDocente", curso.Docente.Cedula));
            conexion.Open();
            try
            {
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

        public void ActualizarCurso(Curso curso)
        {
            string slqProcedureActualizarCurso = "sp_actualizar_curso";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarCurso = new SqlCommand(slqProcedureActualizarCurso, conexion);
            cmdActualizarCurso.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarCurso.Parameters.Add(new SqlParameter("@codigo", curso.Codigo));
            cmdActualizarCurso.Parameters.Add(new SqlParameter("@nombre", curso.Nombre));
            cmdActualizarCurso.Parameters.Add(new SqlParameter("@cedulaDocente", curso.Docente.Cedula));
            conexion.Open();
            try
            {
                cmdActualizarCurso.ExecuteNonQuery();
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

        public void EliminarCurso(string codigoCurso)
        {
            string slqProcedureEliminarCurso = "sp_eliminar_curso";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdEliminarCurso = new SqlCommand(slqProcedureEliminarCurso, conexion);
            cmdEliminarCurso.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarCurso.Parameters.Add(new SqlParameter("@codigo", codigoCurso));
            conexion.Open();
            try
            {
                cmdEliminarCurso.ExecuteNonQuery();
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

        public string GenerarCodigoCurso()
        {
            //obtenemos el último código
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerCurso = "sp_obtener_ultimo_curso";
            SqlCommand comandoObtenerCurso = new SqlCommand(sqlProcedureObtenerCurso, connection);
            comandoObtenerCurso.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReader = comandoObtenerCurso.ExecuteReader();
            string codigo = "";

            LinkedList<Curso> listaCursos = new LinkedList<Curso>();
            while (dataReader.Read())
            {
                codigo = dataReader["codigo"].ToString();
            }
            if (codigo != "")
            {
                //ahora lo manipulamos para generar el siguiente
                int numero = Int32.Parse(codigo.Remove(0, 6));
                numero++;
                codigo = "CURSO-" + numero;
            }
            else
            {
                codigo = "CURSO-1";
            }
            connection.Close();
            return codigo;
        }
    }
}
