using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BancoModelo.DTO;
using BancoModelo.DAL;

namespace BancoWeb
{
    public partial class Mostrar_Cliente : System.Web.UI.Page
    {
        private ClienteDALObjetos clienteDAL = new ClienteDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //La página está cargando por primera vez
                cargar_grilla();
            }
        }

        public void cargar_grilla()
        {
            List<Cliente> clientes = clienteDAL.Mostrar();

            foreach (Cliente cliente in clientes)
            {

                System.Diagnostics.Debug.WriteLine(cliente.Materno1);
            }

            this.grillaClientes.DataSource = clientes;
            this.grillaClientes.DataBind();
        }

        public void cargar_grilla(List<Cliente> filtrada)
        {
            this.grillaClientes.DataSource = filtrada;
            this.grillaClientes.DataBind();
        }

        protected void grillaClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //Recibimos el valor del argumento (Run) y lo convertimos a string
                string run = Convert.ToString(e.CommandArgument);
                //Eliminar al Cliente
                clienteDAL.Eliminar(run);
                //Recargar Página
                cargar_grilla();
            }
        }

        
    }
}