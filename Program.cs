using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using BrinquedoLandia.Interfaces;
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
                Listas.DeserializaListaCliente();
                Listas.DeserializaListaProduto();
                Menus.MenuPrincipal.Principal();
                //var teste = Listas.ListCliente.Find(X => X.NomeOuRazaoSocial.Equals("ANDREZA CAMPOS"));
                //ServicoDePedido Sp = new ServicoDePedido(teste, teste.ListPedido.First());
                //Console.WriteLine(Sp.PreencheNotaFiscal());


            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
