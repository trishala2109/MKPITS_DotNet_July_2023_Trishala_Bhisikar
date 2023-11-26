using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_3_HashTable_Student
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

            Hashtable ht = new Hashtable();
            ht.Add(s1,"");
            ht.Add(s2,"");
            ht.Add(s3,"");
           
            ICollection key = ht.Keys;
            foreach(Student stud in key)
            {
                Console.WriteLine("ID : " + stud.RollNo + " Name : " + stud.Name);
            }
            Console.ReadLine();
        }
    }
}