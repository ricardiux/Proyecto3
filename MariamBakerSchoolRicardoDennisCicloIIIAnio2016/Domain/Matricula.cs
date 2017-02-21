using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Matricula
    {
        private string cedulaEstudiante;
        private string codigoGrupo;
        private DateTime fechaPago;

        public Matricula(string cedulaEstudiante, string codigoGrupo, DateTime fechaPago)
        {
            this.cedulaEstudiante = cedulaEstudiante;
            this.codigoGrupo = codigoGrupo;
            this.fechaPago = fechaPago;
        }

        public string CedulaEstudiante
        {
            get
            {
                return cedulaEstudiante;
            }

            set
            {
                cedulaEstudiante = value;
            }
        }

        public string CodigoGrupo
        {
            get
            {
                return codigoGrupo;
            }

            set
            {
                codigoGrupo = value;
            }
        }

        public DateTime FechaPago
        {
            get
            {
                return fechaPago;
            }

            set
            {
                fechaPago = value;
            }
        }
    }
}
