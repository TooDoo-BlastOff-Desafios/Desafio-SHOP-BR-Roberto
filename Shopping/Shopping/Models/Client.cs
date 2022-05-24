using E_Commerce.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Client
    {

        [Display(Name = "ID")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nome")]
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "CEP")]
        [RegularExpression(@"\d{5}-\d{3}")]
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
        public ENivel Nivel { get; set; } = ENivel.Nivel1;

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Telefone")]
        [RegularExpression(@"^\(\d{2}\)9\d{4}\-\d{4}$", ErrorMessage = "O Formato do Telefone precisa ser (DD)9####-####")]
        public string? Telefone { get; set; }


    }
}
