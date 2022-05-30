using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Team
    {
        public int Id { get; set; }
        [Display(Name = "İsim"), Required]
        public string Name { get; set; }
        [Display(Name = "Soyisim")]
        public string Surname { get; set; }
        [Display(Name = "Görevi")]
        public string Task { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
    }
}
