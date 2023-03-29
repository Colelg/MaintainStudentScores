using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Scores { get; set; }


        public Student(string name, List<int> scores)
        {
            Name = name;
            Scores = scores;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            string score = string.Join(", ", Scores);
            return $"{Name} {score}";

        }

    }
}



