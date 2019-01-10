using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4构造方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby babyGouDan = new Baby("狗蛋");
            Baby babyXiaoWang = new Baby();

        }
    }
    ///孩子刚出生或者还没出生,父母或其他长辈就会给起个名字,当然也有出生后起名字的
  public  class Baby
    {
      public  Baby(string name)
        {
            System.Console.WriteLine(name);
        }
       public Baby()
        {
            System.Console.WriteLine("剑圣无名");
        }

    }
}
