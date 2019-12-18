using System;
using System.ComponentModel.DataAnnotations;

namespace DotVVMCosmos.Models
{
    public class StudentDetailModel
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        public string About { get; set; }

    }
}
