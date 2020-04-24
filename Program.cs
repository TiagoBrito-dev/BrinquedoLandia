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

                ClienteJuridico C1 = new ClienteJuridico("Cenario Brasil", "beto@cenariobrasil.com", "123456", "11111111111111");
                Console.WriteLine(C1);

                Produto P1 = new Produto("Televisor", "1250.00", "ELETRONICOS");
                Produto P2 = new Produto("Bicicleta", "600.00", "BRINQUEDOS");
                Produto P3 = new Produto("XBOX ONE", "1280.00", "ELETRONICOS");
                Console.WriteLine(P1);
                Console.WriteLine(P2);
                Console.WriteLine(P3);


                Pedido P = new Pedido(C1, Enums.EstatusPedido.FATURADO);
               
                P.ListItems.Add(new ItemPedido(P1, 1));
                P.ListItems.Add(new ItemPedido(P2, 1));
                P.ListItems.Add(new ItemPedido(P3, 1));

                ServicoDePedido Sp = new ServicoDePedido(P, new IClienteJuridico());
                Console.WriteLine(Sp.PreencheNotaFiscal());
                

            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
