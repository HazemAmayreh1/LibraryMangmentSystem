using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Account
    {

        [Key]  public  int Accid  { get; set; }

        [ForeignKey(nameof(accountID))]
        int accountID;

        public int no_borrowed_books { get; set; }
        public int no_late_books { get; set; }
        public int no_returned_books { get; set; }
        public int no_lost_books { get; set; }
        public double? fine_amount { get; set; }
        public int userid { get; set; }
        [ForeignKey("userid")]
        public User User { get; set; }

        

    }

}
