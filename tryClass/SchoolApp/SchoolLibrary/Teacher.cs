using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public string PrintSomething()
        {
            var toReturn = "test shit";
            return toReturn;
        }

        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}
