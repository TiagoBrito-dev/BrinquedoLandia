using BrinquedoLandia.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BrinquedoLandia.Serviços
{
    static class DeserializarObjeto
    {
        public static IEnumerable<Object> DeserializaLista(IEnumerable<Object> ObjList, string tipo)
        {
            
            if(tipo == "Cliente")
            {
                List<Cliente> ListaAuxiliar = new List<Cliente>();
                string path = @"C:\Users\User\Google Drive\Projetos C#\BrinquedoLandia\ObjetosSerializados\" + "ListaCliente" + ".json";
                using (StreamReader Sr = new StreamReader(path))
                {
                    JavaScriptSerializer Js = new JavaScriptSerializer();
                    while (!Sr.EndOfStream)
                    {
                        string aux = Sr.ReadLine();
                        if (aux.Contains("Cpf"))
                        {
                            ClienteFisico obj = (ClienteFisico)Js.Deserialize(aux, typeof(ClienteFisico));
                            ListaAuxiliar.Add(obj);
                        }
                        else if (aux.Contains("Cnpj"))
                        {
                            ClienteJuridico obj = (ClienteJuridico)Js.Deserialize(aux, typeof(ClienteJuridico));
                            ListaAuxiliar.Add(obj);
                        }

                    }

                }

                return ListaAuxiliar.ToList();
            }
            else
            {
                List<Produto> ListaAuxiliar = new List<Produto>();
                string path = @"C:\Users\User\Google Drive\Projetos C#\BrinquedoLandia\ObjetosSerializados\" + "ListaProduto" + ".json";
                using (StreamReader Sr = new StreamReader(path))
                {
                    JavaScriptSerializer Js = new JavaScriptSerializer();
                    while (!Sr.EndOfStream)
                    {
                        string aux = Sr.ReadLine();
                        Produto obj = (Produto)Js.Deserialize(aux, typeof(Produto));
                        ListaAuxiliar.Add(obj);
                    }

                }

                return ListaAuxiliar.ToList();
            }
            
        }
    }
}

