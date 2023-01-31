using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormOOP
{
    public class Classroom
    {
        private List<Person> Students = new List<Person>();
        public Classroom AddStudent(Person student)
        {
            Students.Add(student);
            return this;
        }
        public List<Person> GetData()
        {
            return Students;
        }
        public Dictionary<string, float> GetSortGPA()
        {
            Dictionary<string, float> gpa = new();
            int count = 0;
            foreach (Person person in Students.OrderBy(i => i.GetData()["GPA"]))
            {
                try
                {
                    gpa.Add(person.GetData()["Name"], float.Parse(person.GetData()["GPA"]));
                }
                catch 
                {
                    count += 1;
                    gpa.Add(person.GetData()["Name"]+"["+count+"]", float.Parse(person.GetData()["GPA"]));
                }
            }
            return gpa;
        }
        public float GetAvgStudents()
        {
            float gpa = 0;
            foreach (Person person in Students)
            {
                gpa += float.Parse(person.GetData()["GPA"]);
            }
            return (gpa / float.Parse(Students.Count.ToString()));
        }
        public int GetSumOfStudentAge()
        {
            int sum = 0;
            foreach(Person student in Students)
            {
                sum += int.Parse(student.GetData()["Age"]);
            };
            return sum;
        }
    }
}
