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
        private float monto;
        private string codigoMatricula;

        public Matricula()
        {
            this.estudiante = new Estudiante();
            this.grupo = new Grupo();
        }

        public Matricula(string codigoMatricula, Estudiante estudiante, Grupo grupo, DateTime fechaPago, float monto)
        {
            this.codigoMatricula = codigoMatricula;
            this.Estudiante = estudiante;
            this.Grupo = grupo;
            this.fechaPago = fechaPago;
            this.Monto = monto;
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

        public float Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public string CodigoMatricula
        {
            get
            {
                return codigoMatricula;
            }

            set
            {
                codigoMatricula = value;
            }
        }
    }
}
