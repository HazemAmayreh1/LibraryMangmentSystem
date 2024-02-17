using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User 
    {
        [Key] public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Account UserAccount { get; set; }
        public ICollection<Book> Books { get; set; }




       
    }

}
