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
    public class EncargadoBusiness
    {
        EncargadoData encargadoData;

        public EncargadoBusiness(string connectionString)
        {
            this.encargadoData = new EncargadoData(connectionString);
        }

        public LinkedList<Encargado> ObtenerEncargados()
        {
            try
            {
                return this.encargadoData.ObtenerEncargados();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Encargado ObtenerEncargado(string cedulaEncargado)
        {
            try
            {
                return this.encargadoData.ObtenerEncargado(cedulaEncargado);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void InsertarEncargado(Encargado encargado)
        {
            try
            {
                this.encargadoData.InsertarEncargado(encargado);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarEncargado(Encargado encargado)
        {
            try
            {
                this.encargadoData.ActualizarEncargado(encargado);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarEncargado(string cedula)
        {
            try
            {
                this.encargadoData.EliminarEncargado(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool TieneEstudiantes(string cedula)
        {
            try
            {
                return this.encargadoData.TieneEstudiantes(cedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
