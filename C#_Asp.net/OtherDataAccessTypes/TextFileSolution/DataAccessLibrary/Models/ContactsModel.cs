﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ContactsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumber { get; set; } = new List<string>();
        public List<string> EmailAddresses { get; set; } = new List<string>();
    }
}
