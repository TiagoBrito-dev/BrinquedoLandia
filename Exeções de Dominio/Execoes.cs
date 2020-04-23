using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Exeções_de_Dominio
{
    class Excecoes : ApplicationException
    {
        public Excecoes(string message) : base(message)
        {

        }
    }
}
