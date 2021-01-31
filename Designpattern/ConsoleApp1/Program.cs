using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SingletonWithMethod
    {
        private static SingletonWithMethod _singletonClass;

        private SingletonWithMethod()
        {

        }

        public static SingletonWithMethod GetInstance()
        {

            if (_singletonClass == null)
                _singletonClass = new SingletonWithMethod();
            return _singletonClass;
        }
    }

    static void Main(string[] args)
    {
        SingletonWithMethod singletonClass = SingletonWithMethod.GetInstance();

    }

}
