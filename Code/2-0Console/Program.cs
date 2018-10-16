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
            Class1.Men man = new Class1.Men();
            man.Eat();
            Women woman = new Women();
            Women.Girl girl = new Women.Girl();
            girl.Speak();
            NameSpacedDemo nameSpacedDemo = new NameSpacedDemo();
        }
    }
}
