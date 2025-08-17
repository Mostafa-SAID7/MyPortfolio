
﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [StringLength(150)]
        public string Subject { get; set; }

        [Required, StringLength(1000)]
        public string Message { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        // ✅ Add this property
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    } }
