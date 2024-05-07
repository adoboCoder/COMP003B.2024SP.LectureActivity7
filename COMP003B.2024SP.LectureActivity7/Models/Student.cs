﻿using System.ComponentModel.DataAnnotations;

namespace COMP003B._2024SP.LectureActivity7.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Collection navigation property
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
