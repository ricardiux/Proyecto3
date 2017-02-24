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
    public partial class InsertarEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                EncargadoBusiness encargadoBusiness = new EncargadoBusiness(connectionString);

                LinkedList<Encargado> listaEncargados = encargadoBusiness.ObtenerEncargados();
                ddlListaEncargados.DataSource = listaEncargados;
                ddlListaEncargados.DataMember = "Encargados";
                ddlListaEncargados.DataTextField = "NombreApellidos";
                ddlListaEncargados.DataValueField = "Cedula";
                ddlListaEncargados.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(connectionString);

            //Estudiante
            string cedula = tbxCedula.Text;
            string nombre = tbxNombre.Text;
            string primerApellido = tbxPrimerApellido.Text;
            string segundoApellido = tbxSegundoApellido.Text;

            Estudiante estudiante = new Estudiante();
            estudiante.Cedula = cedula;
            estudiante.Nombre = nombre;
            estudiante.PrimerApellido = primerApellido;
            estudiante.SegundoApellido = segundoApellido;

            string cedulaEncargado = ddlListaEncargados.SelectedValue;

            try
            {
                estudianteBusiness.InsertarEstudiante(estudiante);
                estudianteBusiness.AsignarEncargadoAlEstudiante(cedulaEncargado, estudiante.Cedula);
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