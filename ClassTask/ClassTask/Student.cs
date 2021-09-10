using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask
{
    class Student : Human
    {
        private float averageMarksF;
        private Marks status;

        public float AverageMarksF { set; get; }

        enum Marks
        {
            Excellent,
            Good,
            Normal,
            Bad,
            VeryBad
        }

    }
}
