using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.entity
{
    public class dbUser
    {
        [Key]
        public int id { get; set; }
        [Index(IsUnique = true)]
        [StringLength(200)]
        public string ad { get; set; }
        public int yas { get; set; }
        public string mail { get; set; }
        public string sifre { get; set; }
    }
}
