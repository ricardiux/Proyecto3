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
    public class MatriculaBusiness
    {
        MatriculaData matriculaData;

        public MatriculaBusiness(string connectionString)
        {
            this.matriculaData = new MatriculaData(connectionString);
        }

        public LinkedList<Matricula> ObtenerMatriculas()
        {
            try
            {
                return this.matriculaData.ObtenerMatriculas();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Matricula ObtenerMatricula(string cedulaEstudiante, string codigoGrupo)
        {
            try
            {
                return this.matriculaData.ObtenerMatricula(cedulaEstudiante, codigoGrupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarMatricula(Matricula matricula)
        {
            try
            {
                this.matriculaData.InsertarMatricula(matricula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarMatricula(Matricula matricula)
        {
            try
            {
                this.matriculaData.ActualizarMatricula(matricula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarMatricula(string cedulaEstudiante, string codigoGrupo)
        {
            try
            {
                this.matriculaData.EliminarMatricula(cedulaEstudiante, codigoGrupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
