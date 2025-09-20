using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS.Core.Entities
{
    public class Student
    {
        public Student()
        {
            StudentsSubjects = new HashSet<StudentSubject>();
        }
        
        public int StudID { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string Phone { get; set; }
        public int? DID { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<StudentSubject> StudentsSubjects { get; set; }
    }
}
