using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6属性与修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "哮天犬";
            System.Console.WriteLine(dog.Name);


            ///因为我们为属性Age的 set方法前边加了private修饰符因此在外部无法给他赋值.
            //dog.Age = 1;
            int dogAge = dog.Age;
            System.Console.WriteLine(dogAge);
        }
    }
    public class Dog
    {
        string name;//字段
        public String Name
        {

            get
            { return name; }
            set
            { name = value; }
        }
       public int Age//属性的一种简写方式
        {
           private set;
            get;
        }
    }
}
