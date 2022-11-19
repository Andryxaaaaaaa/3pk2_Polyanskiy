using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    internal class TestClass
    {
        double x = 30;
        double y= 2;
        public void information()
        {
            Console.WriteLine($"x = {x}\ty = {y}");
            Console.WriteLine($"результат = {stepen(x, y)}");
        }
        public double stepen(double x, double y)
        {
            double result = Math.Pow(x, y);
            return result;
        }
    }
}
