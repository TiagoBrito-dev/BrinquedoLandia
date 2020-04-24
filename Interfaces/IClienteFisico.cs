using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Interfaces
{
    class IClienteFisico : ITipoCliente
    {
        public double Desconto(double amount)
        {
            return amount * 0.10;
        }

        public double Imposto(double amount)
        {
            return amount * 0.30;
        }
    }
}
