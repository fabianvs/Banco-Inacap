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
            /*string rut = this.rutcTxt.Text;
            string nombre = this.nombrecTxt.Text;
            string paterno = this.paternocTxt.Text;
            string materno = this.maternocTxt.Text;
            string clave = this.passcTxt.Text;
            int ncuenta = Convert.ToInt32(this.ncuentaTxt);
             */
            /*

            System.Diagnostics.Debug.WriteLine("rut:" + rut);
            System.Diagnostics.Debug.WriteLine("nombre:" + nombre);
            System.Diagnostics.Debug.WriteLine("apellido paterno:" + paterno);
            System.Diagnostics.Debug.WriteLine("apellido materno:" + materno);
            System.Diagnostics.Debug.WriteLine("contraseña:" + clave);
            System.Diagnostics.Debug.WriteLine("Número de cuenta:" + ncuenta);
            System.Diagnostics.Debug.WriteLine("Tipo de cuenta:" + tipocuenta);

            */

    /*
            Cliente cliente = new Cliente(rut, nombre, paterno, materno, clave);

            System.Diagnostics.Debug.WriteLine(cliente.ToString());

            Cuenta cuenta = new Cuenta(ncuenta, 0, cliente, 0, 0, 0);

            System.Diagnostics.Debug.WriteLine(cuenta.ToString());*/
        }

    }
}