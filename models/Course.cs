using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace asp_razor_contoso.models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(30)]
        [RegularExpression("[A-Z](2)[0-9][A-Z](3)[0-9](1)")]
        public int CourseID { get; set; }

        [StringLength(30), Required, MinLength(10)]
        public string Title { get; set; }

        public string FullTitle
        {
           get{ return " BSc (Hons) " + Title; } 
        }
        ///Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
    }

}
