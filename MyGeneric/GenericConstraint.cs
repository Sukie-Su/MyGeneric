using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 约束好处:
    /// 1.加了约束可以获取更多的功能
    /// 2.避免错误调用
    /// </summary>
    public class GenericConstraint
    {
        public static void ShowObject(object oPara)
        {
            //只能调用object类型的方法
            //C#是强类型语言,编译时确定类型
        }

        public static void Show<T>(T t)
            //where T : ISports
            where T : People
        {
            //t.PingPang();
            Console.WriteLine(t.Id);
            Console.WriteLine(t.Name);
        }

        public static void GenericShow1<T>(T t)
            //where T : class//引用类型
            //where T:struct//值类型
            where T : new()//无参构造函数
        {
            T newT = new T();
        }

        public static T GenericShow2<T>()
        {
            return default(T);
        }

        public static void GenericShow3<T>(T t)
            where T : ISports, new()//支持多个约束,用逗号隔开
        {

        }

    }
}
