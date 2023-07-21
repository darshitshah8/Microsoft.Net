using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TextFileDataAccess 
    {
        public List<ContactsModel> ReadAllRecords(string textFile)
        {
            if (File.Exists(textFile) == false)
            {
                return new List<ContactsModel>();
            }

            var lines = File.ReadAllLines(textFile);
            List<ContactsModel> output = new List<ContactsModel>();
            foreach (var line in lines) 
            {
                ContactsModel c = new ContactsModel();

                var vals = line.Split(",");
                if (vals.Length<4)
                {
                    throw new Exception($"Invalid row of data {line}");
                }
                c.FirstName = vals[0];
                c.LastName = vals[1];
                c.EmailAddresses = vals[2].Split(';').ToList();
                c.PhoneNumber = vals[3].Split(';').ToList();
                output.Add(c);                
            }
            return output;
        } 
        public void WriteAllRecords(List<ContactsModel> contacts, string textFile)
        { 
            List<string> lines = new List<string>();
            foreach (var c in contacts)
            {
                lines.Add($"{c.FirstName},{c.LastName},{String.Join(';',c.EmailAddresses)},{String.Join(';', c.PhoneNumber)}");
            }

            File.WriteAllLines(textFile,lines);
        }  
    }
}

















//public string ConvertListOfStringToString(List<string> input,string delimitor)
//{
//    return string.Join(delimitor, input);
//}