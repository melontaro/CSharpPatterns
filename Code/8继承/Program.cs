using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheatgrass wheatgrass = new Wheatgrass();
            wheatgrass.Blister = "晶莹剔透的水泡";
            System.Console.WriteLine(wheatgrass.Blister);

            Carrot carrot = new Carrot();

            System.Console.WriteLine(carrot is Vegetables);
        }
    }
    /// <summary>
    /// 蔬菜
    /// </summary>
    class Vegetables
    {
       public Vegetables()
        {
            System.Console.WriteLine("实例化 蔬菜");
        }
        public Vegetables(string name)
        {
            System.Console.WriteLine("实例化 蔬菜名字为"+name);
        }
        protected string color;
        public void Breathe()
        {
            System.Console.WriteLine("Vegetables呼吸");
        }

    }
    /// <summary>
    /// 冰菜/冰草
    /// </summary>
    class Wheatgrass:Vegetables
    {
       public Wheatgrass() : base("冰菜")
        {
            base.color = "绿色";
            System.Console.WriteLine(base.color);
        }

      ///水泡
        public  string Blister { set ; get; }

    }
    /// <summary>
    /// 胡萝卜
    /// </summary>
   class Carrot:Vegetables
    {
        public Carrot() : base()
        {
            System.Console.WriteLine("我是胡萝卜");
        }
    }

}
