using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VistaAdmin
{
    public partial class EliminarEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);

                LinkedList<Estudiante> listaEstudiantes = estudianteBusiness.ObtenerEstudiantes();
                ddlListaEstudiantes.DataSource = listaEstudiantes;
                ddlListaEstudiantes.DataMember = "Estudiantes";
                ddlListaEstudiantes.DataTextField = "NombreApellidos";
                ddlListaEstudiantes.DataValueField = "Cedula";
                ddlListaEstudiantes.DataBind();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);
            string cedula = ddlListaEstudiantes.SelectedValue;

            if (estudianteBusiness.TieneMatricula(cedula))
            {
                Response.Redirect("Error.aspx");
            }
            else
            {
                try
                {
                    estudianteBusiness.EliminarEstudiante(cedula);
                    Response.Redirect("Exito.aspx");
                }
                catch (SqlException ex)
                {
                    Console.Write(ex.Message);
                    Response.Redirect("Error.aspx");
                }
            }
        }
    }
}
