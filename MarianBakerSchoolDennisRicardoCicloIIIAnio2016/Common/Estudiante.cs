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
        private string cedulaEncargado;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;

        public Estudiante(string cedula, string cedulaEncargado, string nombre, string primerApellido, string segundoApellido)
        {
            this.cedula = cedula;
            this.cedulaEncargado = cedulaEncargado;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
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

        public string CedulaEncargado
        {
            get
            {
                return cedulaEncargado;
            }

            set
            {
                cedulaEncargado = value;
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
    }
}
