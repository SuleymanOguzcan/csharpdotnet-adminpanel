using System.ComponentModel.DataAnnotations;

namespace manav.Models
{
    public class Cinsiyet
    {
        [Key]
        public int CinsiyetID { get; set; }

        
        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Cinsiyet Adı"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string CinsiyetAdı { get; set; }



    }
}
