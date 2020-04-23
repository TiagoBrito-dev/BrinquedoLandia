using BrinquedoLandia.MetodosExtensivos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoLandia.Entidades
{
    public class Endereco
    {
        [Required(ErrorMessage = "Erro: Obrigatorio informar logradouro.", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Erro: logradouro deve ter mais de 2 letras")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Erro: Obrigatorio informar numero.", AllowEmptyStrings = false)]
        [StringLength(5, MinimumLength = 1)]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Erro: Obrigadotio informar cidade.", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Erro: Obrigatorio informar cep.", AllowEmptyStrings = false)]
        [DataType(DataType.PostalCode, ErrorMessage = "Erro: cep incorreto")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Cep deve ter 8 numeros.")]
        public String Cep { get; set; }

        
        public Endereco()
        {
        }

        public Endereco(string logradouro, string numero, string cidade, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cidade = cidade;
            Cep = cep;
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---Endereço---");
            sb.AppendLine("Rua: " + Logradouro);
            sb.AppendLine("Numero: " + Numero);
            sb.AppendLine("Cidade: " + Cidade);
            sb.AppendLine("Cep: " + Cep.Cep());
            return sb.ToString();
        }
    }
}
