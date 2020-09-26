using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EighthDay
{
    class AsynCall
    {
        /*
        static void Main(string[] args)
        {
            Student student1 = new Student(ConsoleColor.Red, "Zyq1");
            Student student2 = new Student(ConsoleColor.Green, "Zyq2");
            Student student3 = new Student(ConsoleColor.White, "Zyq3");

            Action action1 = new Action(student1.DoHomework);
            Action action2 = new Action(student2.DoHomework);
            Action action3 = new Action(student3.DoHomework);

            action1 += action2;
            action1 += action3;
            action1.Invoke();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Main work !!!");
                Thread.Sleep(1000);
            }
        }
        */
    }

    public class Student
    {
        public ConsoleColor PenColor { get; set; }
        public string Name { get; set; }

        public Student(ConsoleColor color,string name)
        {
            Name = name;
            PenColor = color;
        }

        public void DoHomework()
        {   
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = PenColor;
                Console.WriteLine($"{Name} DoHomework {i} hour(s)");
                Thread.Sleep(1000);
            }
        }
    }
}
