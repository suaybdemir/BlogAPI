using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogAPI.Models.Domain.Concrete
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string AuthorId { get; set; }
        public int? CommentId { get; set; }

        [Range(0, 200)]
        public string Title { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Range(0, 200000)]
        public string Text { get; set; }

        [ForeignKey(nameof(CommentId))]
        public List<Comment>? Comments { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Member Author { get; set; }


    }
}

