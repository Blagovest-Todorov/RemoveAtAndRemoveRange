using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListManupulation
{
    class Program
    {
        static void Main()
        {
            List<string> myAL = new List<string>();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("Lazy");
            myAL.Add("dog");

            //display the ArrayList

            Console.WriteLine("This is the Original List");
            Console.WriteLine(string.Join(' ', myAL));

            //myAL.RemoveRange(0,2);            

            int numberRemoveElem = 2;
            int startIdx = 0;            // 1 2 3  /  2 3 / 3

            //for (int i = 1; i <= numberRemoveElem; i++)
            //{
            //    myAL.RemoveAt(startIdx);
            //}

            myAL.RemoveRange(startIdx, numberRemoveElem);
            Console.WriteLine("After removing the values at the first two indexes, result is:");
            Console.WriteLine(string.Join(' ', myAL));
        }  //RemoveAt -removes an element at given index nur/
           // Remove Range 



    }
}
