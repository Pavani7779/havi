using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student X = new student();
            X.name = " Gold";
            X.Age = 15;
            X.Telugu = 65;
            X.Hindi = 35;
            X.English = 35;
            X.Maths = 40;
            X.Science = 55;

            X.Login();
            

            student Y = new student();
            Y.name = "Silver";
            Y.Age = 25;
            Y.Telugu = 56;
            Y.Hindi = 40;
            Y.English = 36;
            Y.Maths = 58;
            Y.Science = 55;

            Y.Login();
            Console.ReadLine();
        }
         
    }
}
