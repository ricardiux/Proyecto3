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
    public class DocenteBusiness
    {
        DocenteData docenteData;

        public DocenteBusiness(string connectionString)
        {
            this.docenteData = new DocenteData(connectionString);
        }

        public LinkedList<Especialidad> ObtenerEspecialidades()
        {
            try
            {
                return this.docenteData.ObtenerEspecialidades();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public LinkedList<Docente> ObtenerDocentes()
        {
            try
            {
                return this.docenteData.ObtenerDocentes();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Docente ObtenerDocente(string cedula)
        {
            try
            {
                return this.docenteData.ObtenerDocente(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarDocente(Docente docente)
        {
            try
            {
                this.docenteData.InsertarDocente(docente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarEspecialidad(Especialidad especialidad)
        {
            try
            {
                this.docenteData.InsertarEspecialidad(especialidad);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarDocente(Docente docente)
        {
            try
            {
                this.docenteData.ActualizarDocente(docente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarDocente(string cedula)
        {
            try
            {
                this.docenteData.EliminarDocente(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public string GenerarCodigoEspecialidad()
        {
            try
            {
                return this.docenteData.GenerarCodigoEspecialidad();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool TieneCursos(string cedula)
        {
            try
            {
                return this.docenteData.TieneCursos(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void AsignarEspecialidadAlDocente(string codigoEspecialidad, string cedulaDocente)
        {
            try
            {
                this.docenteData.AsignarEspecialidadAlDocente(codigoEspecialidad, cedulaDocente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void AsignarCursoAlDocente(string codigoCurso, string cedulaDocente)
        {
            try
            {
                this.docenteData.AsignarCursoAlDocente(codigoCurso, cedulaDocente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
