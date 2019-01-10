using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7封装
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "小可爱";
            dog.Age = 1;
            dog.Eat();
        }
    }
    class Dog
    {
        public string Name { get; set; }
        int age;
      public  int Age
        {
            get { return age; }

            set { age = value; }
        }

        public  void Eat()
        {
            System.Console.WriteLine("eat food!");
        }
    }
}
