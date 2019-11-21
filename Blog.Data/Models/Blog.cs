using Blog.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blog.Data.Models
{
    public class Blog : Entity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        [MaxLength(50)]
        [MinLength(1)]
        [Required]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }
         [Required]
        public int Hit { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
