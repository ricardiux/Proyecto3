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
        private LinkedList<Curso> listaCursos;

        public Grupo()
        {
            this.listaCursos = new LinkedList<Curso>();
        }

        public Grupo(string codigo, int grado, LinkedList<Curso> listaCursos)
        {
            this.codigo = codigo;
            this.grado = grado;
            this.ListaCursos = listaCursos;
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

        public LinkedList<Curso> ListaCursos
        {
            get
            {
                return listaCursos;
            }

            set
            {
                listaCursos = value;
            }
        }
    }
}
