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
    public partial class ActualizarEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);

            string cedulaBuscar = tbxCedula.Text;
            Estudiante estudiante = estudianteBusiness.ObtenerEstudiante(cedulaBuscar);

            if (estudiante.Nombre == "")
            {
                Response.Redirect("Error.aspx");
            }
            else
            {
                tbxCedula.Text = estudiante.Cedula;
                tbxNombre.Text = estudiante.Nombre;
                tbxPrimerApellido.Text = estudiante.PrimerApellido;
                tbxSegundoApellido.Text = estudiante.SegundoApellido;

            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            EstudianteBusiness estudianteBusiness = new EstudianteBusiness(connectionString);

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

           try
            {
                estudianteBusiness.ActualizarEstudiante(estudiante);
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