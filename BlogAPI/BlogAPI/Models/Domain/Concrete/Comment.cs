using BlogAPI.Models.Domain.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlogAPI.Models.Domain.Concrete
{
    public class Comment : AbstractComment
    {
        [Required]
        public int PostId { get; set; }
        [JsonIgnore]
        public List<SubComment>? SubComment { get; set; }

        [ForeignKey(nameof(PostId))]
        [JsonIgnore]
        public Post? Post { get; set; }

    }
}

