using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.entity
{
   public class dbContent
    {
        [Key]
        public int conID { get; set; }
        public string conName { get; set; }
        public string con_tent { get; set; }
        public DateTime conYear { get; set; }
        public DateTime ContentStartDate { get; set; }
        public DateTime ContentFinishDate { get; set; }

        [ForeignKey("dbCategory")]
        public int CategoryID { get; set; }
        public dbCategory dbCategory { get; set; }

    }
}
