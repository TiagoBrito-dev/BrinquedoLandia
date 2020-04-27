using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    public class ItemPedido
    {
        public Produto Prod { get; set; }
        public int Quantidade { get; set; }
        public double PrecoProduto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(Produto prod, int quantidade)
        {
            Prod = prod;
            Quantidade = quantidade;
            PrecoProduto = Prod.PrecoDouble();
        }

        public double TotalItem()
        {
            return PrecoProduto * Quantidade;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Prod.NomeProduto
                + " - Quantidade: "
                + Quantidade
                + " Preco Unitario R$: "
                + PrecoProduto.ToString("F2", CultureInfo.InvariantCulture)
                + " - Total R$: "
                + ((Quantidade * PrecoProduto).ToString("F2", CultureInfo.InvariantCulture)));

            return sb.ToString();
        }
    }
}
