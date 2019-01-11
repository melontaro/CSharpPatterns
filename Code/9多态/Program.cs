using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables vegetables = new Wheatgrass();
            vegetables.Breathe();
            //vegetables.Blister;
            

            Vegetables vegetables0 = new Carrot();
            vegetables0.Breathe();
        }
    }
    /// <summary>
    /// 蔬菜
    /// </summary>
    class Vegetables
    {
        public Vegetables()
        {

        }
        public Vegetables(string name)
        {

        }
        protected string color;
        public virtual void Breathe()
        {
            System.Console.WriteLine("Vegetables呼吸");
        }
    }
    /// <summary>
    /// 冰菜/冰草
    /// </summary>
    class Wheatgrass : Vegetables
    {
        public Wheatgrass() : base("冰菜")
        {
            base.color = "绿色";

        }

        ///水泡
        public string Blister { set; get; }

        public override void Breathe()
        {
            System.Console.WriteLine("冰菜:呼吸");
        }
    }
    /// <summary>
    /// 胡萝卜
    /// </summary>
    class Carrot : Vegetables
    {
        public Carrot() : base()
        {

        }
        public override void Breathe()
        {
            System.Console.WriteLine("胡萝卜:呼吸");
        }
    }

}

