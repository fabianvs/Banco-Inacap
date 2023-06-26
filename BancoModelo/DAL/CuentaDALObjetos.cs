using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
   public class CuentaDALObjetos : ICuentaDal
    {
           
        public static List<Cuenta> cuentas = new List<Cuenta>();
        public static readonly TipoCuenta Credito = new TipoCuenta()
        {
            NombreCu = "Crédito",
            CodigoCu = "01"
        };

        public static readonly TipoCuenta Debito = new TipoCuenta()
        {
            NombreCu = "Débito",
            CodigoCu = "02"
        };
        public void crearCuenta(Cuenta cuenta)
        {
            cuentas.Add(cuenta);
        }


        //ec es la cuenta a eliminars
        public void eliminarCuenta(int ncuenta)
        {
            Cuenta ec = cuentas.Find(c => c.Ncuenta == ncuenta);
            cuentas.Remove(ec);
        }

        public void modificarCuenta(Cuenta cuenta)
        {
            int index = cuentas.FindIndex(c => c.Ncuenta == cuenta.Ncuenta);
            cuentas[index] = cuenta;
        }

        public List<Cuenta> mostrarCuentas()
        {
            return cuentas;
        }

    
        public void eliminarCuenta(Cuenta cuenta)
        {
            throw new NotImplementedException();
        }
    }
}
