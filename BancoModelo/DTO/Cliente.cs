using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DTO
{
   
        public class Cliente
        {

            //Atributos ()

            private string Run;
            private string Nombre;
            private string Paterno;
            private string Materno;
            private string Passwrd;


       

        public Cliente(string run, string nombre, string paterno, string materno, string passwrd)
            {
                Run = run;
                Nombre = nombre;
                Paterno = paterno;
                Materno = materno;
                
                Passwrd = passwrd;
            }

        public string Run1 { get => Run; set => Run = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Paterno1 { get => Paterno; set => Paterno = value; }
        public string Materno1 { get => Materno; set => Materno = value; }

        public string Passwrd1 { get => Passwrd; set => Passwrd = value; }

        //ToString
        public override string ToString()
        {

            return "Run: " + this.Run +
                "Nombre: " + this.Nombre +
                "Apellido Paterno: " + this.Paterno +
                "Apellido Materno: " + this.Materno +
                "Contraseña: " + this.Passwrd ;
           
        }
        }
}
   
