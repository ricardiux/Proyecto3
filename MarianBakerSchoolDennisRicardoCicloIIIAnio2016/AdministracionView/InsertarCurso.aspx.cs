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
    public partial class InsertarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectionString = WebConfigurationManager.ConnectionStrings["MariamBakerDB"].ConnectionString;
                CursoBusiness cursoBusiness = new CursoBusiness(connectionString);
                GrupoBusiness grupoBusiness = new GrupoBusiness(connectionString);
                DocenteBusiness docenteBusiness = new DocenteBusiness(connectionString);

                tbxCodigo.Text = cursoBusiness.GenerarCodigoCurso();

                ddlGrupos.DataSource = grupoBusiness.ObtenerGrupos(); 
                ddlGrupos.DataMember = "Grupos";
                ddlGrupos.DataTextField = "GrupoGrado";
                ddlGrupos.DataValueField = "Codigo";
                ddlGrupos.DataBind();

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
            CursoBusiness cursoBusiness = new CursoBusiness(connectionString);
            DocenteBusiness docenteBusiness = new DocenteBusiness(connectionString);

            Curso curso = new Curso();
            curso.Codigo = tbxCodigo.Text;
            curso.Nombre = tbxNombre.Text;

            string codigoGrupo = ddlGrupos.SelectedValue;
            string cedulaDocente = ddlDocentes.SelectedValue;

            try
            {
                cursoBusiness.InsertarCurso(curso);
                cursoBusiness.AsignarCursoAlGrupo(curso.Codigo, codigoGrupo);
                docenteBusiness.AsignarCursoAlDocente(curso.Codigo, cedulaDocente);
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