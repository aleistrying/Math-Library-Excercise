using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            float Cos = (float)Math.Cos(90 * Math.PI / 180);
            float Sin = (float)Math.Sin(90 * Math.PI / 180);

            Console.WriteLine(Cos + " cosine of 30");
            Console.WriteLine(Sin + " sin of 30");
            Console.ReadLine();
        }
    }
}
