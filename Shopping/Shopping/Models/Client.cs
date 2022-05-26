
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Client
    {

        [Display(Name = "CPFCliente")]
        [Key]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$",ErrorMessage ="Formato do CPF ###.###.###-##")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nome Cliente")]
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "CEP")]
        [RegularExpression(@"\d{5}\-\d{3}",ErrorMessage ="Formato do CEP #####-###")]
        public string CEP { get; set; }

        [Required(ErrorMessage ="O Campo está Vazio")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nivel")]
        public int Nivel { get; set; } = 1;

        [Display(Name = "Telefone")]
        [RegularExpression(@"^\(\d{2}\)9\d{4}\-\d{4}$", ErrorMessage = "O Formato do Telefone precisa ser (DD)9####-####")]
        public string? Telefone { get; set; }

        [Column("QuantidadeCompras")]
        public int Quant { get; set; }



    }
}
