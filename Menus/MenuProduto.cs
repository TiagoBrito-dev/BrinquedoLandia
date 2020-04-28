using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
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
                Console.WriteLine("1- CADASTRAR PRODUTO: ");
                Console.WriteLine("2- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoCadastroProduto = int.Parse(Console.ReadLine());

                switch (opcaoCadastroProduto)
                {
                    case 1:
                        Produto Pro = new Produto();
                        PreencheObjeto.InsereDadosObjeto<Produto>(Pro);
                        opcaoCadastroProduto = 0;
                        break;

                    case 2:
                        opcaoCadastroProduto = 0;
                        break;

                    default:
                        opcaoCadastroProduto = 0;
                        break;
                }
            }

            return 0;
        }
    }
}

