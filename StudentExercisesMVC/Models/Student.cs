using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExecisesMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 3)]
        [Display(Name = "Slack Handle")]
        public string SlackHandle { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        //T his is to hold the actual foreign key integer
        [Display(Name = "Cohort")]
        public int CohortId { get; set; }

        // This property is for storing the C# object representing the department
        public Cohort Cohort { get; set; }
    }
}
