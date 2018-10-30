using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InternShipTest
{
    class Student
    {
        private String name;
        private Knowledge knowledge;

        public Student(String name) : this(name, new Knowledge(Knowledge.knowledgeLevel.Low))
        {

        }
        public Student(String name, Knowledge knowledge)
        {
            this.name = name;
            this.KnowledgeStud = knowledge;
        }
        public Knowledge KnowledgeStud
        {
            get {
                return knowledge; }
            set
            {
                knowledge = value;
            }
           
        }


        public void getStudent()
        {
            Console.WriteLine("Student " + name + " has level knowlge " + this.knowledge.level);
        }

    }
}
