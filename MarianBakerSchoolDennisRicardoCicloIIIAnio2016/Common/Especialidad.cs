using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Especialidad
    {
        private string codigo;
        private string descripcion;
        private Docente docente;

        public Especialidad()
        {
            this.Docente = new Docente();
        }

        public Especialidad(string codigo,string descripcion, Docente docente)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.Docente = docente;
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public Docente Docente
        {
            get
            {
                return docente;
            }

            set
            {
                docente = value;
            }
        }
    }
}
