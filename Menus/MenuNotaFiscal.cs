using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Menus
{
    public static class MenuNotaFiscal
    {
        public static int ConsultaNotaFiscal()
        {
            int opcaoConsultaNota = 0;

            while (opcaoConsultaNota < 4)
            {
                Console.WriteLine("--CONSULTA DE NOTAS FISCAIS:--");
                Console.WriteLine("1- CONSULTA POR CLIENTE: ");
                Console.WriteLine("2- CONSULTA POR DATA: ");
                Console.WriteLine("3- CONSULTAR TODAS: ");
                Console.WriteLine("4- VOLTAR: ");
                Console.Write("OPÇÃO: "); opcaoConsultaNota = int.Parse(Console.ReadLine());

                switch (opcaoConsultaNota)
                {
                    case 1:
                        /*Console.Write("INFORME O CPF OU CNPJ: "); string cpf = Console.ReadLine();
                        List<ClienteFisico> ListFisico = Listas.ListCliente.Where(X => X is ClienteFisico).Select(X => X as ClienteFisico).ToList();
                        List<ClienteJuridico> ListJuridico = Listas.ListCliente.Where(X => X is ClienteJuridico).Select(X => X as ClienteJuridico).ToList();
                        if (cpf.Length == 11)
                        {
                            var cliente2 = ListFisico.Where(X => X.Cpf.Equals(cpf)).Select(X => X).DefaultIfEmpty(new ClienteFisico() { NomeOuRazaoSocial = "CLIENTE INEXISTENTE", Cpf = "00000000000", Email = "invalido@invalido.com", Senha = "000000" });
                            string clienteString = cliente2.First().ToString();
                            if (clienteString.Contains("invalido"))
                            {
                                Console.WriteLine("CLIENTE INEXISTENTE");
                            }
                            else
                            {
                                foreach(Pedido obj in cliente2.First().ListPedido)
                                {
                                    Console.WriteLine(cliente2.First().ExibeNotaFiscalCliente(obj));
                                }
                            }
                        }
                        else
                        {
                            var cliente2 = ListJuridico.Where(X => X.Cnpj.Equals(cpf)).Select(X => X).DefaultIfEmpty(new ClienteJuridico() { NomeOuRazaoSocial = "CLIENTE INEXISTENTE", Cnpj = "00000000000000", Email = "invalido@invalido.com", Senha = "000000" });
                            string clienteString = cliente2.First().ToString();
                            if (clienteString.Contains("invalido"))
                            {
                                Console.WriteLine("CLIENTE INEXISTENTE");
                            }
                            else
                            {
                                foreach (Pedido obj in cliente2.First().ListPedido)
                                {
                                    Console.WriteLine(cliente2.First().ExibeNotaFiscalCliente(obj));
                                }
                            }
                        }
                        opcaoConsultaNota = 0;*/
                        break;

                    case 2:
                        /*Console.Write("INFORME A DATA INICIAL: "); DateTime dataInicial = DateTime.Parse(Console.ReadLine());
                        Console.Write("INFORME A DATA FINAL: "); DateTime dataFinal = DateTime.Parse(Console.ReadLine());
                        var notaFiscal = Listas.ListCliente.Select(X => X.ListPedido.Where(Y => (Y.DataDaCompra >= dataInicial) && (Y.DataDaCompra <= dataFinal)));
                        foreach(Pedido obj in notaFiscal)
                        {
                            Console.WriteLine(obj.NotaFiscal());
                        }
                        opcaoConsultaNota = 0;
                        break;*/

                    case 3:
                        var clientes = Listas.ListCliente.Where(X => X.ListPedido.Count > 0).Select(X=> X);
                        foreach(Cliente obj in clientes)
                        {
                            foreach(Pedido ped in obj.ListPedido)
                            {
                                ServicoDePedido Sp = new ServicoDePedido(obj, ped);
                                Console.WriteLine(ped.NotaFiscal(Sp.PreencheNotaFiscal()));
                            }
                        }
                        opcaoConsultaNota = 0;
                        break;
                        
                    default:
                        opcaoConsultaNota = 4;
                        break;
                }
            }

            return 0;
        }
    }
}
