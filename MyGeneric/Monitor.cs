using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public class Monitor
    {
        public static void Show()
        {
            int iValue = 12345;
            long commonMethod = 0;
            long objectMethod = 0;
            long genericMethod = 0;
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    ShowInt(iValue);
                }
                watch.Stop();
                commonMethod = watch.ElapsedMilliseconds;
            }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    ShowObject(iValue);
                }
                watch.Stop();
                objectMethod = watch.ElapsedMilliseconds;
            }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    ShowT(iValue);
                }
                watch.Stop();
                genericMethod = watch.ElapsedMilliseconds;
            }
            Console.WriteLine($"CommonMethod:{commonMethod},ObjectMethod:{objectMethod},GenericMethod:{genericMethod}");
        }

        private static void ShowInt(int i)
        {

        }

        private static void ShowObject(object o)
        {

        }

        private static void ShowT<T>(T t)
        {

        }


    }
}
