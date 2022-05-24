using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComerce.Models
{
    public class Product
    {
        [Display(Name = "ID")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nome")]
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Tipo")] 
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Quantidade")]
        public double Quant { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "IDLoja")]
        [ForeignKey("Loja")]
        public int LojaId { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Loja")]
        public Loja Loja { get; set; }

    }
}
