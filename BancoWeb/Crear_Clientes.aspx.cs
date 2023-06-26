using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BancoModelo.DAL;
using BancoModelo.DTO;

namespace BancoWeb
{
    public partial class Crear_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string rut = this.rutcTxt.Text;
            string nombre = this.nombrecTxt.Text;
            string paterno = this.paternocTxt.Text;
            string materno = this.maternocTxt.Text;
            string clave = this.passcTxt.Text;
            int ncuenta = Convert.ToInt32(this.ncuentaTxt.Text);

            System.Diagnostics.Debug.WriteLine("Creando Cliente");

            Cliente cliente = new Cliente(rut, nombre, paterno, materno, clave);
            ClienteDALObjetos clienteDal = new ClienteDALObjetos();
            clienteDal.Agregar(cliente);

            System.Diagnostics.Debug.WriteLine("Cliente Creado");

            System.Diagnostics.Debug.WriteLine("Creando Cuenta");
            Cuenta cuenta = new Cuenta(ncuenta, 0, cliente, 0, 0, 0);
            CuentaDALObjetos cuentaDal = new CuentaDALObjetos();
            cuentaDal.crearCuenta(cuenta);

            System.Diagnostics.Debug.WriteLine("Cuenta Creada");


            Response.Redirect("Mostrar_Cliente.aspx");
        }

    }
}