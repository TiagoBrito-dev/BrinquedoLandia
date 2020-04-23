using BrinquedoLandia.Entidades;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.DataBase
{
    static class Listas
    {

        public static List<Cliente> ListCliente { get; set; } = new List<Cliente>();
        public static List<Produto> ListProduto { get; set; } = new List<Produto>();

        public static void DeserializaListaCliente()
        {
            var teste = DeserializarObjeto.DeserializaCliente(ListCliente);
            foreach(Cliente obj in teste)
            {
                ListCliente.Add(obj);
            }
            
        }

        public static void SerializaListaCliente()
        {
            SerializaObjeto.Serializar<Cliente>(Listas.ListCliente);
        }

        public static void DeserializaListaProduto()
        {
            var teste = DeserializarObjeto.DeserializaCliente(ListProduto);
            foreach (Produto obj in teste)
            {
                ListProduto.Add(obj);
            }

        }

        public static void SerializaListaProduto()
        {
            SerializaObjeto.Serializar<Produto>(Listas.ListProduto);
        }


    }
}
