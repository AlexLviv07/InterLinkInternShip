using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipTest
{
    class Knowledge
    {
            public enum knowledgeLevel
            {
                Low, BelowMedium, Medium, AboveMedium, High
            }

            public knowledgeLevel level;

            public Knowledge(knowledgeLevel level)
            {
                this.level = level;
            }
        }
    }
