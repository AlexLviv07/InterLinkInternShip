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
        public void setKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }
        public Student(String name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }
       
    }
}
