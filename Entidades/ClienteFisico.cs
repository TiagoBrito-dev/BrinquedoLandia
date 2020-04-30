using BrinquedoLandia.Interfaces;
using BrinquedoLandia.MetodosExtensivos;
using BrinquedoLandia.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    public class ClienteFisico : Cliente
    {
        [Required(ErrorMessage = "Erro: É obrigatorio informar CPF.", AllowEmptyStrings = false)]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Erro: CPF deve ter 11 digitors.")]
        public string Cpf { get; set; }       

        public ClienteFisico()
        {
        }

        public ClienteFisico(Object obj)
        {

        }


        public ClienteFisico(string nomeOuRazaoSocial, string email, string senha, string cpf) : base(nomeOuRazaoSocial, email, senha)
        {
            Cpf = cpf;
        }

        
        public override void InsereEnderco()
        {
            Endereco obj = new Endereco();
            PreencheObjeto.InsereDadosObjeto<Endereco>(obj);            
            ListEnd.Add(obj);
        }

        public override void ExibeEndereco()
        {
            Console.WriteLine("Cliente: " + NomeOuRazaoSocial + "\nEndereços:\n");
            foreach (Endereco obj in ListEnd)
            {
                Console.WriteLine(obj.ToString());
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + NomeOuRazaoSocial);
            sb.AppendLine("Cpf: " + Cpf.Cpf());
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Senha: " + Senha);
            return sb.ToString();
        }

        public override void SerializaEnderecos()
        {
            SerializaObjeto.Serializar<Endereco>(ListEnd);
        }
        
    }
}
