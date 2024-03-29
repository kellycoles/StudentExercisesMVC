﻿
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentExecisesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class StudentCreateViewModel
    {
        public Student Student { get; set; }
        public List<Cohort> Cohorts { get; set; } = new List<Cohort>();

        public List<SelectListItem> CohortOptions
        {
            get
            {
                if (Cohorts == null) return null;

                return Cohorts
                    .Select(c => new SelectListItem(c.CohortName, c.Id.ToString()))
                    .ToList();
            }
        }
    }
}
