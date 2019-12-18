﻿using System;

namespace DotVVMCosmos.DAL.Entities
{
    public class Student
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
