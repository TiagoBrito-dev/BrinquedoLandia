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
                Listas.DeserializaListaProduto();
                foreach(Produto obj in Listas.ListProduto)
                {
                    Console.WriteLine(obj.ToString());
                }
                
                CadastrarProduto.InserirProdutoNaLista();

                foreach (Produto obj in Listas.ListProduto)
                {
                    Console.WriteLine(obj.ToString());
                }

            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
