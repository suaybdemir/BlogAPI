using BlogAPI.Models.Domain.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlogAPI.Models.Domain.Concrete
{
    public class SubComment : AbstractComment
    {
        [Required]
        public int CommentId { get; set; }
        [ForeignKey(nameof(CommentId))]
        [JsonIgnore]
        public Comment? Comment { get; set; }
    }
}
