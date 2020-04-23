using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BrinquedoLandia.Serviços
{
     public static class SerializaObjeto
    {
       
        public static void Serializar<T>(IEnumerable<T> obj)
        {
            string path = @"C:\Users\User\Google Drive\Projetos C#\BrinquedoLandia\ObjetosSerializados\" + obj.GetType().Name + ".json";
            using (StreamWriter Sw = new StreamWriter(path))
            {
                JavaScriptSerializer Js = new JavaScriptSerializer();
                foreach(Object aux in obj)
                {
                    Sw.WriteLine(Js.Serialize(aux));
                }                
            }
        }

    }
}
