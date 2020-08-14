using System;
using System.Collections.Generic;
using System.Text;

namespace TestingRefQuiz
{
    public class TestingRefString
    {
        public string testing { get; set; }
        public string testing2 { get; set; }
        public TestingRefString(ref string test, ref string test2)
        {
            testing = test;
            testing2 = test2;
        }
    }
}
