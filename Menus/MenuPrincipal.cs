using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Menus
{
    static class MenuPrincipal
    {
        public static void Principal()
        {
            int opcaoPrincipal = 0;
            while(opcaoPrincipal <= 6)
            {
                Console.WriteLine("--MENU PRINCIPAL--");
                Console.WriteLine("1- CADASTRAR CLIENTE: ");
                Console.WriteLine("2- CADASTRAR PRODUTO: ");
                Console.WriteLine("3- CONSULTAR CLIENTE: ");
                Console.WriteLine("4- CONSULTAR PRODUTOS: ");
                Console.WriteLine("5- CONSULTAR NOTAS FISCAIS: ");
                Console.WriteLine("6- SAIR: ");
                Console.Write("OPÇÃO: "); opcaoPrincipal = int.Parse(Console.ReadLine());

                switch(opcaoPrincipal)
                {
                    case 1:
                        MenuCliente.CadastroCliente();
                        break;

                    case 2:
                        MenuProduto.CadastroProduto();
                        break;
                    case 3:
                        break;
                }
            }
        }   
            

    }
}
