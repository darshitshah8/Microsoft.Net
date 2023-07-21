using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Darshit" , LastName = "Shah", },
                new PersonModel{FirstName = "jane" , LastName = "barbrah"},
                new PersonModel{FirstName = "leohell" , LastName = "gorge"}
            };
         

            DataAccess<PersonModel> peopleData = new DataAccess<PersonModel>();
            peopleData.BadEntryFound += People_BadEntryFound;

            peopleData.SaveToCsv(people, @"C:\Users\Darshit.Shah\source\repos\GenericsAndEvents\HomeworkMiniProjectApp\HomeworkMiniProject\CsvFiles\person.csv");

           
            Console.ReadLine();
        }

        private static void People_BadEntryFound(object sender, PersonModel e)
        {
            Console.WriteLine($"{e.FirstName} {e.LastName} is a bad word");
        }
    }

}
    public class DataAccess<T> where T : new()
    {
        public event EventHandler<T> BadEntryFound;
        public void SaveToCsv(List<T> items, string filePath)
        {
            List<string> rows = new List<string>();

            T entry = new T();
            var cols = entry.GetType().GetProperties();

            string row = "";
            foreach (var col in cols)
            {
                row += $", {col.Name}";
            }
            row = row.Substring(1);
            rows.Add(row);

            foreach (var item in items)
            {

                row = "";
                bool badWordDetector = false;
                foreach (var col in cols)
                {
                    string val = col.GetValue(item, null).ToString();
                    badWordDetector = BadWordDetector(val);
                    if (badWordDetector == true)
                    {
                        BadEntryFound?.Invoke(this, item);
                        break;
                    }
                    row += $", {val}";
                }

                if (badWordDetector == false)
                {
                    row = row.Substring(1);
                    rows.Add(row);
                }
            }
            File.WriteAllLines(filePath, rows);
        }
        public bool BadWordDetector(string stringToTest)
        {
            bool output = false;
            string lowerCaseTest = stringToTest.ToLower();
            if (lowerCaseTest.Contains("hell") || lowerCaseTest.Contains("danm"))
            {
                output = true;
            }
            return output;
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
