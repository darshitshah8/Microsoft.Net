﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeworkEF.Models
{
    public class Person
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]

        public string LastName { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Employer> Employers { get; set; } = new List<Employer>();
    }
}
