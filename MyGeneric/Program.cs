using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGeneric.Extend;

namespace MyGeneric
{
    /// <summary>
    /// 1.引入泛型
    /// 2.泛型的声明和使用
    /// 3.泛型的原理和好处
    /// 4.4种泛型
    /// 5.5种约束
    /// 6.泛型缓存
    /// 7.协变和逆变
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 888;
            string s = "Test";
            DateTime dt = DateTime.Now;

            CommonMethod.ShowInt(i);
            CommonMethod.ShowString(s);
            CommonMethod.ShowDateTime(dt);

            CommonMethod.ShowObject(i);
            CommonMethod.ShowObject(s);
            CommonMethod.ShowObject(dt);

            //语法糖,编译器自动推算
            CommonMethod.ShowT(i);
            CommonMethod.ShowT(s);
            CommonMethod.ShowT(dt);

            Console.WriteLine(typeof(Dictionary<,>));

            //性能测试
            //Monitor.Show();

            ISports japan = new Japanese();
            //GenericConstraint.Show(japan);
            People hubei = new HuBei();
            GenericConstraint.Show(hubei);

            GenericCacheTest.Show();

            Console.ReadLine();
        }
    }
}
