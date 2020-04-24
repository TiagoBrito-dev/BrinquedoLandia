using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Serviços
{
    class CadastrarProduto
    {
        public static void InserirProdutoNaLista()
        {
            Console.WriteLine("--CADASTRO DE PRODUTOS--");
            Console.WriteLine("CATEGORIA: \n1-ELETRONICOS\n2-JOGOS\n3-BRINQUEDOS");
            Console.Write("OPÇÃO: "); int opcao = int.Parse(Console.ReadLine());
            Produto P = new Produto();
            switch (opcao)
            {

                case 1: 
                    PreencheObjeto.InsereDadosObjeto<Produto>(P);
                    P.Categoria = "ELETRONICOS";
                    Listas.ListProduto.Add(P);
                    Listas.SerializaListaProduto();
                    break;

                case 2:
                    PreencheObjeto.InsereDadosObjeto<Produto>(P);
                    P.Categoria = "JOGOS";
                    Listas.ListProduto.Add(P);
                    Listas.SerializaListaProduto();
                    break;

                default:
                    PreencheObjeto.InsereDadosObjeto<Produto>(P);
                    P.Categoria = "BRINQUEDOS";
                    Listas.ListProduto.Add(P);
                    Listas.SerializaListaProduto();
                    break;
            }  
        }
    }
}
