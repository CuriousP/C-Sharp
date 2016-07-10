using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackImplementsArray
    {
        static int[] arr = new int[5];
        static int numElement = 0;
        static int lastElement;

        public static void pushKey(int key)
        {
            if (numElement < arr.Length)
            {
                arr[numElement] = key;
                numElement++;
                Console.WriteLine("pushed element " + key);
            }
            else
            {
                Console.WriteLine("Stack capacity reached");
            }
        }

        public static int popKey()
        {
            if (numElement == 0)
            {                
                return -1;
            }

            else 
            {
                lastElement = arr[numElement - 1];
                numElement--;
                return lastElement;
            }
            
        }
    }
}







