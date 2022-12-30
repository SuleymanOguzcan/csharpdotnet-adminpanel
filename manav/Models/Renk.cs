using System.ComponentModel.DataAnnotations;

namespace manav.Models
{
    public class Renk
    {
        [Key]
        public int RenkID { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Renk Adı"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string RenkAdı { get; set; }
    }
}