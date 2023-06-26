using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DTO
{
    public class Movimiento
    {
        private int idmovimiento;
        private Cuenta tipocuenta;
        private Cuenta cuenta;
        private DateTime fecha;

        public Movimiento()
        {
        }

        public Movimiento(int idmovimiento, Cuenta tipocuenta, Cuenta cuenta, DateTime fecha)
        {
            this.Idmovimiento = idmovimiento;
            this.Tipocuenta = tipocuenta;
            this.Cuenta = cuenta;
            this.Fecha = fecha;
        }

        public int Idmovimiento { get => idmovimiento; set => idmovimiento = value; }
        public Cuenta Tipocuenta { get => tipocuenta; set => tipocuenta = value; }
        public Cuenta Cuenta { get => cuenta; set => cuenta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public override string ToString()
        {
            return
            "Número de movimiento: " + this.Idmovimiento +
            "Tipo de cuenta del movimiento: " + this.Tipocuenta +
            "Número de cuenta asociada al movimiento: " + this.Cuenta +
            "Fecha del movimiento: " + this.Fecha ;
           


        }
    }
}
