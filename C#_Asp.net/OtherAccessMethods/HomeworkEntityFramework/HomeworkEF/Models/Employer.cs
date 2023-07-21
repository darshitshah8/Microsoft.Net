using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeworkEF.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string CompanyNames { get; set; }    
    }
}
