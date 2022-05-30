using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EComerce.Models;

namespace Shopping.Models
{
    public class Estoque
    {
        [Display(Name = "IDProduto")]
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Loja")]
        [Column("LojaId")]
        public Int32 LojaId { get; set; }

        public virtual Loja? Loja { get; set; }


        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Product")]
        [Column("ProductId")]
        public Int32 ProductId { get; set; }

        public virtual Product? Product { get; set; }



    }
}
