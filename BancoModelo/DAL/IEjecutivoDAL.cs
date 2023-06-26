using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
    public interface IEjecutivoDAL
    {
        List<Cliente> MostrarClientes();

    }
}
