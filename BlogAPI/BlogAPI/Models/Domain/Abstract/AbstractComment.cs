using BlogAPI.Models.Domain.Concrete;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlogAPI.Models.Domain.Abstract
{
    public class AbstractComment
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(5000)]
        public string Text { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(AuthorId))]
        public Member? Author { get; set; }
    }
}
