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
        private string cedulaDocente;
        private string descripcion;

        public Especialidad(string codigo, string cedulaDocente, string descripcion)
        {
            this.codigo = codigo;
            this.cedulaDocente = cedulaDocente;
            this.descripcion = descripcion;
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
    }
}
