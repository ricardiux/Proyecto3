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
    public class EstudianteBusiness
    {
        EstudianteData estudianteData;

        public EstudianteBusiness(string connectionString)
        {
            this.estudianteData = new EstudianteData(connectionString);
        }

        public LinkedList<Estudiante> ObtenerEstudiantes()
        {
            try
            {
                return this.estudianteData.ObtenerEstudiantes();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Estudiante ObtenerEstudiante(string cedula)
        {
            try
            {
                return this.estudianteData.ObtenerEstudiante(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarEstudiante(Estudiante estudiante)
        {
            try
            {
                this.estudianteData.InsertarEstudiante(estudiante);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            try
            {
                this.estudianteData.ActualizarEstudiante(estudiante);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarEstudiante(string cedula)
        {
            try
            {
                this.estudianteData.EliminarEstudiante(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void AsignarEncargadoAlEstudiante(string cedulaEncargado, string cedulaEstudiante)
        {
            try
            {
                this.estudianteData.AsignarEncargadoAlEstudiante(cedulaEncargado, cedulaEstudiante);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool TieneMatricula(string cedula)
        {
            try
            {
                return this.estudianteData.TieneMatricula(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
