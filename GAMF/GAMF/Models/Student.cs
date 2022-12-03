using System.ComponentModel.DataAnnotations;

namespace GAMF.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Családnév")]
        public string LastName { get; set; }

        [Display(Name = "Keresztnév")]
        public string FirstMidName { get; set; }

        [Display(Name = "Első jelentkezés")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }

}
