using System.ComponentModel.DataAnnotations;

namespace manav.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Adı"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string Adı { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Soyadı"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} karakter olmalı.")]
        public string Soyadı { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Cinsiyet"), Range(1, 20, ErrorMessage = "{0} seçilmedi.")]
        public int CinsiyetID { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Medeni Hali")]
        public bool MedeniHali { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Doğum Tarihi"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}"), DataType(DataType.Date,ErrorMessage ="{0} Uygun Formatta Değil")]
        public DateTime DoğumTarihi { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "MobilNo"), StringLength(13, MinimumLength = 8, ErrorMessage = "{0} {2} - {1} karakter olmalı."), DataType(DataType.PhoneNumber, ErrorMessage = "{0} Uygun Formatta Değil")]
        public string MobilNo { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "İşe Giriş Tarihi"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}"), DataType(DataType.Date, ErrorMessage = "{0} Uygun Formatta Değil")]
        public DateTime İşeGirişTarihi { get; set; }

        [Required(ErrorMessage = "{0} Boş Olamaz."), Display(Name = "Görev"), Range(1, 100, ErrorMessage = "{0} seçilmedi.")]
        public int GörevID { get; set; }





        //Nagivasyon
        public Cinsiyet Cinsiyet { get; set; }
        public Görev Görev { get; set; }



    }
}
