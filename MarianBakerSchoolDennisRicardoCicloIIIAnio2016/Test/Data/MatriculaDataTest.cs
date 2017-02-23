using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using Data;

namespace Test.Data
{

    [TestClass]
    public class MatriculaDataTest
    {
        MatriculaData matriculaData;
        public MatriculaDataTest()
        {
            this.matriculaData = new MatriculaData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");

        }

        //[TestMethod]
        //public void ObtenerMatriculas()
        //{
        //    LinkedList<Matricula> listaMatricula = this.matriculaData.ObtenerMatriculas();
        //    foreach (Matricula matricula in listaMatricula)
        //    {
        //        Console.Write(matricula.Estudiante.Cedula + " " + matricula.Grupo.Codigo + " " + matricula.FechaPago + "\n");
        //    }
        //}

        //[TestMethod]
        //public void ObtenerMatricula()
        //{
        //    Matricula matricula = this.matriculaData.ObtenerMatricula("22223232", "GRUPO-1");
        //    Console.Write(matricula.Estudiante.Cedula + " " + matricula.Grupo.Codigo + " " + matricula.FechaPago + "\n");

        //}


        //[TestMethod]
        //public void InsertarMatricula()
        //{
        //    Matricula matricula = new Matricula();
        //    matricula.Grupo.Codigo = "GRUPO-1";
        //    matricula.Estudiante.Cedula = "80808080";
        //    matricula.FechaPago = DateTime.Now.Date;
        //    this.matriculaData.InsertarMatricula(matricula);
        //}

        //[TestMethod]
        //public void ActualizarMatricula()
        //{
        //    Matricula matricula = new Matricula();
        //    string date = "09/07/2017";
        //    DateTime fecha = Convert.ToDateTime(date).Date;
        //    matricula.Estudiante.Cedula = "22223232";
        //    matricula.Grupo.Codigo = "GRUPO-1";
        //    matricula.FechaPago = fecha;
        //    Console.Write(matricula.FechaPago);

        //    this.matriculaData.ActualizarMatricula(matricula);
        //}

        //[TestMethod]
        //public void EliminarMatricula()
        //{
        //    string codigoGrupo = "GRUPO-1";
        //    string cedulaEstudiante = "22223232";
        //    this.matriculaData.EliminarMatricula(cedulaEstudiante, codigoGrupo);
        //}
    }
}
