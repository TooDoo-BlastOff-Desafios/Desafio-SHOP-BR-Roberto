using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Correio
    {
        [Display(Name = "ID")]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Prazo")]
        public int Prazo { get; set; }

        [Required(ErrorMessage = "O Campo está Vazio")]
        [Display(Name = "Valor")]
        public double Valor { get; set; }
    }
}
