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

namespace AdministracionView
{
    public partial class InsertarMatricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                MatriculaBusiness matriculaBusiness = new MatriculaBusiness(connectionString);
                EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);
                GrupoBusiness grupoBusiness = new GrupoBusiness(connectionString);

                ddlEstudiante.DataSource = estudianteBusiness.ObtenerEstudiantes();
                ddlEstudiante.DataMember = "Estudiantes";
                ddlEstudiante.DataTextField = "NombreApellidos";
                ddlEstudiante.DataValueField = "Cedula";
                ddlEstudiante.DataBind();


                ddlGrupo.DataSource = grupoBusiness.ObtenerGrupos();
                ddlGrupo.DataMember = "Grupos";
                ddlGrupo.DataTextField = "GrupoGrado";
                ddlGrupo.DataValueField = "Codigo";
                ddlGrupo.DataBind();
            }
        }

        protected void btnMatricula_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            MatriculaBusiness matriculaBusiness = new MatriculaBusiness(connectionString);

            Matricula matricula = new Matricula();
            matricula.Estudiante.Cedula = ddlEstudiante.SelectedValue;
            matricula.Grupo.Codigo = ddlGrupo.SelectedValue;
            matricula.FechaPago = (DateTime.Parse(tbxFechaPago.Text)).Date;
            matricula.Monto = float.Parse(tbxMonto.Text);
            try
            {
                matriculaBusiness.InsertarMatricula(matricula);
                Response.Redirect("Exito.aspx");
            }catch (SqlException ex)
            {
                Console.Write(ex);
                Response.Redirect("Error.aspx");
            }
        }

    }
}