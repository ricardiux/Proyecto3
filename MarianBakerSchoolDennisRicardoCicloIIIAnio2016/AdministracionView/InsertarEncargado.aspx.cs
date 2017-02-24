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
    public partial class InsertarEncargado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            EncargadoBusiness encargadoBusiness = new EncargadoBusiness(connectionString);

            string cedula = tbxCedulaEncargado.Text;
            string nombre = tbxNombreEncargado.Text;
            string primerApellido = tbxPrimerApellidoEncargado.Text;
            string segundoApellido = tbxSegundoApellidoEncargado.Text;
            int telefono = Int32.Parse(tbxTelefonoEncargado.Text.ToString());
            string correo = tbxCorreoEncargado.Text;
            string direccion = tbxDireccionEncargado.Text;
            string nombreUsuario = tbxUsuarioEncargado.Text;
            string clave = tbxClaveEncargado.Text;

            Encargado encargado = new Encargado();

            encargado.Cedula = cedula;
            encargado.Nombre = nombre;
            encargado.PrimerApellido = primerApellido;
            encargado.SegundoApellido = segundoApellido;
            encargado.Telefono = telefono;
            encargado.Correo = correo;
            encargado.Direccion = direccion;
            encargado.Usuario = nombreUsuario;
            encargado.Clave = clave;

            try
            {
                encargadoBusiness.InsertarEncargado(encargado);
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