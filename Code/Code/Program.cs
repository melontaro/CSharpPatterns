using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NameSpace1;

namespace Code
{
    class Program
    { 
        static void Main(string[] args)
        {
            Men man = new Men();
            man.Eat();
            NameSpace1.Women woman = new NameSpace1.Women();
            NameSpace1.Women.Girl girl = new NameSpace1.Women.Girl();
            girl.Speak();
        }
        class Men
        {
            public void Eat()
            {
                Console.WriteLine("男人吃东西.");
            }

        }
    }
}
