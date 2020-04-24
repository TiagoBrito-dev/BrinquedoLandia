using BrinquedoLandia.Enums;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    class Pedido
    {
        public Cliente Comprador { get; set; }
        public EstatusPedido Estatus { get; set; }
        public List<ItemPedido> ListItems { get; set; } = new List<ItemPedido>();
        public DateTime DataDaCompra { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(Cliente comprador, EstatusPedido estatus)
        {
            Comprador = comprador;
            Estatus = estatus;
            DataDaCompra = DateTime.Now;
        }

        public string NotaFiscal()
        {
            ServicoDePedido Sp = new ServicoDePedido();
            return Sp.PreencheNotaFiscal();
        }
    }
}
