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
                foreach(Cliente obj in Listas.ListCliente)
                {
                    Console.WriteLine(obj);
                }

                ClienteFisico C1 = new ClienteFisico();
                PreencheObjeto.InsereDadosObjeto<ClienteFisico>(C1);
                ValidaObjeto.IncluirFisicoNaLista(C1);                

               
                
                Produto P1 = new Produto("Televisor", "1250.00", "ELETRONICOS");
                Produto P2 = new Produto("Bicicleta", "600.00", "BRINQUEDOS");
                Produto P3 = new Produto("XBOX ONE", "1280.00", "ELETRONICOS");
                Console.WriteLine(P1);
                Console.WriteLine(P2);
                Console.WriteLine(P3);


                Pedido P = new Pedido(Enums.EstatusPedido.FATURADO);
               
                P.ListItems.Add(new ItemPedido(P1, 1));
                P.ListItems.Add(new ItemPedido(P2, 1));
                P.ListItems.Add(new ItemPedido(P3, 1));
                C1.ListPedido.Add(P);
                Console.WriteLine(C1.ExibeNotaFiscalCliente(C1.ListPedido.First()));
                C1.InsereEnderco();

               
                SerializaObjeto.Serializar<Cliente>(Listas.ListCliente);


            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
