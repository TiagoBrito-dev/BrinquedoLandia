using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Menus
{
    public static class MenuProduto
    {
        public static int CadastroProduto()
        {
            int opcaoCadastroProduto = 0;

            while (opcaoCadastroProduto < 3)
            {
                Console.WriteLine("--CADASTRO DE PRODUTOS:--");
                Console.WriteLine("1- CLIENTE FISICO: ");
                Console.WriteLine("2- CLIENTE JURIDICO: ");
                Console.WriteLine("3- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoCadastroCliente = int.Parse(Console.ReadLine());

                switch (opcaoCadastroCliente)
                {
                    case 1:
                        ClienteFisico Cf = new ClienteFisico();
                        PreencheObjeto.InsereDadosObjeto<ClienteFisico>(Cf);
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
}
