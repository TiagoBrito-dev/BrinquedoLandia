using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BrinquedoLandia.Enums;

namespace BrinquedoLandia.Entidades
{
    public class Produto
    {
        [Required(ErrorMessage ="Erro: Nome do produto é obrigatorio.", AllowEmptyStrings = false)]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Erro: Preço é obrigatorio.", AllowEmptyStrings = false)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid price")] // nao permite mais de duas casas decimais
        [DataType(DataType.Currency)]
        public string Preco { get; set; }

        public string Categoria { get; set; }

        public Produto()
        {
        }

        public Produto(string nomeProduto, string preco, string categoria)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
            Categoria = categoria;
        }

        public double PrecoDouble()
        {
            return double.Parse(Preco, CultureInfo.InvariantCulture);
        }

        public CategoriaProduto CategoriaEnum()
        {
            return (CategoriaProduto)Enum.Parse(typeof(CategoriaProduto), Categoria);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Produto: " + NomeProduto + " - Categoria: " + CategoriaEnum() + " - Preço: " + PrecoDouble().ToString("F2", CultureInfo.InvariantCulture) + " $");
            return sb.ToString();
        }
    }
}
