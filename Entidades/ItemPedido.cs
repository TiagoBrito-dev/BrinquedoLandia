using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    class ItemPedido
    {
        public Produto Prod { get; set; }
        public int Quantidade { get; set; }
        public double PrecoProduto { get; set; }
    }
}
