using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric.Extend
{
    public class GenericCacheTest
    {
        public static void Show()
        {
            long commonCache = 0;
            long genericCache = 0;
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    string s1 = CommonCache.GetCache<int>();
                    string s2 = CommonCache.GetCache<string>();
                }
                watch.Stop();
                commonCache = watch.ElapsedMilliseconds;
            }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 100_000_000; i++)
                {
                    string s1 = GenericCache<int>.GetCache();
                    string s2 = GenericCache<string>.GetCache();
                }
                watch.Stop();
                genericCache = watch.ElapsedMilliseconds;
            }
            Console.WriteLine($"CommonCache:{commonCache},GenericCache:{genericCache}");
        }
    }

    /// <summary>
    /// 泛型缓存:根据传递的类型,生成不同的副本
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCache<T>
    {
        static string _cache;

        static GenericCache()
        {
            Console.WriteLine("GenericCache 静态构造函数");
            _cache = $"{typeof(T).FullName}_{DateTime.Now.ToString()}";
        }

        public static string GetCache()
        {
            return _cache;
        }
    }

    /// <summary>
    /// 字典缓存:静态字段,常驻内存
    /// </summary>
    public class CommonCache
    {
        /// <summary>
        /// 需要根据Type去hash计算string存储的位置
        /// </summary>
        private static Dictionary<Type, string> _Cache;

        static CommonCache()
        {
            Console.WriteLine("CommonCache 静态构造函数");
            _Cache = new Dictionary<Type, string>();
        }

        public static string GetCache<T>()
        {
            Type type = typeof(T);
            if (!_Cache.ContainsKey(type))
            {
                _Cache.Add(type, $"{type.FullName}_{DateTime.Now.ToString()}");
            }

            return _Cache[type];
        }
    }

}
