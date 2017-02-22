using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Matricula
    {
        private Estudiante estudiante;
        private string codigoGrupo;
        private DateTime fechaPago;

        public Matricula()
        {
            this.estudiante = new Estudiante();
        }

        public Matricula(Estudiante estudiante, string codigoGrupo, DateTime fechaPago)
        {
            this.Estudiante = estudiante;
            this.codigoGrupo = codigoGrupo;
            this.fechaPago = fechaPago;
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

        public Estudiante Estudiante
        {
            get
            {
                return estudiante;
            }

            set
            {
                estudiante = value;
            }
        }
    }
}
