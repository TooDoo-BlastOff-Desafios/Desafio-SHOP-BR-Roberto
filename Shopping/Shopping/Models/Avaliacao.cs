using EComerce.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Avaliacao
    {

        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Avaliação")]
        [Range(0, 5)]
        public int Nota { get; set; }


        [Display(Name = "Comentario")]
        public string? Comentario { get; set; }

        [Display(Name = "Client")]
        [Column("ClientCPF")]
        [ForeignKey("ClientCPF")]
        public String? ClientCPF { get; set; }

        public virtual Client? Client { get; set; }

        public virtual Correio? Correio { get; set; }

        [Column("ProductId")]
        [ForeignKey("ProductId")]
        public Int32 ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}
