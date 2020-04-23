using BrinquedoLandia.DataBase;
using BrinquedoLandia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace BrinquedoLandia.Serviços
{
    public static class ValidaObjeto
    {
        public static IEnumerable<ValidationResult> getValidationError(Object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        public static void IncluirFisicoNaLista(Object obj)
        {
            List<ClienteFisico> ListFisico = Listas.ListCliente.Where(X => X is ClienteFisico).Select(X => X as ClienteFisico).ToList();
            List<ClienteJuridico> ListJuridico = Listas.ListCliente.Where(X => X is ClienteJuridico).Select(X => X as ClienteJuridico).ToList();            
            if(obj is ClienteFisico)
            {
                var cliFisico = ListFisico.Where(X => X.Email.Equals(obj.GetType().GetProperty("Email").GetValue(obj)) ||
                X.Cpf.Equals(obj.GetType().GetProperty("Cpf").GetValue(obj))).DefaultIfEmpty(new ClienteFisico { NomeOuRazaoSocial = "Invalido", Cpf = "00000000000", Email = "invalido@invalido.com", Senha = "000000" });
                string first = cliFisico.First().ToString();
                if(first.Contains("Invalido"))
                {
                    Console.WriteLine("Novo Cliente Fisico inserido com sucesso: \n" + obj.ToString());
                    Listas.ListCliente.Add(obj as ClienteFisico);
                }
                else
                {
                    Console.WriteLine("Cliente já consta na lista: \n" + first);                    
                }
            }
            else if(obj is ClienteJuridico)
            {
                var cliJuridico = ListJuridico.Where(X => X.Email.Equals(obj.GetType().GetProperty("Email").GetValue(obj)) ||
               X.Cnpj.Equals(obj.GetType().GetProperty("Cnpj").GetValue(obj))).DefaultIfEmpty(new ClienteJuridico { NomeOuRazaoSocial = "Invalido", Cnpj = "00000000000000", Email = "invalido@invalido.com", Senha = "000000" });
                string first = cliJuridico.First().ToString();
                if (first.Contains("Invalido"))
                {
                    Console.WriteLine("Novo Cliente Juridico inserido com sucesso: \n" + obj.ToString());
                    Listas.ListCliente.Add(obj as ClienteJuridico);
                }
                else
                {
                    Console.WriteLine("Cliente já consta na lista: \n" + first);
                }
            }
        }
    }
}