using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _1LabTDD.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1LabTDD
{
    class TestClass
    {
        public class CalcClassTest
        {
            public CalcClassTest() { }

            public void CalcTest()
            {

                //Given
                string s1 = "", s2 = "0", s3 = "32,4", s4 = "2\n21", s5 = "2,4\n5", s6 = "-5", s7 = "500,1025", s8 = "//40,6", s9 = "//[50,60]", s10 = "//[500],[250]";
                CalcClass cc = new CalcClass();

                //When

                //1 Lenght of input is 0, return 0
                //2 Input is a number, return the number
                //3 Input is two numbers separated with coma, return the sum
                //4 Input is two numbers separated with newLine, return the sum
                //5 Input is numbers separated with both comas and/or newLines, return the sum
                //6 Input contains a negative number, throw ArgumentException
                //7 Input contains numbers bigger than 1000, ignore them
                //8,9,10 Input contains slashes at the beginning and brackets in different configurations? I am sorry I do not remember it exactly.

                //Then
                Debug.Assert(Equals(cc.Calc(s1), 0));
                Debug.Assert(Equals(cc.Calc(s2), 0));
                Debug.Assert(Equals(cc.Calc(s3), 36));
                Debug.Assert(Equals(cc.Calc(s4), 23));
                Debug.Assert(Equals(cc.Calc(s5), 11));

                bool exceptionThrown = false;
                try
                {
                    cc.Calc(s6);
                }
                catch (ArgumentException)
                {
                    exceptionThrown = true;
                }
                Debug.Assert(exceptionThrown);

                Debug.Assert(Equals(cc.Calc(s7), 500));
                Debug.Assert(Equals(cc.Calc(s8), 46));
                Debug.Assert(Equals(cc.Calc(s9), 110));
                Debug.Assert(Equals(cc.Calc(s10), 750));
            }
        }
    }
}

