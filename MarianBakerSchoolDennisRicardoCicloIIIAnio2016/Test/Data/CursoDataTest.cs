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

        [TestMethod]
        public void ObtenerCursos()
        {
            LinkedList<Curso> listaCursos = this.cursoData.ObtenerCursos();
            foreach (Curso cursoActual in listaCursos)
            {
                Console.Write(cursoActual.Codigo + " " + cursoActual.Nombre + " " + cursoActual.Docente.Nombre + " " + cursoActual.Docente.PrimerApellido);
            }
        }
    }
}
