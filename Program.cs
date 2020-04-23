using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BrinquedoLandia
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Produto P = new Produto();
                PreencheObjeto.InsereDadosObjeto<Produto>(P);
                Console.WriteLine(P.ToString());
                
                
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
