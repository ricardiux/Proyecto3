using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Domain;

namespace Test.Data
{

    [TestClass]
    public class DocenteDataTest
    {
        DocenteData docenteData;
        public DocenteDataTest()
        {
            docenteData = new DocenteData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");
        }

        //[TestMethod]
        //public void ObtenerDocentes()
        //{
        //    LinkedList<Docente> listaDocentes = this.docenteData.ObtenerDocentes();
        //    LinkedList<Especialidad> listaEspecialidades;
        //    foreach (Docente docenteActual in listaDocentes)
        //    {
        //        Console.Write(docenteActual.Cedula + " " + docenteActual.Nombre + " " + docenteActual.PrimerApellido + " " + docenteActual.SegundoApellido + "\n");
        //        listaEspecialidades = docenteActual.ListaEspecialidades;
        //        foreach (Especialidad especialidad in listaEspecialidades)
        //        {
        //            Console.Write("-------" + especialidad.Descripcion + "\n");
        //        }

        //    }
        //}//ObtenerDocentes

        //[TestMethod]
        //public void ObtenerDocente()
        //{
        //    string cedula = "888888888";
        //    Docente docente = this.docenteData.ObtenerDocente(cedula);
        //    LinkedList<Especialidad> listaEspecialidades;

        //    Console.Write(docente.Cedula + " " + docente.Nombre + " " + docente.PrimerApellido + " " + docente.SegundoApellido + "\n");
        //    listaEspecialidades = docente.ListaEspecialidades;
        //    foreach (Especialidad especialidad in listaEspecialidades)
        //    {
        //        Console.Write("-------" + especialidad.Descripcion + "\n");
        //    }

        //}//ObtenerDocente

        //[TestMethod]
        //public void InsertarDocente()
        //{
        //    Docente docente = new Docente();
        //    docente.Cedula = "888888888";
        //    docente.Nombre = "Sergio";
        //    docente.PrimerApellido = "Ramos";
        //    docente.SegundoApellido = "Ramos";
        //    docente.Telefono = 8888899;
        //    docente.Correo = "ser@asdf";
        //    docente.Direccion = "Guadalupe, Cartago";
        //    docente.ListaEspecialidades.AddLast(new Especialidad("ESP-2", "Licenciatura en Enseñanza Escolar"));
        //    docente.ListaEspecialidades.AddLast(new Especialidad("ESP-3", "Maestría en Psicología Infantil"));

        //    this.docenteData.InsertarDocente(docente);
        //}

        //[TestMethod]
        //public void ActualizarDocente()
        //{
        //    Docente docente = new Docente();
        //    docente.Cedula = "888888888";
        //    docente.Telefono = 22222228;
        //    docente.Correo = "ser@asdf";
        //    docente.Direccion = "Guadalupe, San José";

        //    this.docenteData.ActualizarDocente(docente);
        //}

        //[TestMethod]
        //public void EliminarDocente()
        //{
        //   this.docenteData.EliminarDocente("112364526");
        //}

        //[TestMethod]
        //public void TieneCursos()
        //{
        //    if (this.docenteData.TieneCursos("888888888"))
        //    {
        //        Console.WriteLine("Sí tiene cursos.");
        //    }else
        //    {
        //        Console.WriteLine("No tiene cursos.");
        //    }
        //}

        //[TestMethod]
        //public void ObtenerCodigo()
        //{
        //    Console.Write(this.docenteData.GenerarCodigoEspecialidad());
        //}

        //[TestMethod]
        //public void AsignarEspecialidadAlDocente()
        //{
        //    this.docenteData.AsignarEspecialidadAlDocente("ESP-3", "888888888");
        //}

        //[TestMethod]
        //public void AsignarCursoAlDocente()
        //{
        //    this.docenteData.AsignarCursoAlDocente("CURSO-1", "888888888");
        //    this.docenteData.AsignarCursoAlDocente("CURSO-2", "888888888");
        //}
    }
}
