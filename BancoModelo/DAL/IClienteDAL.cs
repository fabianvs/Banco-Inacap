using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
    public interface ICuentaDAL
    {
        //Mostrar
        List<Cliente> Mostrar();

        //Agregar
        void Agregar(Cliente cliente);

        //Eliminar
        void Eliminar(string runc);
        //Filtrar
        void Buscar(string runc);

    }
}


