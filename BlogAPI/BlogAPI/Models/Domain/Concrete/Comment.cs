using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlogAPI.Models.Domain.Concrete
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(5000)]
        public string Text { get; set; }

        public string AuthorId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(AuthorId))]
        public Member? Author { get; set; }

        public List<Comment>? Comments { get; set; }

    }
}

