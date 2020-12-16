using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalExam final = new FinalExam(10, 1);
            final.ShowExam();
            
            Console.Read();
        }
    }
}
