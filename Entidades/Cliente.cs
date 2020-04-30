using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrinquedoLandia.Entidades
{
    public abstract class Cliente
    {
        [Required(ErrorMessage = "Erro: Nome / Razao Social é obrigatorio", AllowEmptyStrings = false)]
        public string NomeOuRazaoSocial { get; set; }

        [Required(ErrorMessage = "Erro: Email é obrigatorio.", AllowEmptyStrings = false)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Erro: Obrigatorio criar senha", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Erro: Senha deve possuir 6 digitos")]
        public string Senha { get; set; }
        public List<Endereco> ListEnd { get; set; } = new List<Endereco>();
        public List<Pedido> ListPedido { get; set; } = new List<Pedido>();

        protected Cliente()
        {
        }

        protected Cliente(Object obj)
        {

        }

        protected Cliente(string nomeOuRazaoSocial, string email, string senha)
        {
            NomeOuRazaoSocial = nomeOuRazaoSocial;
            Email = email;
            Senha = senha;
        }

        public abstract void InsereEnderco();
        public abstract void ExibeEndereco();
        public abstract void SerializaEnderecos();        
    }
}
