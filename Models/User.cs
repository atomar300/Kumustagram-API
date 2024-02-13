using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;


namespace Kumustagram_API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Password cannot be longer than 30 characters!")]
        public string Password { get; set; }
        public List<int> Followers { get; set; } = new List<int>();
        public List<int> Following { get; set; } = new List<int>();
        public string ResetPasswordToken { get; set; }
        public DateTime ResetPasswordExpire { get; set; }

        public List<Content> contents { get; set; } = new List<Content>();
    }
}
