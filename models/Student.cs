using System;
using System.Collections.Generic;

namespace asp_razor_contoso.models
{
        public class Student
        {
            public int StudentID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateTime EnrollmentDate { get; set; }

            /// <summary>
            /// Relationships or navigation properties
            /// </summary>
            public virtual ICollection<Enrollment> Enrollments { get; set; }
        }
}
