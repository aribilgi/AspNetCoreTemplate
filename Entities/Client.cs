using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
    }
}
