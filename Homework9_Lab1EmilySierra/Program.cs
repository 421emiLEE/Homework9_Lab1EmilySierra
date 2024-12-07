using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1EmilySierra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document email = new Email("Text", "sender", "recipient", "title");
            Document email2 = new Email("Text", "sender", "recipient", "title");
            Document file = new File("Hello", "C:/Users/Emily S/Documents/test1.txt");
            Document file2 = new File("Hello", "C:/Users/Emily S/Documents/test1.txt");


            Console.WriteLine(ContainsKeyword(email, "Text"));
            Console.WriteLine(ContainsKeyword(email2, "Hello"));
            Console.WriteLine(ContainsKeyword(file, "Hello"));
            Console.WriteLine(ContainsKeyword(file2, "Hello"));







        }

        public static bool ContainsKeyword(Document docObject, string keyword)

        {

            if (docObject.ToString().IndexOf(keyword, 0) >= 0)

            {

                return true;

            }

            return false;
        }
    }
}
