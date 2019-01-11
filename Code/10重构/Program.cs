using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10重构
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheatgrass wheatgrass = new Wheatgrass("冰菜");
            wheatgrass.Breathe();

            Carrot carrot = new Carrot("胡萝卜");
            carrot.Breathe();
        }
    }
    /// <summary>
    /// 蔬菜
    /// </summary>
    class Vegetables
    {
        public string Name { get; set; }
        public Vegetables()
        {

        }
        public Vegetables(string name)
        {
            this.Name = name;
        }
        protected string color;
        public  void Breathe()
        {
            System.Console.WriteLine(Name+":呼吸");
        }
    }
    /// <summary>
    /// 冰菜/冰草
    /// </summary>
    class Wheatgrass : Vegetables
    {
        public Wheatgrass(string name):base(name)
        {
            base.color = "绿色";

        }

        ///水泡
        public string Blister { set; get; }

        //public override void Breathe()
        //{
        //    System.Console.WriteLine("冰菜:呼吸");
        //}
    }
    /// <summary>
    /// 胡萝卜
    /// </summary>
    class Carrot : Vegetables
    {
       
        public Carrot() : base()
        {

        }
        public Carrot(string name) : base(name)
        {

        }
        //public override void Breathe()
        //{
        //    System.Console.WriteLine("胡萝卜:呼吸");
        //}
    }

}

