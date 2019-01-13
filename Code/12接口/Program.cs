using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor cangJingKong = new Actor("苍井空");
            cangJingKong.Perform();
            cangJingKong.Conjure();

            Magician liuQian = new Magician("刘谦");
            liuQian.Conjure();
            liuQian.Perform();
        }
    }
    /// <summary>
    /// 职业
    /// </summary>
   abstract class Profession
    {
        public Profession(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
    /// <summary>
    /// 演员
    /// </summary>
 class Actor : Profession, IPerform,IConjure
    {
        public Actor(string name) : base(name)
        {

        }
        public void Conjure()
        {
            System.Console.WriteLine(Name + ":我会变魔术(＾－＾)V~");
        }

        public void Perform()
        {
            System.Console.WriteLine(Name + ":我会演戏哦~");

        }
    }
    /// <summary>
    /// 魔术师
    /// </summary>
    class Magician : Profession, IConjure,IPerform
    {
        public Magician(string name) : base(name) { }
        public void Conjure()
        {
            System.Console.WriteLine(Name+":我会变魔术");
        }

        public void Perform()
        {
            System.Console.WriteLine(Name+":我也会表演.");

        }
    }
    /// <summary>
    /// 技能接口
    /// </summary>
    interface IPerform//表演
    {

        void Perform();//表演
    }
    interface IConjure//变魔术
    {
        void Conjure();//变魔术
    }
}
