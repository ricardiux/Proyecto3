using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VistaAdmin
{
    public partial class ModificarFechaMatriculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                MatriculaBusiness matriculaBusiness = new MatriculaBusiness(connectionString);

                LinkedList<Matricula> listaMatricula = matriculaBusiness.ObtenerMatriculas();
                ddlListaMatriculas.DataSource = listaMatricula;
                ddlListaMatriculas.DataMember = "Matriculas";
                ddlListaMatriculas.DataTextField = "MatriculaEstudiante";
                ddlListaMatriculas.DataValueField = "CodigoGrupo";
                ddlListaMatriculas.DataBind();
            }
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            //tbxNombre.Text = 
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}