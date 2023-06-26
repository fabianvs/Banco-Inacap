using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
   public class EjecutivoDALObjetos : IEjecutivoDAL
    {
        private static List<Ejecutivo> ejecutivos = new List<Ejecutivo>();
        private static List<Cliente> clientes = new List<Cliente>();

        public EjecutivoDALObjetos()
        {
            Ejecutivo ejecutivo = new Ejecutivo

            {
                Run1 = "18669654-9",
                Nombre1 = "Matias",
                Paterno1 = "Martinez",
                Materno1 = "Morales",
                Passwrd1 = "186696"
            };
        }

        //Agregar
        public void agregarEj(Ejecutivo e)
        {
            ejecutivos.Add(e);
        }
        //Eliminar
        public void eliminarEj(string run)
        {
            //buscamos al Ejecutivo
            // Ejecutivo ej = ejecutivos.Find(e => e.Run == run);

            //ejecutivos.Remove(ej);
        }
        public void eliminarCl(string run)
        {
            //Cliente cl = clientes.Find(c => c.Run == run);

            //clientes.Remove(cl);
        }
        //Mostrar
        public List<Ejecutivo> mostrarEj()
        {
            return ejecutivos;
        }


        public List<Cliente> MostrarClientes()
        {
            return clientes;
        }
    }
}
    

