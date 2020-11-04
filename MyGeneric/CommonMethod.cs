using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public class CommonMethod
    {
        public static void ShowInt(int i)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name}," +
                $"para={i},type={i.GetType().Name}");
        }

        public static void ShowString(string s)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name}," +
                $"para={s},type={s.GetType().Name}");
        }

        public static void ShowDateTime(DateTime dt)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name}," +
                $"para={dt},type={dt.GetType().Name}");
        }

        //很多不同的数据类型,一直写?

        /// <summary>
        /// object是一切类型的基类
        /// 问题:性能问题(装箱和拆箱),安全问题(任何类型都可以传递)
        /// </summary>
        /// <param name="o"></param>
        public static void ShowObject(object o)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name}," +
                $"para={o},type={o.GetType().Name}");
        }

        /// <summary>
        /// T:泛型参数,占位符
        /// 声明的时候不确定类型,调用的时候确定
        /// 一个方法满足不同类型的需求
        /// 泛型的实现不单单是语法糖,他需要JIT和编译器同时升级才能实现
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void ShowT<T>(T t)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name}," +
                $"para={t},type={t.GetType().Name}");
        }
    }
}
