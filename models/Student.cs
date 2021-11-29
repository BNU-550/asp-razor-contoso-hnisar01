using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace asp_razor_contoso.models
{
    public class Student
    {
        public int StudentID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        [DisplayName("Enrol Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// Relationships or navigation properties
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }

}
