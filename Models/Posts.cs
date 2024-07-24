using System.ComponentModel.DataAnnotations;

namespace WebApiTutorial.Models
{
    public class Posts
    {
        [Required]
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Body { get; set; }
    }
}
