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
            University university = new University("CH.U.I.");
            university.addStudent(new Student("Andrew Kostenko", new Knowledge(Knowledge.knowledgeLevel.AboveMedium)));
            university.addStudent(new Student("Julia Veselkina", new Knowledge(Knowledge.knowledgeLevel.High)));
            university.addStudent(new Student("Maria Perechrest", new Knowledge(Knowledge.knowledgeLevel.Medium)));

            Student studentUniver = new Student("Alex Valmosh");
            studentUniver.KnowledgeStud = new Knowledge(Knowledge.knowledgeLevel.BelowMedium);
            university.addStudent(studentUniver);
            Console.WriteLine("List of university's students:");
            university.getStudents();

            Console.WriteLine("------------------------------------------------------");

            Internship internship = new Internship("Interlink");
            internship.addStudents(university);
            Console.WriteLine("List of internship's students:");
            internship.getStudents();
            Console.WriteLine("------------------------------------------------------");
            Student studentInern = new Student("Anton Pylypenko");
            studentInern.KnowledgeStud = new Knowledge(Knowledge.knowledgeLevel.AboveMedium);
            internship.addStudent(studentInern);
            Console.WriteLine("List of internship's students after add new student:");
            internship.getStudents();
        }
    }
}
