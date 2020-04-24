using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Interfaces
{
    interface ITipoCliente
    {
        double Desconto(double amount);
        double Imposto(double amount);
    }
}
