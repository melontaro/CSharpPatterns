using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3类与实例
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Eat();
        }
        /// <summary>
        /// class 表示定义类的关键字
        /// people 就是类的名称
        /// Eat是类的方法
        /// 注意事项:
        /// 1.类名称,方法名称需要大写,多个单词首字母大写
        /// 2.公开的方法用public
        /// 3.实例,就是一个真实的对象,实例化就是创建对象的过程,使用new关键字来创建
        /// </summary>
        class People
        {
            public void Eat()
            {
                Console.WriteLine("人吃东西.");
            }

        }
    }
}
