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
    public partial class InsertarGrupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                GrupoBusiness grupoBusiness = new GrupoBusiness(connectionString);

                tbxCodigo.Text = grupoBusiness.GenerarCodigoGrupo();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
            GrupoBusiness grupoBusiness = new GrupoBusiness(connectionString);

            Grupo grupo = new Grupo();
            grupo.Codigo = tbxCodigo.Text;
            grupo.Grado = Int32.Parse(ddlGrado.SelectedValue);

            try
            {
                grupoBusiness.InsertarGrupo(grupo);
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