using BrinquedoLandia.Enums;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    public class Pedido
    {
        
        public EstatusPedido Estatus { get; set; }
        public List<ItemPedido> ListItems { get; set; } = new List<ItemPedido>();
        public DateTime DataDaCompra { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(EstatusPedido estatus)
        {            
            Estatus = estatus;
            DataDaCompra = DateTime.Now;
        }

        public string NotaFiscal(string obj)
        {
            return obj;
        }

        public void TotalPedido()
        {
            double total = ListItems.Sum(X => X.TotalItem());
        }
    }
}
