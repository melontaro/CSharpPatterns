using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code
{
    class NameSpacedDemo
    {
    }
}
namespace NameSpace1
{
  public  class Women
    {
        string name;
        int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public class Girl
        {
            public void Speak()
            {
                Console.WriteLine("Speak");
            }
            class Lady
            {

            }
        }
    }
}