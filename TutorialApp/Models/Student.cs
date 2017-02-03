using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // property will become the primary key column of the database table
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        // enrollments is a navigation property that can hold multiple entries
        // 
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}