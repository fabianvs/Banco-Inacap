using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DTO
{public struct TipoCuenta
    {
        public string NombreCu { get; set; }
        public string CodigoCu { get; set; }

    }
    public class Cuenta
    {
        //Atributos
        private int ncuenta;
        private int saldo;
        private Cliente runCli;
        private int montocredito;
        
        private int deudacredito;
        private int creditousado;
        //Constructores
        public Cuenta(int ncuenta, int saldo, Cliente runCli, int montocredito, int deudacredito, int creditousado)
        {
            this.Ncuenta = ncuenta;
            this.Saldo = saldo;
            this.RunCli = runCli;
            this.Montocredito = montocredito;
            
            this.Deudacredito = deudacredito;
            this.Creditousado = creditousado;
        }

        public int Ncuenta { get => ncuenta; set => ncuenta = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public Cliente RunCli { get => runCli; set => runCli = value; }
        public int Montocredito { get => montocredito; set => montocredito = value; }
        
        public TipoCuenta TipoCuenta { get; set; }
        public int Deudacredito { get => deudacredito; set => deudacredito = value; }
        public int Creditousado { get => creditousado; set => creditousado = value; }

        public override string ToString()
        {
            return

                "Número de la cuenta: " + this.Ncuenta +
                "Saldo de la cuenta: " + this.Saldo +
                "Rut del cliente de la cuenta: " + this.RunCli +
                "Tipo de cuenta: " + this.TipoCuenta.NombreCu +
                "Monto de la cuenta de crédito: " + this.Montocredito +
                "Deuda de la cuenta de crédito: " + this.Deudacredito +
                "Crédito usado: " + this.Creditousado;

        }
    }
}