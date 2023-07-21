using System;
using System.Collections.Generic;

public class SportsLeagueModule
    {
        public event EventHandler<string> EnrollmentFull;


        public List<string> enrolledStudents = new List<string>();
        public List<string> waitingList = new List<string>();

        public string GameName { get; private set; }
        public int MaximumStudents { get; set; }

        public SportsLeagueModule(string gameName, int maximumStudents)
        {
            GameName = gameName;
            MaximumStudents = maximumStudents;

        }
        public string RegisterStudents(string studentName)
        {
            string output = "";
            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} is enrolled in {GameName} ";
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{GameName} enrollment is now full");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list in {GameName}";
            }
            return output;
        }
    }
