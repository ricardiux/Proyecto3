
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Curso
    {
        private string codigo;
        private string nombre;
        private Docente docente;

        public Curso()
        {
            this.docente = new Docente();
        }

        public Curso(string codigo, string nombre, string cedulaDocente, Docente docente)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.docente = docente;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
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
