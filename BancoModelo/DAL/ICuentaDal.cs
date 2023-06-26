using BancoModelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoModelo.DAL
{
   public interface ICuentaDal
    {
 

    
        //crear

        void crearCuenta(Cuenta cuenta);

        //eliminar

        void eliminarCuenta(Cuenta cuenta);

        // modi

        void modificarCuenta(Cuenta cuenta);

        //mostrars

        List<Cuenta> mostrarCuentas();

        //buscars

    }
}
