using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComerce.Models
{
    public class Loja
    {
        [Display(Name = "ID")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nome")]
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Telefone")]
        [RegularExpression(@"^\(\d{2}\)9\d{4}\-\d{4}$", ErrorMessage = "O Formato do Telefone precisa ser (DD)9####-####")]

        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
