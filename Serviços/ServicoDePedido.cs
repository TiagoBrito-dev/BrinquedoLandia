using BrinquedoLandia.Entidades;
using BrinquedoLandia.Interfaces;
using BrinquedoLandia.MetodosExtensivos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Serviços
{
    class ServicoDePedido
    {
        public Cliente Cli { get; set; }
        public Pedido Ped { get; set; }

        public ITipoCliente TipoCliente;

        public ServicoDePedido()
        {
        }

        public ServicoDePedido(Cliente cli, Pedido ped)
        {
            Cli = cli;
            Ped = ped;
            if(cli is ClienteFisico)
            {
                TipoCliente = new IClienteFisico();
            }
            else
            {
                TipoCliente = new IClienteJuridico();
            }            
        }

        public string PreencheNotaFiscal()
        {
            double totalPedido = Ped.ListItems.Sum(X => X.TotalItem());
            double desconto = TipoCliente.Desconto(Ped.ListItems.Sum(X => X.TotalItem()));
            double imposto = TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()));
            string cpfoucnpj = (Cli is ClienteFisico) ? Cli.GetType().GetProperty("Cpf").GetValue(Cli).ToString() : Cli.GetType().GetProperty("Cnpj").GetValue(Cli).ToString();
            string definido = (cpfoucnpj.Length == 11) ? cpfoucnpj.Cpf() : cpfoucnpj.Cnpj();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--DADOS DO COMPRADOR--");
            sb.AppendLine("Nome: " + Cli.NomeOuRazaoSocial);
            sb.AppendLine("CPF / CNPJ: " + definido);
            sb.AppendLine("--Nota Fiscal do Pedido---");
            sb.AppendLine("Data da compra: " + Ped.DataDaCompra.ToShortDateString());
            sb.AppendLine("Estatus: " + Ped.Estatus.ToString());
            sb.AppendLine("---Produtos Adquiridos---");
            foreach (ItemPedido obj in Ped.ListItems)
            {
                sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Total do Pedido: " + (Ped.ListItems.Sum(X => X.TotalItem())).ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("- Desconto 10%: " + (TipoCliente.Desconto(Ped.ListItems.Sum(X => X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("+ Imposto 30%: " + (TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Total a pagar: " + (totalPedido - desconto + imposto).ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
