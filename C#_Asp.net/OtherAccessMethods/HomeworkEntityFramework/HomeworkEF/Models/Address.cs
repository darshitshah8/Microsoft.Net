using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeworkEF.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string City  { get; set; }
    }
}



