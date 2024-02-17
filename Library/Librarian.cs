using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian
    {
       [Key] public int ID { get; set; }
        public string Name { get; set; }
        
        public string Password { get; set; }

        public ICollection<Book> books{ get; set; }


    }

}
