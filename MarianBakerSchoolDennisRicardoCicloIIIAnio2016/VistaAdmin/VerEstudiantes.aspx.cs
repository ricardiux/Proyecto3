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
    public partial class VerEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);

                LinkedList<Estudiante> listaEstudiantes = estudianteBusiness.ObtenerEstudiantes();

                gvEstudiantes.DataSource = listaEstudiantes;
                gvEstudiantes.DataBind();
            }
        }
    }
}