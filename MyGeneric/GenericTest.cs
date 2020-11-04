using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T>
    {

    }

    public class GenericTest
    {
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public void GenericMethod<T>(T t)
        {

        }
    }

    /// <summary>
    /// 泛型接口
    /// </summary>
    /// <typeparam name="In"></typeparam>
    /// <typeparam name="Out"></typeparam>
    public interface IGeneric<In, Out>
    {
        Out Get();

        void Add(In @in);
    }

    /// <summary>
    /// 泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="t"></param>
    public delegate void GenericDelegate<T>(T t);
}
