using System;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [StringLength(500)]
        public string? Summary { get; set; }

        [StringLength(200)]
        public string? Author { get; set; }

        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;

        [Url]
        public string? ImageUrl { get; set; }
        // ✅ Add this property
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
