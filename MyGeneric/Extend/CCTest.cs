using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.Extend
{
    /// <summary>
    /// 协变和逆变:只存在泛型接口和泛型委托
    /// </summary>
    public class CCTest
    {
        public static void Show()
        {
            {
                Bird b1 = new Bird();
                Bird b2 = new Sparrow();
                Sparrow b3 = new Sparrow();
                //Sparrow B4 = new Bird();
            }
            {
                List<Bird> list1 = new List<Bird>();
                List<Sparrow> list2 = new List<Sparrow>();
                //List<Bird> list3 = new List<Sparrow>();
                //编译器过不去,因为List<Sparrow>不是List<Bird>的子类
                List<Bird> list3 = new List<Sparrow>().Select(x => (Bird)x).ToList();
            }
            {
                //协变,out,只能作为输出
                //右边放子类
                //要求输出父类,我给它输出子类,更严格
                IEnumerable<Bird> birds1 = new List<Sparrow>();

                ICustomOut<Bird> birds2 = new CustomOut<Sparrow>();
            }
            {
                //逆变,in,只能作为输入
                //右边放父类
                //要求输入Bird,我给你输入Sparrow
                ICustomIn<Sparrow> birds = new CustomIn<Bird>();
            }
            {
                //协变,逆变
                IMyList<Sparrow, Bird> list = new MyList<Bird, Sparrow>();
            }
        }
    }

    public class Bird
    {
        public int Id { get; set; }
    }

    public class Sparrow : Bird
    {
        public string Name { get; set; }
    }

    public interface ICustomOut<out T>
    {
        T Get();
    }

    public class CustomOut<T> : ICustomOut<T>
    {
        public T Get()
        {
            return default(T);
        }
    }

    public interface ICustomIn<in T>
    {
        void Do(T t);
    }

    public class CustomIn<T> : ICustomIn<T>
    {
        public void Do(T t)
        {

        }
    }

    public interface IMyList<in inT, out outT>
    {
        outT Get();

        void Do(inT t);
    }

    public class MyList<inT, outT> : IMyList<inT, outT>
    {
        public outT Get()
        {
            return default(outT);
        }

        public void Do(inT t)
        {

        }

    }

}
