using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Interfaces
{
    class IClienteJuridico : ITipoCliente
    {
        public double Desconto(double amount)
        {
            return amount * 0.05;
        }

        public double Imposto(double amount)
        {
            return amount * 0.15;
        }
    }
}
