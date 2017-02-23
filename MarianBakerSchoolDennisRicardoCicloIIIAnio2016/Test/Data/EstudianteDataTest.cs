using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Domain;

namespace Test.Data
{
    [TestClass]
    public class EstudianteDataTest
    {
        EstudianteData estudianteData;
        public EstudianteDataTest()
        {
            this.estudianteData = new EstudianteData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");
        }

        //[TestMethod]
        //public void ObtenerEstudiantes()
        //{
        //    LinkedList<Estudiante> listaEstudiantes = this.estudianteData.ObtenerEstudiantes();
        //    foreach (Estudiante estudiante in listaEstudiantes)
        //    {
        //        Console.Write(estudiante.Cedula + " " + estudiante.Nombre + " " + estudiante.PrimerApellido+ " " + estudiante.SegundoApellido+ "\n");
        //    }
        //}

        //[TestMethod]
        //public void ObtenerEstudiante()
        //{
        //    Estudiante estudiante = this.estudianteData.ObtenerEstudiante("123456");
        //    Console.Write(estudiante.Cedula + " " + estudiante.Nombre + " " + estudiante.PrimerApellido+ " " + estudiante.SegundoApellido + "\n");
        //}

        //[TestMethod]
        //public void InsertarEstudiante()
        //{
        //    Estudiante estudiante = new Estudiante();
        //    estudiante.Cedula = "80808080";
        //    estudiante.Nombre = "Carlos";
        //    estudiante.PrimerApellido = "Hernández";
        //    estudiante.SegundoApellido = "Hernández";
        //    estudiante.Encargado.Cedula = "4444444";
        //    this.estudianteData.InsertarEstudiante(estudiante);
        //}


        //[TestMethod]
        //public void ActualizarEstudiante()
        //{
        //    Estudiante estudiante = new Estudiante();
        //    estudiante.Cedula = "90909090";
        //    estudiante.Nombre = "Mateo";
        //    estudiante.PrimerApellido = "Once";
        //    estudiante.SegundoApellido = "Treintaycinco";

        //    this.estudianteData.ActualizarEstudiante(estudiante);
        //}

        //[TestMethod]
        //public void EliminarEstudiante()
        //{
        //    string cedula = "90909090";
        //    this.estudianteData.EliminarEstudiante(cedula);
        //}

        //[TestMethod]
        //public void AsignarEncargadoAlEstudiante()
        //{
        //    this.estudianteData.AsignarEncargadoAlEstudiante("4444444", "80808080");//asignar
        //    this.estudianteData.AsignarEncargadoAlEstudiante("4444444", "123456");//actualizar
        //}

        //[TestMethod]
        //public void TieneMatricula()
        //{
        //    if (this.estudianteData.TieneMatricula("80808080"))
        //    {
        //        Console.WriteLine("Sí tiene matrícula.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No tiene matrícula.");
        //    }
        //}
    }
}
