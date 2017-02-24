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
    public class EncargadoData
    {
        string connectionString;

        public EncargadoData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public LinkedList<Encargado> ObtenerEncargados()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerEncargados = "sp_obtener_encargados";
            SqlCommand comandoObtenerEncargados = new SqlCommand(sqlProcedureObtenerEncargados, connection);
            comandoObtenerEncargados.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterEncargados;
            DataSet dataSetEncargados;
            try
            {
                connection.Open();
                dataAdapterEncargados = new SqlDataAdapter();
                dataSetEncargados = new DataSet();
                dataAdapterEncargados.SelectCommand = comandoObtenerEncargados;
                dataAdapterEncargados.Fill(dataSetEncargados, "Encargado");
                LinkedList<Encargado> listaEncargados = new LinkedList<Encargado>();
                Encargado encargado;

                string sqlProcedureObtenerEstudiantes = "sp_buscar_estudiantes_encargado";
                SqlCommand comandoObtenerEstudiantes;
                LinkedList<Estudiante> listaEstudiantes;
                Estudiante estudiante;
                SqlDataAdapter dataAdapterEstudiantes;
                DataSet dataSetEstudiante;

                foreach (DataRow fila in dataSetEncargados.Tables["Encargado"].Rows)
                {
                    encargado = new Encargado();
                    encargado.Cedula = fila["cedula"].ToString();
                    encargado.Nombre = fila["nombre"].ToString();
                    encargado.PrimerApellido = fila["primerApellido"].ToString();
                    encargado.SegundoApellido = fila["segundoApellido"].ToString();
                    encargado.Telefono = Int32.Parse(fila["telefono"].ToString());
                    encargado.Correo = fila["correo"].ToString();
                    encargado.Direccion = fila["direccion"].ToString();
                    encargado.Usuario = fila["usuario"].ToString();
                    encargado.Clave = fila["clave"].ToString();
                    //especialidades del docente
                    comandoObtenerEstudiantes = new SqlCommand(sqlProcedureObtenerEstudiantes, connection);
                    comandoObtenerEstudiantes.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerEstudiantes.Parameters.Add(new SqlParameter("@cedula", encargado.Cedula));

                    dataSetEstudiante = new DataSet();
                    dataAdapterEstudiantes = new SqlDataAdapter();
                    dataAdapterEstudiantes.SelectCommand = comandoObtenerEstudiantes;
                    dataAdapterEstudiantes.Fill(dataSetEstudiante, "Estudiante");

                    listaEstudiantes = new LinkedList<Estudiante>();

                    foreach (DataRow filaEst in dataSetEstudiante.Tables["Estudiante"].Rows)
                    {
                        estudiante = new Estudiante();
                        estudiante.Cedula = filaEst["cedula"].ToString();
                        estudiante.Nombre = filaEst["nombre"].ToString();
                        estudiante.PrimerApellido = filaEst["primerApellido"].ToString();
                        listaEstudiantes.AddLast(estudiante);
                    }
                    encargado.ListaEstudiantes = listaEstudiantes;
                    listaEncargados.AddLast(encargado);
                }
                connection.Close();
                return listaEncargados;
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

        public Encargado ObtenerEncargado(string cedulaEncargado)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerEncargados = "sp_obtener_encargado";
            SqlCommand comandoObtenerEncargados = new SqlCommand(sqlProcedureObtenerEncargados, connection);
            comandoObtenerEncargados.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerEncargados.Parameters.Add(new SqlParameter("@cedula", cedulaEncargado));
            SqlDataAdapter dataAdapterEncargados;
            DataSet dataSetEncargados;
            try
            {
                connection.Open();
                dataAdapterEncargados = new SqlDataAdapter();
                dataSetEncargados = new DataSet();
                dataAdapterEncargados.SelectCommand = comandoObtenerEncargados;
                dataAdapterEncargados.Fill(dataSetEncargados, "Encargado");
                Encargado encargado = new Encargado();

                string sqlProcedureObtenerEstudiantes = "sp_buscar_estudiantes_encargado";
                SqlCommand comandoObtenerEstudiantes;
                LinkedList<Estudiante> listaEstudiantes;
                Estudiante estudiante;
                SqlDataAdapter dataAdapterEstudiantes;
                DataSet dataSetEstudiante;

                foreach (DataRow fila in dataSetEncargados.Tables["Encargado"].Rows)
                {
                    encargado = new Encargado();
                    encargado.Cedula = fila["cedula"].ToString();
                    encargado.Nombre = fila["nombre"].ToString();
                    encargado.PrimerApellido = fila["primerApellido"].ToString();
                    encargado.SegundoApellido = fila["segundoApellido"].ToString();
                    encargado.Telefono = Int32.Parse(fila["telefono"].ToString());
                    encargado.Correo = fila["correo"].ToString();
                    encargado.Direccion = fila["direccion"].ToString();
                    encargado.Usuario = fila["usuario"].ToString();
                    encargado.Clave = fila["clave"].ToString();
                    //especialidades del docente
                    comandoObtenerEstudiantes = new SqlCommand(sqlProcedureObtenerEstudiantes, connection);
                    comandoObtenerEstudiantes.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoObtenerEstudiantes.Parameters.Add(new SqlParameter("@cedula", encargado.Cedula));

                    dataSetEstudiante = new DataSet();
                    dataAdapterEstudiantes = new SqlDataAdapter();
                    dataAdapterEstudiantes.SelectCommand = comandoObtenerEstudiantes;
                    dataAdapterEstudiantes.Fill(dataSetEstudiante, "Estudiante");

                    listaEstudiantes = new LinkedList<Estudiante>();

                    foreach (DataRow filaEst in dataSetEstudiante.Tables["Estudiante"].Rows)
                    {
                        estudiante = new Estudiante();
                        estudiante.Cedula = filaEst["cedula"].ToString();
                        estudiante.Nombre = filaEst["nombre"].ToString();
                        estudiante.PrimerApellido = filaEst["primerApellido"].ToString();
                        listaEstudiantes.AddLast(estudiante);
                    }
                    encargado.ListaEstudiantes = listaEstudiantes;
                }
                connection.Close();
                return encargado;
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

        public void InsertarEncargado(Encargado encargado)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            //Para insertar Docente
            string slqProcedureInsertarEncargado = "sp_insertar_encargado";
            SqlCommand cmdInsertarEncargado = new SqlCommand(slqProcedureInsertarEncargado, conexion);
            cmdInsertarEncargado.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los parametros del docente
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@cedula", encargado.Cedula));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@nombre", encargado.Nombre));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@primerApellido", encargado.PrimerApellido));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@segundoApellido", encargado.SegundoApellido));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@telefono", encargado.Telefono));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@correo", encargado.Correo));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@direccion", encargado.Direccion));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@usuario", encargado.Usuario));
            cmdInsertarEncargado.Parameters.Add(new SqlParameter("@clave", encargado.Clave));

            conexion.Open();
            try
            {
                cmdInsertarEncargado.ExecuteNonQuery();
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

        public void ActualizarEncargado(Encargado encargado)
        {
            string slqProcedureActualizarEncargado = "sp_actualizar_encargado";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdActualizarEncargado = new SqlCommand(slqProcedureActualizarEncargado, conexion);
            cmdActualizarEncargado.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarEncargado.Parameters.Add(new SqlParameter("@cedula", encargado.Cedula));
            cmdActualizarEncargado.Parameters.Add(new SqlParameter("@telefono", encargado.Telefono));
            cmdActualizarEncargado.Parameters.Add(new SqlParameter("@correo", encargado.Correo));
            cmdActualizarEncargado.Parameters.Add(new SqlParameter("@direccion", encargado.Direccion));
            try
            {
                conexion.Open();
                cmdActualizarEncargado.ExecuteNonQuery();
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

        public void EliminarEncargado(string cedula)
        {
            string slqProcedureEliminarEncargado = "sp_eliminar_encargado";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand cmdEliminarEncargado = new SqlCommand(slqProcedureEliminarEncargado, conexion);
            cmdEliminarEncargado.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarEncargado.Parameters.Add(new SqlParameter("@cedula", cedula));
            try
            {
                conexion.Open();
                cmdEliminarEncargado.ExecuteNonQuery();
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

        public bool TieneEstudiantes(string cedula)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerEstudiantes = "sp_buscar_estudiantes_encargado";
            SqlCommand comandoObtenerEspecialidades = new SqlCommand(sqlProcedureObtenerEstudiantes, connection);
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
        }//TieneEstudiantes

    }
}
