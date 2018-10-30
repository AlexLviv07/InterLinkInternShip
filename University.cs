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

        public void getStudents()
        {
            foreach (Student student in students)
            {
                student.getStudent();
            }
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
    }
}
