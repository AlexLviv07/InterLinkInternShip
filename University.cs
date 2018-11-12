using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipTest
{
    class University
    {
        String universityName;

        private List<Student> students = new List<Student>();

        public University(String name)
        {
            universityName = name;
        }

        public void setStudent(Student student)
        {
            //I don`t understand what this method should do
        }

        public List<string> getStudents()
        {
           return University.getStudents(students);
        }

        public static List<string> getStudents(List<Student> students)
        {
            List<string> studentsUniver = new List<string>();
            foreach (Student student in students)
            {
                studentsUniver.Add(student.ToString());
            }
            return studentsUniver;
        }

        public void addStudent(Student student)
        {
            this.students.Add(student);
        }

        public List<Student> getStudentArray()
        {
            List<Student> copyStudents = new List<Student>(students);
            return copyStudents;
        }

        public static University initialUniversity(string name)
        {
            University university = new University(name);
            university.addStudent(new Student("Andrew Kostenko", new Knowledge(Knowledge.knowledgeLevel.AboveMedium)));
            university.addStudent(new Student("Julia Veselkina", new Knowledge(Knowledge.knowledgeLevel.High)));
            university.addStudent(new Student("Maria Perechrest", new Knowledge(Knowledge.knowledgeLevel.Medium)));
            university.addStudent(new Student("Alex Valmosh", new Knowledge(Knowledge.knowledgeLevel.BelowMedium)));
            return university;
        }
    }
}
