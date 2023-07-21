using DataAccessLibrary.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<PersonModel> ReadAllRecords(string textFile)
        {
            if (File.Exists(textFile) == false)
            {
                return new List<PersonModel>();
            }

            var lines = File.ReadAllLines(textFile);
            List<PersonModel> output = new List<PersonModel>();
            foreach (var line in lines)
            {
                PersonModel c = new PersonModel();

                var vals = line.Split(",");
                if (vals.Length < 4)
                {
                    throw new Exception($"Invalid row of data {line}");
                }
                c.FirstName = vals[0];
                c.LastName = vals[1];
                c.EmailAddress = vals[2];
                c.PhoneNumber = vals[3];
                output.Add(c);
            }
            return output;
        }
        public void WriteAllRecords(List<PersonModel> contacts, string textFile)
        {
            List<string> lines = new List<string>();
            foreach (var c in contacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{c.EmailAddress},{c.PhoneNumber}");
            }

            File.WriteAllLines(textFile, lines);
        }


    }
}
