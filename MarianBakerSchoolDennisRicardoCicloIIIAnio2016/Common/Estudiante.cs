using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Estudiante
    {
        private string cedula;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private Encargado encargado;

        public Estudiante()
        {
            this.encargado = new Encargado();
        }

        public Estudiante(string cedula, string nombre, string primerApellido, string segundoApellido, Encargado encargado)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.Encargado = encargado;
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
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

        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }

            set
            {
                primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }

            set
            {
                segundoApellido = value;
            }
        }

        public Encargado Encargado
        {
            get
            {
                return encargado;
            }

            set
            {
                encargado = value;
            }
        }

        public string NombreApellidos
        {
            get
            {
                return Nombre + " " + PrimerApellido + " " + SegundoApellido;
            }
        }
    }
}
