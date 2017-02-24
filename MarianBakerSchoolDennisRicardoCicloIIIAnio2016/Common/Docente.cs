using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Docente
    {
        private string cedula;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private int telefono;
        private string correo;
        private string direccion;
        private LinkedList<Especialidad> listaEspecialidades;

        public Docente()
        {
            this.listaEspecialidades = new LinkedList<Especialidad>();
        }

        public Docente(string cedula, string nombre, string primerApellido, string segundoApellido, int telefono, string correo, string direccion, LinkedList<Especialidad> listaEspecialidades)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.ListaEspecialidades = listaEspecialidades;
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

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public LinkedList<Especialidad> ListaEspecialidades
        {
            get
            {
                return listaEspecialidades;
            }

            set
            {
                listaEspecialidades = value;
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
