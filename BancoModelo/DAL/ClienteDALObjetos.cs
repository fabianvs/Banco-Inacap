using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
    public class ClienteDALObjetos : IClienteDAL
    {
        
        private static List<Cliente> clientes = new List<Cliente>();


        public List<Cliente> Mostrar()
        {
            return clientes;
        }

        public void Agregar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void Eliminar(string run)
        {
            Cliente cl = clientes.Find(c => c.Run1 == run);

            clientes.Remove(cl);
        }

        public void Buscar(string run)
        {
            clientes.Find(c => c.Run1 == run);
        }

        public List<Cliente> Filtrar(string run)
        {
            return clientes.FindAll(c => c.Run1 == run);
        }


    }

    public interface IClienteDAL
    {
    }
}
