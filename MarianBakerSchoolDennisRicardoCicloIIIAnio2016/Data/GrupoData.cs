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
    public class GrupoData
    {
        private string stringConexion;

        public GrupoData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public LinkedList<Grupo> ObtenerGrupos()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerGrupos = "sp_obtener_grupos";
            SqlCommand comandoObtenerGrupos = new SqlCommand(sqlProcedureObtenerGrupos, connection);
            comandoObtenerGrupos.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterGrupos;
            DataSet dataSetGrupos;
            try
            {
                connection.Open();
                dataAdapterGrupos = new SqlDataAdapter();
                dataSetGrupos = new DataSet();
                dataAdapterGrupos.SelectCommand = comandoObtenerGrupos;
                dataAdapterGrupos.Fill(dataSetGrupos, "Grupo");
                LinkedList<Grupo> listaGrupos = new LinkedList<Grupo>();
                Grupo grupo;

                string sqlProcedureObtenerCursos = "sp_buscar_cursos_grupo";
                SqlCommand comandoObtenerCursos;
                LinkedList<Curso> listaCursos;
                Curso curso;
                SqlDataAdapter dataAdapterCursos;
                DataSet dataSetCursos;

                foreach (DataRow fila in dataSetGrupos.Tables["Grupo"].Rows)
                {
                    grupo = new Grupo();
                    grupo.Codigo = fila["codigo"].ToString();
                    grupo.Grado = Int32.Parse(fila["grado"].ToString());

                    //cursos del grupo
                    comandoObtenerCursos = new SqlCommand(sqlProcedureObtenerCursos, connection);
                    comandoObtenerCursos.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerCursos.Parameters.Add(new SqlParameter("@codigoGrupo", grupo.Codigo));

                    dataSetCursos = new DataSet();
                    dataAdapterCursos = new SqlDataAdapter();
                    dataAdapterCursos.SelectCommand = comandoObtenerCursos;
                    dataAdapterCursos.Fill(dataSetCursos, "Curso");

                    listaCursos = new LinkedList<Curso>();

                    foreach (DataRow filaEsp in dataSetCursos.Tables["Curso"].Rows)
                    {
                        curso = new Curso();
                        curso.Codigo = filaEsp["codigoCurso"].ToString();
                        curso.Nombre = filaEsp["nombre"].ToString();
                        listaCursos.AddLast(curso);
                    }
                    grupo.ListaCursos = listaCursos;
                    listaGrupos.AddLast(grupo);
                }
                connection.Close();
                return listaGrupos;
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

        public Grupo ObtenerGrupo(string codigoGrupo)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerGrupos = "sp_obtener_grupo";
            SqlCommand comandoObtenerGrupos = new SqlCommand(sqlProcedureObtenerGrupos, connection);
            comandoObtenerGrupos.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerGrupos.Parameters.Add(new SqlParameter("@codigo", codigoGrupo));
            SqlDataAdapter dataAdapterGrupos;
            DataSet dataSetGrupos;
            try
            {
                connection.Open();
                dataAdapterGrupos = new SqlDataAdapter();
                dataSetGrupos = new DataSet();
                dataAdapterGrupos.SelectCommand = comandoObtenerGrupos;
                dataAdapterGrupos.Fill(dataSetGrupos, "Grupo");
                Grupo grupo = new Grupo();

                string sqlProcedureObtenerCursos = "sp_buscar_cursos_grupo";
                SqlCommand comandoObtenerCursos;
                LinkedList<Curso> listaCursos;
                Curso curso;
                SqlDataAdapter dataAdapterCursos;
                DataSet dataSetCursos;

                foreach (DataRow fila in dataSetGrupos.Tables["Grupo"].Rows)
                {
                    grupo = new Grupo();
                    grupo.Codigo = fila["codigo"].ToString();
                    grupo.Grado = Int32.Parse(fila["grado"].ToString());

                    //cursos del grupo
                    comandoObtenerCursos = new SqlCommand(sqlProcedureObtenerCursos, connection);
                    comandoObtenerCursos.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerCursos.Parameters.Add(new SqlParameter("@codigoGrupo", grupo.Codigo));

                    dataSetCursos = new DataSet();
                    dataAdapterCursos = new SqlDataAdapter();
                    dataAdapterCursos.SelectCommand = comandoObtenerCursos;
                    dataAdapterCursos.Fill(dataSetCursos, "Curso");

                    listaCursos = new LinkedList<Curso>();

                    foreach (DataRow filaEsp in dataSetCursos.Tables["Curso"].Rows)
                    {
                        curso = new Curso();
                        curso.Codigo = filaEsp["codigoCurso"].ToString();
                        curso.Nombre = filaEsp["nombre"].ToString();
                        listaCursos.AddLast(curso);
                    }
                    grupo.ListaCursos = listaCursos;
                }
                connection.Close();
                return grupo;
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

        public void InsertarGrupo(Grupo grupo)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            //Para insertar Grupo
            string slqProcedureInsertarGrupo = "sp_insertar_grupo";
            SqlCommand cmdInsertarGrupo = new SqlCommand(slqProcedureInsertarGrupo, conexion);
            cmdInsertarGrupo.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los parametros del docente
            cmdInsertarGrupo.Parameters.Add(new SqlParameter("@codigo", grupo.Codigo));
            cmdInsertarGrupo.Parameters.Add(new SqlParameter("@grado", grupo.Grado));

            conexion.Open();
            try
            {
                cmdInsertarGrupo.ExecuteNonQuery();

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

        public void ActualizarGrupo(Grupo grupo)
        {
            string slqProcedureActualizarGrupo = "sp_actualizar_grupo";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarGrupo = new SqlCommand(slqProcedureActualizarGrupo, conexion);
            cmdActualizarGrupo.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarGrupo.Parameters.Add(new SqlParameter("@codigo", grupo.Codigo));
            cmdActualizarGrupo.Parameters.Add(new SqlParameter("@grado", grupo.Grado));
            try
            {
                conexion.Open();
                cmdActualizarGrupo.ExecuteNonQuery();
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

        public void EliminarGrupo(string codigoGrupo)
        {
            //para eliminar docente
            SqlConnection conexion = new SqlConnection(stringConexion);
            string slqProcedureEliminarGrupo = "sp_eliminar_grupo";
            SqlCommand cmdEliminarGrupo = new SqlCommand(slqProcedureEliminarGrupo, conexion);
            cmdEliminarGrupo.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarGrupo.Parameters.Add(new SqlParameter("@codigo", codigoGrupo));
            //Primero eliminamos todos los cursos del grupo
            string slqProcedureEliminarCursos = "sp_eliminar_cursos_grupo";
            SqlCommand cmdEliminarCursos = new SqlCommand(slqProcedureEliminarCursos, conexion);
            cmdEliminarCursos.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarCursos.Parameters.Add(new SqlParameter("@codigoGrupo", codigoGrupo));

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            cmdEliminarCursos.Transaction = transaccion;
            cmdEliminarGrupo.Transaction = transaccion;
            try
            {
                cmdEliminarCursos.ExecuteNonQuery();
                cmdEliminarGrupo.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch (SqlException exc)
            {
                transaccion.Rollback();
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }//eliminar docente

        public string GenerarCodigoGrupo()
        {
            //obtenemos el último código
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerGrupo = "sp_obtener_ultimo_grupo";
            SqlCommand comandoObtenerGrupo = new SqlCommand(sqlProcedureObtenerGrupo, connection);
            comandoObtenerGrupo.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerGrupo.ExecuteReader();
                string codigo = "";
                while (dataReader.Read())
                {
                    codigo = dataReader["codigo"].ToString();
                }
                if (codigo != "")
                {
                    //ahora lo manipulamos para generar el siguiente
                    int numero = Int32.Parse(codigo.Remove(0, 6));
                    numero++;
                    codigo = "GRUPO-" + numero;
                }
                else
                {
                    codigo = "GRUPO-1";
                }
                connection.Close();
                return codigo;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }//Generar Codigo

        public bool TieneEstudiantes(string codigoGrupo)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerEstudiantes = "sp_buscar_estudiantes_grupo";
            SqlCommand comandoObtenerEstudiantes = new SqlCommand(sqlProcedureObtenerEstudiantes, connection);
            comandoObtenerEstudiantes.Parameters.Add(new SqlParameter("@codigoGrupo", codigoGrupo));
            comandoObtenerEstudiantes.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReaderEspecialidades = comandoObtenerEstudiantes.ExecuteReader();
            int cantidadEstudiantes = 0;
            while (dataReaderEspecialidades.Read())
            {
                cantidadEstudiantes++;
            }
            if (cantidadEstudiantes > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//TieneEstudiantes

    }
}