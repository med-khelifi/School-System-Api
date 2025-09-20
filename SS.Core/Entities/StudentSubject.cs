using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Core.Entities
{
    public class StudentSubject
    {
        
        public int StudSubID { get; set; }
        public int StudID { get; set; }
        public int SubID { get; set; } 
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
