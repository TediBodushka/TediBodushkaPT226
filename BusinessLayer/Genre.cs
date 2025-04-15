using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BusinessLayer
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "name must be less than 20 symbols!")]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        private Genre()
        {

        }
        public Genre(string name)
        {
            Name = name;
            Users = new List<User>();
        }
    }
}
