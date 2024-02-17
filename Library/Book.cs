using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
       [Key] public int id_book {  get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publication { get; set; }
        public string Status{ get; set; }
        public DateTime? datatimeborrowd { get; set; }
        public DateTime? datatimereturnd { get; set; }

        public int librariansID { get; set; }
        [ForeignKey("librariansID")]
        public Librarian Librarian { get; set; }
        public int ? UserId { get; set; }
        [ForeignKey("UserId")]
        public User ? user { get; set; }






    }

}
