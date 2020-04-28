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
                        Listas.SerializaListaCliente();
                        opcaoCadastroCliente = 0;
                        break;
                    case 3:
                        opcaoCadastroCliente = 3;
                        break;
                }
            }

            return 0;

        }

        public static int ConsultaCliente()
        {
            int opcaoConsultaCliente = 0;

            while(opcaoConsultaCliente < 4)
            {
                Console.WriteLine("--CONSULTAR CLIENTE--");
                Console.WriteLine("1- POR NOME: ");
                Console.WriteLine("2- POR CPF OU CNPJ: ");
                Console.WriteLine("3- POR EMAIL: ");
                Console.WriteLine("4- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoConsultaCliente = int.Parse(Console.ReadLine());

                switch(opcaoConsultaCliente)
                {
                    case 1:
                        Console.Write("INFORME O NOME: "); string nome = Console.ReadLine();
                        var aux = Listas.ListCliente.Where(X => X.NomeOuRazaoSocial.Contains(nome)).Select(X=> X).DefaultIfEmpty(new ClienteFisico() { NomeOuRazaoSocial = "CLIENTE INEXISTENTE" });
                        string cliente = aux.First().ToString();
                        if(cliente.Contains("CLIENTE INEXISTENTE"))
                        {
                            Console.WriteLine("CLIENTE INEXISTENTE");
                        }
                        else
                        {
                            Console.WriteLine(cliente);
                        }
                        break;

                    case 2:
                        Console.Write("INFORME O CPF OU CNPJ: "); string cpf = Console.ReadLine();
                        List<ClienteFisico> ListFisico = Listas.ListCliente.Where(X => X is ClienteFisico).Select(X => X as ClienteFisico).ToList();
                        List<ClienteJuridico> ListJuridico = Listas.ListCliente.Where(X => X is ClienteJuridico).Select(X => X as ClienteJuridico).ToList();
                        if(cpf.Length == 11)
                        {
                            string cliente2 = ListFisico.Where(X => X.Cpf.Equals(cpf)).Select(X => X.ToString()).DefaultIfEmpty("CPF INEXISTENTE").ToString();
                            Console.WriteLine(cliente2);
                        }
                        else
                        {
                            string cliente2 = ListJuridico.Where(X => X.Cnpj.Equals(cpf)).Select(X => X.ToString()).DefaultIfEmpty("CNPJ INEXISTENTE").ToString();
                            Console.WriteLine(cliente2);
                        }
                        break;

                    case 3:
                        Console.Write("INFORME O EMAIL: "); string email = Console.ReadLine();
                        var aux3 = Listas.ListCliente.Where(X => X.Email.Contains(email)).Select(X => X).DefaultIfEmpty(new ClienteFisico() { NomeOuRazaoSocial = "EMAIL INEXISTENTE" });
                        string cliente3 = aux3.First().ToString();
                        if (cliente3.Contains(email))
                        {
                            Console.WriteLine("CLIENTE INEXISTENTE");
                        }
                        else
                        {
                            Console.WriteLine(cliente3);
                        }
                        break;


                }
            }
            

            


        }
    }
}
