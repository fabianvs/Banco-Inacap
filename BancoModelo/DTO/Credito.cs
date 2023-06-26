using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DTO
{
    public class Credito: Cuenta
    {
        private static int ncuenta;
        private int SaldoCredito;
        private int DeudaCredito;
        private int CreditoUsado;

        public Credito(int saldoCredito, int deudaCredito, int creditoUsado, int cuenta, int saldo, Cliente runCli, int montocredito, int deudacredito, int creditousado) : base(ncuenta, saldo, runCli, montocredito, deudacredito, creditousado)
        {
            SaldoCredito = saldoCredito;
            DeudaCredito = deudaCredito;
            CreditoUsado = creditoUsado;
        }

        public int SaldoCredito1 { get => SaldoCredito; set => SaldoCredito = value; }
        public int DeudaCredito1 { get => DeudaCredito; set => DeudaCredito = value; }
        public int CreditoUsado1 { get => CreditoUsado; set => CreditoUsado = value; }
    }
}
