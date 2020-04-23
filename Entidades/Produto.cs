using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace BrinquedoLandia.Entidades
{
    class Produto
    {
        [Required(ErrorMessage ="Erro: Nome do produto é obrigatorio.", AllowEmptyStrings = false)]
        public string NomeProduto { get; set; }
        [Required(ErrorMessage = "Erro: Preço é obrigatorio.", AllowEmptyStrings = false)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Erro: Invalid price")] //permite apenas duas casas decimais
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Produto: " + NomeProduto + " - Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " R$");
            return sb.ToString();
        }
    }
}
