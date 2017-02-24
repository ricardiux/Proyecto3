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
    public partial class InsertarDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            DocenteBusiness docenteBusiness = new DocenteBusiness(connectionString);

            string cedula = tbxCedulaDocente.Text;
            string nombre = tbxNombreDocente.Text;
            string primerApellido = tbxPrimerApellidoDocente.Text;
            string segundoApellido = tbxSegundoApellidoDocente.Text;
            int telefono = Int32.Parse(tbxTelefonoDocente.Text.ToString());
            string correo = tbxCorreoDocente.Text;
            string direccion = tbxDireccionDocente.Text;

            Docente docente = new Docente();

            docente.Cedula = cedula;
            docente.Nombre = nombre;
            docente.PrimerApellido = primerApellido;
            docente.SegundoApellido = segundoApellido;
            docente.Telefono = telefono;
            docente.Correo = correo;
            docente.Direccion = direccion;
;

            try
            {
                docenteBusiness.InsertarDocente(docente);
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