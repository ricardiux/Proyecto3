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
            return listaCursos;
        }
    }
}
