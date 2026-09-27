using System.ComponentModel.DataAnnotations;

namespace atssistem.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string imgurl { get; set; }
        [Required]
        public string isbaslik { get; set; }
        [Required]
        public string departman { get; set; }
        [Required]
        public string calismasekli { get; set; }

    }
}
