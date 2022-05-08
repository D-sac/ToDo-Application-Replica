using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.entity
{
   public class dbCategory
    {
        [Key]
        public int cID { get; set; }
        public string cName { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public dbUser User { get; set; }

    }
}
