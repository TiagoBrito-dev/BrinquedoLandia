using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                        opcaoCadastroProduto = 3;
                        break;

                    default:
                        opcaoCadastroProduto = 3;
                        break;
                }
            }

            return 0;
        }

        public static int ConsultaProduto()
        {
            int opcaoConsultaProduto = 0;

            while (opcaoConsultaProduto < 4)
            {
                Console.WriteLine("--CONSULTA DE PRODUTOS:--");
                Console.WriteLine("1- CONSULTA POR NOME: ");
                Console.WriteLine("2- CONSULTA POR PREÇO: ");
                Console.WriteLine("3- CONSULTA POR CATEGORIA: ");
                Console.WriteLine("4- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoConsultaProduto = int.Parse(Console.ReadLine());

                switch (opcaoConsultaProduto)
                {
                    case 1:
                        Console.Write("INFORME O NOME DO PRODUTO"); string nomeProduto = Console.ReadLine();
                        string produto = Listas.ListProduto.Where(X => X.NomeProduto == nomeProduto).Select(X => X.ToString()).DefaultIfEmpty("PRODUTO INEXISTENTE").ToString();
                        Console.WriteLine("--PRODUTO--\n" + produto);
                        opcaoConsultaProduto = 0;
                        break;

                    case 2:
                        Console.Write("INFORME O PRECO MINIMO: "); double precoMin = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("INFORME O PRECO MAXIMO: "); double precoMax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        var produto2 = Listas.ListProduto.Where(X => X.PrecoDouble() >= precoMin && X.PrecoDouble() <= precoMax).Select(X => X).DefaultIfEmpty(new Produto() { NomeProduto = "PRODUTO INEXISTENTE" });
                        foreach (Produto obj in produto2)
                        {
                            Console.WriteLine(obj.ToString());
                        }
                        opcaoConsultaProduto = 0;
                        break;

                    case 3:
                        Console.Write("SELECIONE A CATEGORIA (E/J/B): "); char categoria = char.Parse(Console.ReadLine());
                        if (categoria.Equals('E'))
                        {
                            var eletronicos = Listas.ListProduto.Where(X => X.Categoria.Equals("ELETRONICOS")).Select(X => X).DefaultIfEmpty(new Produto() { NomeProduto = "INEXISTENTE" });
                            foreach (Produto obj in eletronicos)
                            {
                                Console.WriteLine(obj.ToString());
                            }
                            opcaoConsultaProduto = 0;
                        }
                        else if (categoria.Equals('J'))
                        {
                            var jogos = Listas.ListProduto.Where(X => X.Categoria.Equals("JOGOS")).Select(X => X).DefaultIfEmpty(new Produto() { NomeProduto = "INEXISTENTE" });
                            foreach (Produto obj in jogos)
                            {
                                Console.WriteLine(obj.ToString());
                            }
                            opcaoConsultaProduto = 0;
                        }
                        else
                        {
                            var brinquedos = Listas.ListProduto.Where(X => X.Categoria.Equals("BRINQUEDOS")).Select(X => X).DefaultIfEmpty(new Produto() { NomeProduto = "INEXISTENTE" });
                            foreach (Produto obj in brinquedos)
                            {
                                Console.WriteLine(obj.ToString());
                            }
                            opcaoConsultaProduto = 0;
                        }
                        opcaoConsultaProduto = 0;
                        break;

                    default:
                        opcaoConsultaProduto = 4;
                        break;
                }
            }

            return 0;
        }
    }
    
}


