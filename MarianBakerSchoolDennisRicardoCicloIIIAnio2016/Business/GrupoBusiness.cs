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
    public class GrupoBusiness
    {
        GrupoData grupoData;

        public GrupoBusiness(string connectionString)
        {
            this.grupoData = new GrupoData(connectionString);
        }

        public LinkedList<Grupo> ObtenerGrupos()
        {
            try
            {
                return this.grupoData.ObtenerGrupos();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Grupo ObtenerGrupo(string codigoGrupo)
        {
            try
            {
                return this.grupoData.ObtenerGrupo(codigoGrupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarGrupo(Grupo grupo)
        {
            try
            {
                this.grupoData.InsertarGrupo(grupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarGrupo(Grupo grupo)
        {
            try
            {
                this.grupoData.ActualizarGrupo(grupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarGrupo(string codigoGrupo)
        {
            try
            {
                this.grupoData.EliminarGrupo(grupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public string GenerarCodigoGrupo()
        {
            try
            {
                return this.grupoData.GenerarCodigoGrupo();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool TieneEstudiantes(string codigoGrupo)
        {
            try
            {
                return this.grupoData.TieneEstudiantes(codigoGrupo);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
