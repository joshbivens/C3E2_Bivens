using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.Major = "Computer Programming";

            Console.WriteLine("My Major is {0}.", myStudent.Major);
        }
    }
}
