using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection_Queue_Student
{
    class Student
    {
        public int RollNo;
        public string Name;
        public Student(int RollNo, string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(63, "Amit");
            Student s2 = new Student(23, "Sumit");
            Student s3 = new Student(24, "Ajit");

            Queue q = new Queue();
            q.Enqueue(s1);
            q.Enqueue(s2);
            q.Enqueue(s3);

            Console.WriteLine("------Before Dequeue-------");
            foreach(Student s in q)
            {
                Console.WriteLine("Roll No. : " + s.RollNo);
                Console.WriteLine("Name : " + s.Name);
                Console.WriteLine();
            }

            q.Dequeue();
            Console.WriteLine();
            Console.WriteLine("------After Dequeue-------");
            foreach (Student s in q)
            {
                Console.WriteLine("Roll No. : " + s.RollNo);
                Console.WriteLine("Name : " + s.Name);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
