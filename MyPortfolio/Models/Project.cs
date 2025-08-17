using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Project
    {
     public int Id { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [Required, StringLength(2000)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Technologies { get; set; }

        [Url]
        public string? ImageUrl { get; set; }

        [Url]
        public string? GitHubUrl { get; set; }

        [Url]
        public string? LiveDemoUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
