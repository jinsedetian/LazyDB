using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDB
{
    /// <summary>
    /// 泛型单例模式
    /// </summary>
    public static class SingletonHelper<T> where T : class
    {
        private static T _instance;
        private static readonly object _lock = new object();
        /// <summary>
        /// 单例模式创建指定对象，如果已经存在则返回已创建对象
        /// </summary>
        /// <param name="paras">构造函数参数集合</param>
        /// <returns>实体</returns>
        public static T CreateInstance(object[] paras = null)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = (T)Activator.CreateInstance(typeof(T), paras);
                        return _instance;
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 释放
        /// </summary>
        public static void Dispose()
        {
            _instance = null;
        }
    }
}
