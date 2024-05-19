using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task1();
            foreach (var item in t)
            {
                Console.WriteLine(item + ": " + item.Job);
            }

            var t2 = LinqTasks.Task2();
            foreach (var item in t2)
            {
                Console.WriteLine(item + ": " + item.Job + ": " + item.Salary);
            }
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);

            var t4 = LinqTasks.Task4();
            foreach (var item in t4)
            {
                Console.WriteLine(item + ": " + item.Job + ": " + item.Salary);
            }

            LinqTasks.Counter += 4;

            var t5 = LinqTasks.Task5();
            t5.Print();

            var t6 = LinqTasks.Task6();
            t6.Print();

            var t7 = LinqTasks.Task7();
            t7.Print();

            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);

            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);

            LinqTasks.Counter += 2;
            var t10 = LinqTasks.Task10();
            t10.Print();

            var t11 = LinqTasks.Task11();
            t11.Print();

            var t12 = LinqTasks.Task12();
            t12.Print();

            var t13 = LinqTasks.Task13([1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1]);
            Console.WriteLine(t13);

            Console.WriteLine("--Task 14--");
            var t14 = LinqTasks.Task14();
            Console.WriteLine(t14);
            foreach (var item in t14)
            {
                Console.WriteLine(item.Dname + ": " + item.Deptno);
            }

            LinqTasks.Counter += 2;

            var t15 = LinqTasks.Task15();
            t15.Print();

            Console.WriteLine("--Task 16--");
            var t16 = LinqTasks.Task16();
            foreach (var item in t16)
            {
                Console.WriteLine(item.Dname + ": " + item.Deptno + ": " + item.Loc);
            }
        }
    }
}
