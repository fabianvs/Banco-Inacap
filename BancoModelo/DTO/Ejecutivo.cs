using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DTO
{
    public class Ejecutivo
    {

        private string Run;
        private string Nombre;
        private string Paterno;
        private string Materno;
        private string Passwrd;
        private List<Cliente> clientes = new List<Cliente>();

        public Ejecutivo()
        {
        }

        public Ejecutivo(string run, string nombre, string paterno, string materno, string passwrd, List<Cliente> clientes)
        {
            Run1 = run;
            Nombre1 = nombre;
            Paterno1 = paterno;
            Materno1 = materno;
            Passwrd1 = passwrd;
            this.Clientes = clientes;
        }

        public string Run1 { get => Run; set => Run = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Paterno1 { get => Paterno; set => Paterno = value; }
        public string Materno1 { get => Materno; set => Materno = value; }
        public string Passwrd1 { get => Passwrd; set => Passwrd = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public override string ToString()
        {
            return
            "Run: " + this.Run +
            "Nombre: " + this.Nombre +
            "Apellido Paterno: " + this.Paterno +
            "Apellido Materno: " + this.Materno +
            "Password: " + this.Passwrd +
            "Clientes asociados: " + this.clientes;

        }
    }
}
