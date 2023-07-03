﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
        
            stack.Push("anita");
            stack.Push("anjali");
            stack.Push("vinika");
            stack.Push("roshni");

           stack.Pop(); //removes the top element in the collections

            Console.WriteLine($"Top element in the stack {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
