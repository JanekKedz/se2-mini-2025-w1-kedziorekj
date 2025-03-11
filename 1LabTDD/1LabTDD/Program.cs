using System.Diagnostics;
using static _1LabTDD.TestClass;

namespace _1LabTDD
{
    internal class Program
    {
        public class CalcClass
        {
            public CalcClass() { }

            public int Calc(string s)
            {
                IEnumerable<Char> allowedChars = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', ',', '\n' };
                String result = new(
                  s.Select(x => !allowedChars.Contains(x) ? ' ' : x).ToArray()
                );
                int sum = 0;

                if (result.Length == 0)
                    sum = 0;
                else if (result.Count(f => f == ',' || f == '\n') == 0)
                {
                    isNegative(result);
                    if (moreThanTousand(result))
                        sum = 0;
                    sum = Int32.Parse(s);
                }
                else if (result.Count(f => f == ',' || f == '\n') > 0)
                {
                    string[] arr = Array.ConvertAll(result.Split([',', '\n']), p => p.Trim());
                    foreach (string str in arr)
                    {
                        isNegative(str);
                        if (!moreThanTousand(str))
                            sum += Int32.Parse(str);
                    }
                }
                return sum;
            }

            private void isNegative(string s)
            {
                if (s.Length > 1)
                    if (Int32.Parse(s) < 0)
                        throw new ArgumentException();
            }

            private bool moreThanTousand(string s)
            {
                if (s.Length > 3)
                    if (Int32.Parse(s) > 1000)
                        return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            CalcClassTest test = new();
            test.CalcTest();
        }
    }
}
