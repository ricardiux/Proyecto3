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
    public partial class InsertarEspecialidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                DocenteBusiness docenteBusiness = new DocenteBusiness(connectionString);

                tbxCodigo.Text = docenteBusiness.GenerarCodigoEspecialidad();

                ddlDocentes.DataSource = docenteBusiness.ObtenerDocentes();
                ddlDocentes.DataMember = "Docentes";
                ddlDocentes.DataTextField = "NombreApellidos";
                ddlDocentes.DataValueField = "Cedula";
                ddlDocentes.DataBind();
                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            DocenteBusiness docenteBusiness = new DocenteBusiness(connectionString);

            string cedula = ddlDocentes.SelectedValue;

            Especialidad especialidad = new Especialidad();
            especialidad.Codigo = tbxCodigo.Text;
            especialidad.Descripcion = tbxNombre.Text;

            try
            {
                docenteBusiness.InsertarEspecialidad(especialidad);
                docenteBusiness.AsignarEspecialidadAlDocente(especialidad.Codigo, cedula);
                Response.Redirect("Exito.aspx");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Response.Redirect("Error.aspx");
            }
        }
    }
}