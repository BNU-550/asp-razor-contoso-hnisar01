using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace asp_razor_contoso.models
{
    public class Module
    {
        [Key, StringLength(6), Display(Name = "Code")]
        [RegularExpression("[A-Z](2)[0-9](3)")]

        public string ModuleID { get; set; }

        [StringLength(30), Required, MinLength(10)]
        public string Title { get; set; }
        public int Credit { get; set; } = 15;

        [StringLength(225)]
        public string Description { get; set; }

        public string FullTitle
        {
           get { return ModuleID + ": " + Title;}
        }

        //Navigation Properties

        public virtual ICollection<Course> Courses { get; set; }
    }   
               
}
