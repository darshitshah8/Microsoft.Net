using System;
using System.Collections.Generic;
using System.IO;

namespace MiniProjectDemo
{
    public class DataAccess<T> where T : new()
        {
            public event EventHandler<T> BadEntryFound;
            public  void SaveToCsv( List<T> items, string filePath) 
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
        public bool BadWordDetector(string stringToTest )
        {
            bool output = false;
            string lowerCaseTest =stringToTest.ToLower();
            if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
            {
                output = true;
            }
            return output;
        }
        }
    }

