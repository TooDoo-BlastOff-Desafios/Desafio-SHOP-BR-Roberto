using EComerce.Models;
using Shopping.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Compra
    {
        [Key]
        [Display(Name = "Id")]
        public int Id{ get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Codigo Rastreamento")]
        public int Cod { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Valor Total")]
        [DataType(DataType.Currency)]
        public double ValorTotal { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Forma de Pagamento")]
        public EPagamento Pagamento { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Quantidade")]
        public uint Quantidade { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Client")]
        [Column("ClientCPF")]
        [ForeignKey("ClientCPF")]
        public String ClientCPF { get; set; }

        public virtual Client? Client { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Correio")]
        [Column("CorreioId")]
        [ForeignKey("CorreioId")]
        public Int32 CorreioId { get; set; }

        public virtual Correio? Correio{ get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Product")]
        [Column("ProductId")]
        [ForeignKey("ProductId")]
        public Int32 ProductId { get; set; }

        public virtual Product? Product{ get; set; }

    }
}
