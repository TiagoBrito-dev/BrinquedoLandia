using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Menus
{
    public static class MenuCliente
    {
        public static int CadastroCliente()
        {
            int opcaoCadastroCliente = 0;

            while(opcaoCadastroCliente < 3)
            {
                Console.WriteLine("--CADASTRO DE CLIENTES:--");
                Console.WriteLine("1- CLIENTE FISICO: ");
                Console.WriteLine("2- CLIENTE JURIDICO: ");
                Console.WriteLine("3- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoCadastroCliente = int.Parse(Console.ReadLine());

                switch (opcaoCadastroCliente)
                {
                    case 1:
                        ClienteFisico Cf = new ClienteFisico();
                        PreencheObjeto.InsereDadosObjeto<ClienteFisico>(Cf);
                        ValidaObjeto.IncluirClienteNaLista(Cf);
                        Listas.SerializaListaCliente();
                        opcaoCadastroCliente = 0;
                        break;

                    case 2:
                        ClienteJuridico Cj = new ClienteJuridico();
                        PreencheObjeto.InsereDadosObjeto<ClienteJuridico>(Cj);
                        opcaoCadastroCliente = 0;
                        break;
                    case 3:
                        opcaoCadastroCliente = 3;
                        break;
                }
            }

            return 0;

        }
    }
}
