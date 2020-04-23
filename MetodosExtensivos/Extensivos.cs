using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.MetodosExtensivos
{
    public static class Extensivos
    {
        public static string Cep(this string obj)
        {
            return obj.Substring(0, 5) + "-" + obj.Substring(5, 3);
        }

        public static string Cnpj(this string obj)
        {
            return obj.Substring(0, 2) + "." + obj.Substring(2, 3) + "." + obj.Substring(5, 3) + @"/" + obj.Substring(8, 4) + "-" + obj.Substring(12, 2);
        }

        public static string Cpf(this string obj)
        {
            return obj.Substring(0, 3) + "." + obj.Substring(3, 3) + "." + obj.Substring(6, 3) + "-" + obj.Substring(9, 2);
        }
    }
}
