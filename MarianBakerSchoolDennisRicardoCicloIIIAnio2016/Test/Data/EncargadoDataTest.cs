using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Domain;

namespace Test.Data
{

    [TestClass]
    public class EncargadoDataTest
    {
        EncargadoData encargadoData;
        public EncargadoDataTest()
        {
            encargadoData = new EncargadoData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");
        }

        //[TestMethod]
        //public void ObtenerEncargados()
        //{
        //    LinkedList<Encargado> listaEncargados = this.encargadoData.ObtenerEncargados();
        //    LinkedList<Estudiante> listaEstudiantes;
        //    foreach (Encargado encargadoActual in listaEncargados)
        //    {
        //        Console.Write(encargadoActual.Cedula + " " + encargadoActual.Nombre + " " + encargadoActual.PrimerApellido + " " + encargadoActual.SegundoApellido + "\n");
        //        listaEstudiantes = encargadoActual.ListaEstudiantes;
        //        foreach (Estudiante estudiante in listaEstudiantes)
        //        {
        //            Console.Write("-------" + estudiante.Nombre + "\n");
        //        }

        //    }
        //}//ObtenerEncargados


        //[TestMethod]
        //public void ObtenerEncargado()
        //{
        //    Encargado encargado = this.encargadoData.ObtenerEncargado("22222222");
        //    LinkedList<Estudiante> listaEstudiantes;

        //    Console.Write(encargado.Cedula + " " + encargado.Nombre + " " + encargado.PrimerApellido + " " + encargado.SegundoApellido + "\n");
        //    listaEstudiantes = encargado.ListaEstudiantes;
        //    foreach (Estudiante estudiante in listaEstudiantes)
        //    {
        //        Console.Write("-------" + estudiante.Nombre + "\n");
        //    }
        //}//ObtenerEncargado

        [TestMethod]
        public void InsertarEncargado()
        {
            Encargado encargado = new Encargado();
            encargado.Cedula = "66666666";
            encargado.Nombre = "Usuario";
            encargado.PrimerApellido = "Apellido1";
            encargado.SegundoApellido = "Apellido2";
            encargado.Telefono = 8888899;
            encargado.Correo = "correo";
            encargado.Direccion = "direccion";
            encargado.Usuario = "usuario";
            encargado.Clave = "1111";

            this.encargadoData.InsertarEncargado(encargado);
        }

        //[TestMethod]
        //public void ActualizarEncargado()
        //{
        //    Encargado encargado = new Encargado();
        //    encargado.Cedula = "66666666";
        //    encargado.Telefono = 22222228;
        //    encargado.Correo = "enc@gmail";
        //    encargado.Direccion = "Guadalupe, San José";

        //    this.encargadoData.ActualizarEncargado(encargado);
        //}

        //[TestMethod]
        //public void EliminarDocente()
        //{
        //    this.encargadoData.EliminarEncargado("66666666");
        //}

        //[TestMethod]
        //public void TieneEstudiantes()
        //{
        //    if (this.encargadoData.TieneEstudiantes("22222222"))
        //    {
        //        Console.WriteLine("Sí tiene cursos.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No tiene cursos.");
        //    }
        //}
    }
}
