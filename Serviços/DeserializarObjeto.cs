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
        public static IEnumerable<Object> DeserializaCliente(IEnumerable<Object> ObjList)
        {
            List<Cliente> ListaAuxiliar = new List<Cliente>();
            string path = @"C:\Users\User\Google Drive\Projetos C#\BrinquedoLandia\ObjetosSerializados\" + ObjList.GetType().Name + ".json";
            using (StreamReader Sr = new StreamReader(path))
            {
                JavaScriptSerializer Js = new JavaScriptSerializer();
                while (!Sr.EndOfStream)
                {                    
                    string aux = Sr.ReadLine();
                    if(aux.Contains("Cpf"))
                    {
                        ClienteFisico obj = (ClienteFisico)Js.Deserialize(aux, typeof(ClienteFisico));
                        ListaAuxiliar.Add(obj);
                    }
                    else if(aux.Contains("Cnpj"))
                    {
                        ClienteJuridico obj = (ClienteJuridico)Js.Deserialize(aux, typeof(ClienteJuridico));
                        ListaAuxiliar.Add(obj);
                    }                 
                   
                }

            }

            return ListaAuxiliar.ToList();
        }
    }
}

