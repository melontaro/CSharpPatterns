using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat("骨头");
            List<string> foods = new List<string>() { "鸡块","牛柳","脆骨","烤馒头"};
            dog.Eat(foods);

        }
    }

  public  class Dog
    {
        public void Eat(string foodName)
        {
            System.Console.WriteLine(foodName);
        }

        public void Eat(List<string> foods)
        {
            for (int i = 0; i < foods.Count; i++)
            {
                System.Console.WriteLine(foods[i]);
            }
        }

    }
}
