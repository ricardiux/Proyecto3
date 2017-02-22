using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Domain;

namespace Test
{

    [TestClass]
    public class CursoDataTest
    {
        CursoData cursoData;

        public CursoDataTest()
        {
            this.cursoData = new CursoData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");
        }

        //[TestMethod]
        //public void ObtenerCursos()
        //{
        //    LinkedList<Curso> listaCursos = this.cursoData.ObtenerCursos();
        //    foreach (Curso cursoActual in listaCursos)
        //    {
        //        Console.Write(cursoActual.Codigo + " " + cursoActual.Nombre + " " + cursoActual.Docente.Nombre + " " + cursoActual.Docente.PrimerApellido + "\n");
        //    }
        //}

        //[TestMethod]
        //public void InsertarCurso()
        //{
        //    Curso curso = new Curso();
        //    curso.Codigo = "CURSO-2";
        //    curso.Nombre = "Español";
        //    curso.Docente.Cedula = "112364526";
        //    this.cursoData.InsertarCurso(curso);
        //}

        [TestMethod]
        public void GenerarCodigoCurso()
        {
            Console.Write(this.cursoData.GenerarCodigoCurso());
        }

        //[TestMethod]
        //public void ObtenerCursos()
        //{
        //    Curso curso = this.cursoData.ObtenerCurso("CURSO-1");
        //    Console.Write(curso.Codigo + " " + curso.Nombre + " " + curso.Docente.Nombre + " " + curso.Docente.PrimerApellido + "\n");
        ////}

        //[TestMethod]
        //public void ActualizarCurso()
        //{
        //    Curso curso = new Curso();
        //    curso.Codigo = "CURSO-2";
        //    curso.Nombre = "Lengua Española";
        //    curso.Docente.Cedula = "112364526";

        //    this.cursoData.ActualizarCurso(curso);
        ////}

        ////[TestMethod]
        ////public void EliminarCurso()
        ////{
        ////    string codigoCurso = "CURSO-1";
        ////    this.cursoData.EliminarCurso(codigoCurso);
        ////}
    }
}
