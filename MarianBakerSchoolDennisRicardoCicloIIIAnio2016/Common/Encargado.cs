using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Encargado
    {
        private string cedula;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private int telefono;
        private string correo;
        private string direccion;
        private string usuario;
        private string clave;
        private LinkedList<Estudiante> listaEstudiantes;

        public Encargado()
        {
            this.listaEstudiantes = new LinkedList<Estudiante>();
        }

        public Encargado(string cedula, string nombre, string primerApellido, string segundoApellido, int telefono, string correo, string direccion, string usuario, string clave, LinkedList<Estudiante> listaEstudiantes)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.usuario = usuario;
            this.clave = clave;
            this.ListaEstudiantes = listaEstudiantes;
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

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public LinkedList<Estudiante> ListaEstudiantes
        {
            get
            {
                return listaEstudiantes;
            }

            set
            {
                listaEstudiantes = value;
            }
        }
    }
}
