using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BusinessLayer
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "must be less than 20 symbols!")]
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Genre> Genres { get; set; }

        private Game()
        {

        }
        public Game(string name)
        {
            Name = name;
            Users = new List<User>();
            Genres = new List<Genre>();
        }
    }
}
