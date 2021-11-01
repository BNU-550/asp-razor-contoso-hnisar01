using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace asp_razor_contoso.models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        ///Navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}
