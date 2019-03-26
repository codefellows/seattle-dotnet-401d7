using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
  abstract class CodeFellows : Graduation
    {
        public int NumberOfStudents { get; set; }
        public string InstructorName { get; set; }

        public override void Setup()
        {
            //set stuff up
        }

        public override void TearDown()
        {
           // tear stuff down
        }
        
        public void PresentDemo()
        {
            //presenting demo
        }
    }
}
