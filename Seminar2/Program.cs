using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Person: IComparable<Person>
    {
        //attributes
        private int _age;
        private string _name;
        private string _mail;

        //methods
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        public int getAge()
        {  
            return _age;
        }

        public void setAge(int age)
        {
            this._age = age;
        }

        public string Name
        { 
            get {  return _name; }
            set {  _name = value; }
        }

        public string Mail
        { 
            get { return _mail; } 
            set { _mail = value; } 
        }

        public Person(int age)
        {
            Console.WriteLine("I am the constructor with int argument.");
            this._age = age;
        }
        public Person(int age, string name, string mail):this(age)
        {
            Console.WriteLine("I am the constructor with 3 arguments");
            _name = name;
            _mail = mail;
        }

        public Person(Person p1): this(p1.getAge(),p1.Name,p1.Mail)
        {
            Console.WriteLine("I am the copy constructor");
        }

        public static bool operator <(Person a, Person b)
        {
            Console.WriteLine("I am < operator");
            return a.getAge() < b.getAge();
        }

        public static bool operator >(Person a, Person b)
        {
            Console.WriteLine("I am > operator");
            return a.getAge() > b.getAge();
        }
       
        //in class we had to do a problem to get the real and imaginary part of a number

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(5, "Ana", "ana@mail.com");
            Person p2 = new Person(7, "Maria", "maria@mail.com");
            Person p3 = new Person(6, "Mihai", "mihai@mail.com");

            var pArray = new Person[] { p1, p2, p3 };
            Array.Sort(pArray);
            Console.WriteLine(p1 < p2);

            for(int i = 0; i < pArray.Length; i++)
            {
                Console.WriteLine(pArray[i].Name);
            }
        }
    }
}
