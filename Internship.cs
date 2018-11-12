using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipTest
{
    class Internship
    {
        String intershipName;

        List<Student> students = new List<Student>();

        public Internship(String name)
        {
            intershipName = name;
        }

        public void addStudents(University university)
        {

            foreach (Student student in university.getStudentArray())
            {
                this.addStudent(student);
            }
        }

        public void addStudent(Student student)
        {

            if ((student.KnowledgeStud.level == Knowledge.knowledgeLevel.AboveMedium) || (student.KnowledgeStud.level == Knowledge.knowledgeLevel.High))
            {
                students.Add(student);
            }
        }

        public void setStudent(Student student)
        {
            //I don`t understand what this method should do
        }

        public List<string> getStudents()
        {
            return University.getStudents(students);
        }
    }
}
