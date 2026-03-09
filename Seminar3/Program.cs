using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }

    public class Student: Person
    {
        public int[] Marks { get; set; }

        public Student(string name, int age, int[] marks): base(name, age) 
        {
            Marks = marks;
        }

        public override string ToString()
        {
            return string.Format("Marks {0}",string.Join(", ", Marks));
        }

        public object Clone()
        {
            var newPerson = (Student)MemberwiseClone();

            newPerson.Marks = new int[Marks.Length];
            for(int i=0;i < Marks.Length;i++)
            {
                newPerson.Marks[i] = Marks[i];
            }

            return newPerson;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("name1", 21, new[] { 9, 8, 9 });
            Console.WriteLine(s1);

            var s2 = s1.Clone();
            s1.Marks[0] = 5;
            Console.WriteLine(s2);
        } //end of main

        
    } 
}
