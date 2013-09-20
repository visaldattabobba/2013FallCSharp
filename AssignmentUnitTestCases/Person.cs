using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnitTestCases
{
    class Person
    {
        public string[] name;



        //Declare a Name property of type string:
        public string[] Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
