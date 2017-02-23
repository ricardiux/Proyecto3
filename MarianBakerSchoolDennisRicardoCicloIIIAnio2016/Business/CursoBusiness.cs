using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CursoBusiness
    {

        CursoData cursoData;
        public CursoBusiness(string connectionString)
        {
            this.cursoData = new CursoData(connectionString);
        }

        public LinkedList<Curso> ObtenerCursos()
        {
            try
            {
                return this.cursoData.ObtenerCursos();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Curso ObtenerCurso(string codigoCurso)
        {
            try
            {
                return this.cursoData.ObtenerCurso(codigoCurso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }            
        }

        public void InsertarCurso(Curso curso)
        {
            try
            {
                this.cursoData.InsertarCurso(curso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarCurso(Curso curso)
        {
            try
            {
                this.cursoData.ActualizarCurso(curso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarCurso(string codigoCurso)
        {
            try
            {
                this.cursoData.EliminarCurso(codigoCurso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public string GenerarCodigoCurso()
        {
            try
            {
                return this.cursoData.GenerarCodigoCurso();
            }
            catch (SqlException ex)
            {
                throw ex;
            }            
        }

        public void AsignarCursoAlGrupo(string codigoCurso, string codigoGrupo)
        {
            try
            {
                this.cursoData.AsignarCursoAlGrupo(codigoCurso, codigoGrupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
