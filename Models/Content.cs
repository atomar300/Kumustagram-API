using System;
using System.Collections.Generic;

namespace Kumustagram_API.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string? Caption { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<int> Likes { get; set; } = new List<int>();
        public List<Comment> Comments { get; set; } = new List<Comment>();  // reference to Comment

        public int UserId { get; set; } // foreign key

        public User User { get; set; } // reference to User


    }
}
