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
    public class DocenteData
    {

        private string stringConexion;

        public DocenteData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public LinkedList<Especialidad> ObtenerEspecialidades()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerEspecialidades = "sp_obtener_especialidades";
            SqlCommand comandoObtenerEspecialidades = new SqlCommand(sqlProcedureObtenerEspecialidades, connection);
            comandoObtenerEspecialidades.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerEspecialidades.ExecuteReader();
                LinkedList<Especialidad> listaEspecialidades = new LinkedList<Especialidad>();
                while (dataReader.Read())
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.Codigo = dataReader["codigo"].ToString();
                    especialidad.Descripcion = dataReader["descripcion"].ToString();

                    listaEspecialidades.AddLast(especialidad);
                }
                connection.Close();
                return listaEspecialidades;
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

        public LinkedList<Docente> ObtenerDocentes()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerDocentes = "sp_obtener_docentes";
            SqlCommand comandoObtenerDocentes = new SqlCommand(sqlProcedureObtenerDocentes, connection);
            comandoObtenerDocentes.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterDocentes;
            DataSet dataSetDocentes;
            try
            {
                connection.Open();
                dataAdapterDocentes = new SqlDataAdapter();
                dataSetDocentes = new DataSet();
                dataAdapterDocentes.SelectCommand = comandoObtenerDocentes;
                dataAdapterDocentes.Fill(dataSetDocentes, "Docente");
                LinkedList<Docente> listaDocentes = new LinkedList<Docente>();
                Docente docente;

                string sqlProcedureObtenerEspecialidades = "sp_buscar_especialidad_docente";
                SqlCommand comandoObtenerEspecialidades;
                LinkedList<Especialidad> listaEspecialidades;
                Especialidad especialidad;
                SqlDataAdapter dataAdapterEspecialidades;
                DataSet dataSetEspecialidades;

                foreach (DataRow fila in dataSetDocentes.Tables["Docente"].Rows)
                {
                    docente = new Docente();
                    docente.Cedula = fila["cedula"].ToString();
                    docente.Nombre = fila["nombre"].ToString();
                    docente.PrimerApellido = fila["primerApellido"].ToString();
                    docente.SegundoApellido = fila["segundoApellido"].ToString();
                    docente.Telefono = Int32.Parse(fila["telefono"].ToString());
                    docente.Correo = fila["correo"].ToString();
                    docente.Direccion = fila["direccion"].ToString();

                    //especialidades del docente
                    comandoObtenerEspecialidades = new SqlCommand(sqlProcedureObtenerEspecialidades, connection);
                    comandoObtenerEspecialidades.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerEspecialidades.Parameters.Add(new SqlParameter("@cedula", docente.Cedula));

                    dataSetEspecialidades = new DataSet();
                    dataAdapterEspecialidades = new SqlDataAdapter();
                    dataAdapterEspecialidades.SelectCommand = comandoObtenerEspecialidades;
                    dataAdapterEspecialidades.Fill(dataSetEspecialidades, "Especialidad");

                    listaEspecialidades = new LinkedList<Especialidad>();

                    foreach (DataRow filaEsp in dataSetEspecialidades.Tables["Especialidad"].Rows)
                    {
                        especialidad = new Especialidad();
                        especialidad.Codigo = filaEsp["codigo"].ToString();
                        especialidad.Descripcion = filaEsp["descripcion"].ToString();
                        listaEspecialidades.AddLast(especialidad);
                    }
                    docente.ListaEspecialidades = listaEspecialidades;
                    listaDocentes.AddLast(docente);
                }
                connection.Close();
                return listaDocentes;
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

        public Docente ObtenerDocente(string cedula)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerDocentes = "sp_obtener_docente";
            SqlCommand comandoObtenerDocentes = new SqlCommand(sqlProcedureObtenerDocentes, connection);
            comandoObtenerDocentes.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDocentes.Parameters.Add(new SqlParameter("@cedula", cedula));
            SqlDataAdapter dataAdapterDocentes;
            DataSet dataSetDocentes;
            try
            {
                connection.Open();
                dataAdapterDocentes = new SqlDataAdapter();
                dataSetDocentes = new DataSet();
                dataAdapterDocentes.SelectCommand = comandoObtenerDocentes;
                dataAdapterDocentes.Fill(dataSetDocentes, "Docente");
                Docente docente = new Docente();

                string sqlProcedureObtenerEspecialidades = "sp_buscar_especialidad_docente";
                SqlCommand comandoObtenerEspecialidades;
                LinkedList<Especialidad> listaEspecialidades;
                Especialidad especialidad;
                SqlDataAdapter dataAdapterEspecialidades;
                DataSet dataSetEspecialidades;

                foreach (DataRow fila in dataSetDocentes.Tables["Docente"].Rows)
                {
                    docente.Cedula = fila["cedula"].ToString();
                    docente.Nombre = fila["nombre"].ToString();
                    docente.PrimerApellido = fila["primerApellido"].ToString();
                    docente.SegundoApellido = fila["segundoApellido"].ToString();
                    docente.Telefono = Int32.Parse(fila["telefono"].ToString());
                    docente.Correo = fila["correo"].ToString();
                    docente.Direccion = fila["direccion"].ToString();

                    //especialidades del docente
                    comandoObtenerEspecialidades = new SqlCommand(sqlProcedureObtenerEspecialidades, connection);
                    comandoObtenerEspecialidades.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerEspecialidades.Parameters.Add(new SqlParameter("@cedula", docente.Cedula));

                    dataSetEspecialidades = new DataSet();
                    dataAdapterEspecialidades = new SqlDataAdapter();
                    dataAdapterEspecialidades.SelectCommand = comandoObtenerEspecialidades;
                    dataAdapterEspecialidades.Fill(dataSetEspecialidades, "Especialidad");

                    listaEspecialidades = new LinkedList<Especialidad>();

                    foreach (DataRow filaEsp in dataSetEspecialidades.Tables["Especialidad"].Rows)
                    {
                        especialidad = new Especialidad();
                        especialidad.Codigo = filaEsp["codigo"].ToString();
                        especialidad.Descripcion = filaEsp["descripcion"].ToString();
                        listaEspecialidades.AddLast(especialidad);
                    }
                    docente.ListaEspecialidades = listaEspecialidades;
                }
                connection.Close();
                return docente;
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

        public void InsertarDocente(Docente docente)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            //Para insertar Docente
            string slqProcedureInsertarDocente = "sp_insertar_docente";
            SqlCommand cmdInsertarDocente = new SqlCommand(slqProcedureInsertarDocente, conexion);
            cmdInsertarDocente.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los parametros del docente
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@cedula", docente.Cedula));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@nombre", docente.Nombre));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@primerApellido", docente.PrimerApellido));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@segundoApellido", docente.SegundoApellido));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@telefono", docente.Telefono));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@correo", docente.Correo));
            cmdInsertarDocente.Parameters.Add(new SqlParameter("@direccion", docente.Direccion));

            //Para insertar sus Especialidades
            string slqProcedureInsertarEspecialidad = "sp_insertar_especialidad";
            SqlCommand cmdInsertarEspecialidad;

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            try
            {

                cmdInsertarDocente.Transaction = transaccion;
                cmdInsertarDocente.ExecuteNonQuery();
                foreach (Especialidad especialidad in docente.ListaEspecialidades)
                {
                    cmdInsertarEspecialidad = new SqlCommand(slqProcedureInsertarEspecialidad, conexion);
                    cmdInsertarEspecialidad.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarEspecialidad.Transaction = transaccion;
                    //agregar los parámetros de las especialidades
                    cmdInsertarEspecialidad.Parameters.Add(new SqlParameter("@codigo", especialidad.Codigo));
                    cmdInsertarEspecialidad.Parameters.Add(new SqlParameter("@cedula", docente.Cedula));
                    cmdInsertarEspecialidad.Parameters.Add(new SqlParameter("@descripcion", especialidad.Descripcion));
                    cmdInsertarEspecialidad.ExecuteNonQuery();
                }
                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarDocente(Docente docente)
        {
            string slqProcedureActualizarDocente = "sp_actualizar_docente";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarDocente = new SqlCommand(slqProcedureActualizarDocente, conexion);
            cmdActualizarDocente.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarDocente.Parameters.Add(new SqlParameter("@cedula", docente.Cedula));
            cmdActualizarDocente.Parameters.Add(new SqlParameter("@telefono", docente.Telefono));
            cmdActualizarDocente.Parameters.Add(new SqlParameter("@correo", docente.Correo));
            cmdActualizarDocente.Parameters.Add(new SqlParameter("@direccion", docente.Direccion));
            try
            {
                conexion.Open();
                cmdActualizarDocente.ExecuteNonQuery();
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

        public void EliminarDocente(string cedula)
        {
            //para eliminar docente
            SqlConnection conexion = new SqlConnection(stringConexion);
            string slqProcedureEliminarDocente = "sp_eliminar_docente";
            SqlCommand cmdEliminarDocente = new SqlCommand(slqProcedureEliminarDocente, conexion);
            cmdEliminarDocente.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarDocente.Parameters.Add(new SqlParameter("@cedula", cedula));
            //Primero eliminamos todas las especialidades de docente
            string slqProcedureEliminarEspecialidad = "sp_eliminar_especialidades_profesor";
            SqlCommand cmdEliminarEspecialidad = new SqlCommand(slqProcedureEliminarEspecialidad, conexion);
            cmdEliminarEspecialidad.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarEspecialidad.Parameters.Add(new SqlParameter("@cedula", cedula));

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            cmdEliminarEspecialidad.Transaction = transaccion;
            cmdEliminarDocente.Transaction = transaccion;
            try
            {
                cmdEliminarEspecialidad.ExecuteNonQuery();
                cmdEliminarDocente.ExecuteNonQuery();

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

        public string GenerarCodigoEspecialidad()
        {
            //obtenemos el último código
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerEspecialidad = "sp_obtener_ultima_especialidad";
            SqlCommand comandoObtenerEspecialidad = new SqlCommand(sqlProcedureObtenerEspecialidad, connection);
            comandoObtenerEspecialidad.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerEspecialidad.ExecuteReader();
                string codigo = "";
                LinkedList<Curso> listaCursos = new LinkedList<Curso>();
                while (dataReader.Read())
                {
                    codigo = dataReader["codigo"].ToString();
                }
                if (codigo != "")
                {
                    //ahora lo manipulamos para generar el siguiente
                    int numero = Int32.Parse(codigo.Remove(0, 4));
                    numero++;
                    codigo = "ESP-" + numero;
                }
                else
                {
                    codigo = "ESP-1";
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

        public bool TieneCursos(string cedula)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerEspecialidades = "sp_buscar_especialidad_docente";
            SqlCommand comandoObtenerEspecialidades = new SqlCommand(sqlProcedureObtenerEspecialidades, connection);
            comandoObtenerEspecialidades.Parameters.Add(new SqlParameter("@cedula", cedula));
            comandoObtenerEspecialidades.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReaderEspecialidades = comandoObtenerEspecialidades.ExecuteReader();
                int cantidadCursos = 0;
                while (dataReaderEspecialidades.Read())
                {
                    cantidadCursos++;
                }
                if (cantidadCursos > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }//TieneCursos

        public void InsertarEspecialidad(Especialidad especialidad)
        {
            string slqProcedureInsertarEspecialidad = "sp_insertar_especialidad";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdInsertarEspecialidad = new SqlCommand(slqProcedureInsertarEspecialidad, conexion);
            cmdInsertarEspecialidad.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los parametros 
            cmdInsertarEspecialidad.Parameters.Add(new SqlParameter("@codigo", especialidad.Codigo));
            cmdInsertarEspecialidad.Parameters.Add(new SqlParameter("@descripcion", especialidad.Descripcion));
            try
            {
                conexion.Open();
                cmdInsertarEspecialidad.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }//AsignarEspecialidad
        }

        public void AsignarEspecialidadAlDocente(string codigoEspecialidad, string cedulaDocente)
        {
            string slqProcedureAsignarEspecialidad = "asignar_docente_a_especialidad";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdAsignarEspecialidad = new SqlCommand(slqProcedureAsignarEspecialidad, conexion);
            cmdAsignarEspecialidad.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los parametros 
            cmdAsignarEspecialidad.Parameters.Add(new SqlParameter("@cedulaDocente", cedulaDocente));
            cmdAsignarEspecialidad.Parameters.Add(new SqlParameter("@codigoEspecialidad", codigoEspecialidad));
            try
            {
                conexion.Open();
                cmdAsignarEspecialidad.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }//AsignarEspecialidad

        public void AsignarCursoAlDocente(string codigoCurso, string cedulaDocente)
        {
            string slqProcedureAsignarCurso = "asignar_docente_a_curso";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdAsignarCurso = new SqlCommand(slqProcedureAsignarCurso, conexion);
            cmdAsignarCurso.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los parametros 
            cmdAsignarCurso.Parameters.Add(new SqlParameter("@cedulaDocente", cedulaDocente));
            cmdAsignarCurso.Parameters.Add(new SqlParameter("@codigoCurso", codigoCurso));
            try
            {
                conexion.Open();
                cmdAsignarCurso.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }//AsignarCurso
        }
    }
}
