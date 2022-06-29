using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2979910#content
namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var random = new Random();

            const int ARRAYLENGTH = 10; //can't use var
            var buffer = new char[ARRAYLENGTH];

            for (int i = 0; i < ARRAYLENGTH; i++)
            {
                buffer[i] = ((char)(random.Next(97, 123)));
                //Console.WriteLine((char)(('a'+ random.Next(0, 26))));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
            Console.ReadLine();


            //Console.WriteLine((int)'a');// ASCII 'a' is 97
            //Console.WriteLine(Convert.ToChar(random.Next(97, 123)));
            //Console.WriteLine((char)(random.Next(97, 123)));


            for (int i = 0; i < ARRAYLENGTH; i++)
            {
                Console.Write((char)(random.Next(97, 123)));
                Console.WriteLine((char)(('a' + random.Next(0, 26))));
            }
            Console.ReadLine();
        }
    }
}