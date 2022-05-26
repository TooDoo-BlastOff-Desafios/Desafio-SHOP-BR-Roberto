using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Correio
    {
        [Display(Name = "IDCorreio")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Correio Prazo")]
        public int Prazo { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Valor")]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }
    }
}
