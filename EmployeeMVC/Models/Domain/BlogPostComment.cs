﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeMVC.Models.Domain
{
    public class BlogPostComment
    {
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid BlogPostId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
