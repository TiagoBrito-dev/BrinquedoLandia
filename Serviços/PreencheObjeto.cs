using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Serviços
{
    static class PreencheObjeto
    {
        public static void InsereDadosObjeto<T>(Object obj)
        {

            bool listaComItems = false;
            do
            {
                Console.WriteLine("-----Objeto: {0} ------", obj.GetType().Name);
                foreach (var campo in obj.GetType().GetProperties())
                {
                    if (campo.Name.Equals("ListEnd"))
                    {
                        campo.SetValue(obj, new List<Endereco>());
                    }
                    else if (campo.Name.Equals("ListPedido"))
                    {
                        campo.SetValue(obj, new List<Pedido>());
                    }
                    else if(campo.Name.Equals("Categoria"))
                    {
                        campo.SetValue(obj, "NOCATEGORY");
                    }
                    else
                    {
                        Console.Write(campo.Name + ": "); campo.SetValue(obj, Console.ReadLine());
                    }

                }
                var model = ValidaObjeto.getValidationError(obj);
                if (model.Count() > 0)
                {
                    foreach (var erro in model)
                    {
                        Console.WriteLine(erro.ErrorMessage);
                    }
                    listaComItems = true;
                }
                else
                {
                    listaComItems = false;

                }
            } while (listaComItems == true);
        }
        
    }
}
