using System.ComponentModel.DataAnnotations;

namespace manav.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }


        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Kategori"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string KategoriAdı { get; set; }
    }
}