﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFConsoleUI.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        public int ContactId { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string EmailAddress { get; set; }
    }
}
