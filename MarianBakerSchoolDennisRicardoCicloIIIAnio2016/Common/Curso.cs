
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
        private string cedulaDocente;

        public Curso(string codigo, string nombre, string cedulaDocente)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cedulaDocente = cedulaDocente;
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

        public string CedulaDocente
        {
            get
            {
                return cedulaDocente;
            }

            set
            {
                cedulaDocente = value;
            }
        }
    }
}
