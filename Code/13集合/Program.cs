using System;
using System.Collections.Generic;
using System.Collections;

namespace _13集合
{
    class Program
    {
        static void Main(string[] args)
        {
            IList list = new ArrayList();
            list.Add("苍老师赛高!");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Cat());//添加的时候做了装箱操作
            arrayList.Add(new Dog());
            arrayList.Add(1);
            arrayList.Add("哈哈哈");
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                System.Console.WriteLine(arrayList[i].ToString());
            }

            Dog dog = (Dog)arrayList[1];//拆箱操作

        }
    }
    class Cat
    {

    }
    class Dog
    {

    }
}
