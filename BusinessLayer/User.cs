using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "your name must be less than 20 symbols!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "your surname must be less than 20 symbols!")]
        public string LastName { get; set; }

        [Required]
        [Range(10, 80, ErrorMessage = "the age must be between 10 and 80!")]
        public int Age { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "username must be less than 20 symbols!")]
        public string Username { get; set; }

        [Required]
        [MaxLength(70, ErrorMessage = "your password cant be more than 70 symbols!")]
        public string Password { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "your email must be less than 20 symbols!")]

        public string Email { get; set; }

        public List<User> Friends { get; set; }
        public List<Game> Games { get; set; }

        private User()
        {

        }

        public User(string name, string lastName, int age, string username, string password, string email)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
            Email = email;
            Friends = new List<User>();
            Games = new List<Game>();
        }
    }
}

