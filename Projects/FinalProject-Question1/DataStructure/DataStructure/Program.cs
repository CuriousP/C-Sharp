using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            atoi();
            StackImplementsArray.pushKey(10);
            PopKey();
            StackImplementsArray.pushKey(20);
            PopKey();
            StackImplementsArray.pushKey(30);
            StackImplementsArray.pushKey(40);
            PopKey();
            StackImplementsArray.pushKey(50);
            StackImplementsArray.pushKey(60);
            StackImplementsArray.pushKey(70);
            StackImplementsArray.pushKey(80);
            StackImplementsArray.pushKey(90);
            StackImplementsArray.pushKey(80);


            PopKey();
            PopKey();
            PopKey();
            PopKey();
            PopKey();
            PopKey();
            PopKey();
            Console.ReadLine();
        }

        static void PopKey()
        {
            int x = StackImplementsArray.popKey();
            if (x != -1)
            {
                Console.WriteLine("Poped " + x);
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        static void atoi()
        {
            string s = "12034";
            int result = 0;

            for(int i = 0; i< s.Length; i++)
            {
                char letter = s.ElementAt(i);
                result = 10 * result + ((int)letter - (int)'0');    
            }
            Console.WriteLine("Converion from a to i is " + result);
        }

        static void itoa()
        {
            int input = 1234;
            char result;
            string s;

            while ( input > 0)
            {
                int digit = input % 10;
                input = input / 10;
                result = (char)digit;
               
                 
            }
             

                        

        }
    }
}


