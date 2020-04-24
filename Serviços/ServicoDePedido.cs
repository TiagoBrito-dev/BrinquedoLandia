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
        public Pedido Ped { get; set; }
        public ITipoCliente TipoCliente;

        public ServicoDePedido()
        {
        }

        public ServicoDePedido(Pedido ped, ITipoCliente tipoCliente)
        {
            Ped = ped;
            TipoCliente = tipoCliente;
        }

        public string PreencheNotaFiscal()
        {
            if(Ped.Comprador is ClienteFisico)
            {
                double totalPedido = Ped.ListItems.Sum(X => X.TotalItem());
                double desconto = TipoCliente.Desconto(Ped.ListItems.Sum(X => X.TotalItem()));
                double imposto = TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()));
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--Nota Fiscal do Pedido---");
                sb.AppendLine("Cliente: " + Ped.Comprador.NomeOuRazaoSocial);
                sb.AppendLine("Cpf: " + (Ped.Comprador.GetType().GetProperty("Cpf").GetValue(Ped.Comprador)).ToString().Cpf());
                sb.AppendLine("Data da compra: " + Ped.DataDaCompra.ToShortDateString());
                sb.AppendLine("Estatus: " + Ped.Estatus.ToString());
                sb.AppendLine("---Produtos Adquiridos---");
                foreach (ItemPedido obj in Ped.ListItems)
                {
                    sb.AppendLine(obj.ToString());
                }               
                sb.AppendLine("Total do Pedido: " + (Ped.ListItems.Sum(X => X.TotalItem())).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("- Desconto 10%: " + (TipoCliente.Desconto(Ped.ListItems.Sum(X=> X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("+ Imposto 30%: " + (TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("Total a pagar: " + (totalPedido-desconto+imposto).ToString("F2", CultureInfo.InvariantCulture));
                return sb.ToString();
            }

            else
            {
                double totalPedido = Ped.ListItems.Sum(X => X.TotalItem());
                double desconto = TipoCliente.Desconto(Ped.ListItems.Sum(X => X.TotalItem()));
                double imposto = TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()));
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--Nota Fiscal do Pedido---");
                sb.AppendLine("Cliente: " + Ped.Comprador.NomeOuRazaoSocial);
                sb.AppendLine("Cnpj: " + (Ped.Comprador.GetType().GetProperty("Cpf").GetValue(Ped.Comprador)).ToString().Cnpj());
                sb.AppendLine("Data da compra: " + Ped.DataDaCompra.ToShortDateString());
                sb.AppendLine("Estatus: " + Ped.Estatus.ToString());
                sb.AppendLine("---Produtos Adquiridos---");
                foreach (ItemPedido obj in Ped.ListItems)
                {
                    sb.AppendLine(obj.ToString());
                }
                sb.AppendLine("Total do Pedido: " + (Ped.ListItems.Sum(X => X.TotalItem())).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("- Desconto 5%: " + (TipoCliente.Desconto(Ped.ListItems.Sum(X => X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("+ Imposto 15%: " + (TipoCliente.Imposto(Ped.ListItems.Sum(X => X.TotalItem()))).ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine("Total a pagar: " + (totalPedido - desconto + imposto).ToString("F2", CultureInfo.InvariantCulture));
                return sb.ToString();
            }
        }
    }
}
