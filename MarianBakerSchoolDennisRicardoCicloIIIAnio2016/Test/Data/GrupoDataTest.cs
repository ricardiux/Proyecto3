using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Domain;

namespace Test.Data
{

    [TestClass]
    public class GrupoDataTest
    {
        GrupoData grupoData;
        public GrupoDataTest()
        {
            grupoData = new GrupoData("Data Source=163.178.107.130;Initial Catalog=MariamBakerDB;Persist Security Info=True;User ID=sqlserver;Password=saucr.12");
        }

        //[TestMethod]
        //public void ObtenerGrupos()
        //{
        //    LinkedList<Grupo> listaGrupos = this.grupoData.ObtenerGrupos();
        //    LinkedList<Curso> listaCursos;
        //    foreach (Grupo grupos in listaGrupos)
        //    {
        //        Console.Write(grupos.Codigo + " " + grupos.Grado + "\n");
        //        listaCursos = grupos.ListaCursos;
        //        foreach (Curso curso in listaCursos)
        //        {
        //            Console.Write("-------" + curso.Nombre + "\n");
        //        }

        //    }
        //}//ObtenerGrupos

        //public void ObtenerGrupos()
        //{
        //    Grupo grupo = this.grupoData.ObtenerGrupo("GRUPO-1");
        //    Console.Write(grupo.Codigo + " " + grupo.Grado + "\n");
        //    foreach (Curso curso in grupo.ListaCursos)
        //    {
        //        Console.Write("-------" + curso.Nombre + "\n");
        //    }
        //}//ObtenerGrupos

        //[TestMethod]
        //public void InsertarGrupo()
        //{
        //    Grupo grupo = new Grupo();
        //    grupo.Codigo = this.grupoData.GenerarCodigoGrupo();
        //    grupo.Grado = 2;

        //    this.grupoData.InsertarGrupo(grupo);
        //}

        //[TestMethod]
        //public void ActualizarGrupo()
        //{
        //    Grupo grupo = new Grupo();
        //    grupo.Codigo = "GRUPO-2";
        //    grupo.Grado= 3;

        //    this.grupoData.ActualizarGrupo(grupo);
        //}

        //[TestMethod]
        //public void EliminarGrupo()
        //{
        //    this.grupoData.EliminarGrupo("GRUPO-2");
        //}

        //[TestMethod]
        //public void TieneEstudiantes()
        //{
        //    if (this.grupoData.TieneEstudiantes("GRUPO-3"))
        //    {
        //        Console.WriteLine("Sí tiene estudiantes.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No tiene estudiantes.");
        //    }
        //}

        //[TestMethod]
        //public void ObtenerCodigo()
        //{
        //    Console.Write(this.grupoData.GenerarCodigoGrupo());
        //}
    }
}
