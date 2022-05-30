using Shopping.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EComerce.Models
{
    public class Product
    {
        [Display(Name = "IDProduto")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Nome Produto")]
        [RegularExpression(@"^[a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ][\sa-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$", ErrorMessage = "Precisa ser apenas letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Tipo")] 
        public TipoPro Tipo { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Quantidade")]
        public int Quant { get; set; }

        

    }
}
