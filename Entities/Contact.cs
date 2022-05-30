using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "İsim"), Required]
        public string Name { get; set; }
        [Display(Name = "Soyisim")]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Telefon"), Required]
        public string Phone { get; set; }
        [Display(Name = "Mesaj"), Required]
        public string Message { get; set; }
        [Display(Name = "Mesaj Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now; // DateTime ın yanındaki ? işareti bu alanı nullable yani boş geçilebilir yapar. Bunu eklemezsek datetime türünün varsayılan değeri boş geçilemezdir! } = DateTime.Now; kısmı ise bu alana bir değer gönderilmezse o anki zamanı sistemden çekip kullanmasını sağlar.
    }
}
