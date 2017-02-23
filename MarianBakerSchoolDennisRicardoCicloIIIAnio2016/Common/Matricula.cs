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
        private Grupo grupo;
        private DateTime fechaPago;

        public Matricula()
        {
            this.estudiante = new Estudiante();
            this.grupo = new Grupo();
        }

        public Matricula(Estudiante estudiante, Grupo grupo, DateTime fechaPago)
        {
            this.Estudiante = estudiante;
            this.Grupo = grupo;
            this.fechaPago = fechaPago;
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

        public Grupo Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }
        }
    }
}
