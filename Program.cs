using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and fill new university
            University university = University.initialUniversity("CH.U.I.");

            //Create and fill new internship
            Internship internship = new Internship("Interlink");
            internship.addStudents(university);
            
           //Add new internship`s student
            Student studentInern = new Student("Anton Pylypenko");
            studentInern.KnowledgeStud = new Knowledge(Knowledge.knowledgeLevel.AboveMedium);
            internship.addStudent(studentInern);

            List<string> studentsUniver, studentsIntern;
            //List of university's students
            studentsUniver = university.getStudents();
            //List of internship's students
            studentsIntern = internship.getStudents();
        }
    }
}
