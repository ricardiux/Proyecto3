using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Grupo
    {
        private string codigo;
        private int grado;

        public Grupo(string codigo, int grado)
        {
            this.codigo = codigo;
            this.grado = grado;
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

        public int Grado
        {
            get
            {
                return grado;
            }

            set
            {
                grado = value;
            }
        }
    }
}
