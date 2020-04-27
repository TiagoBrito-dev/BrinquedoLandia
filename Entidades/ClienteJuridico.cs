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
    class ClienteJuridico : Cliente
    {
        [Required(ErrorMessage = "Erro: Cnpj é obrigatorio", AllowEmptyStrings = false)]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Erro: Cnpj deve ter 14 digitos sem caracteres especiais.")]
        public string Cnpj { get; set; }

        public ClienteJuridico()
        {
        }

        

        public ClienteJuridico(string nomeOuRazaoSocial, string email, string senha, string cnpj) : base(nomeOuRazaoSocial, email, senha)
        {
            Cnpj = cnpj;
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
            sb.AppendLine("Razao Social: " + NomeOuRazaoSocial);
            sb.AppendLine("Cnpj: " + Cnpj.Cnpj());
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Senha: " + Senha);
            return sb.ToString();
        }

       
        public override void SerializaEnderecos()
        {
            SerializaObjeto.Serializar<Endereco>(ListEnd);
        }

        public override string ExibeNotaFiscalCliente(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
