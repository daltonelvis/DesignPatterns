using DesignPatterns.DesignPatterns.Factories.AbstractFactory;
using DesignPatterns.DesignPatterns.Factories.Common;
using DesignPatterns.DesignPatterns.Factories.Factory_Method;
using DesignPatterns.DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Singleton
{
    internal class SingletonTest
    {
        public static void TestSingleTon()
        {

            Console.WriteLine("------------Singleton design pattern----------------");

            //SingletonLogger obj1 = new SingletonLogger();
            //obj1.writelog("first call");

            //SingletonLogger obj2 = new SingletonLogger();
            //obj1.writelog("first call");

            //SingletonLogger obj3 = new SingletonLogger();
            //obj1.writelog("first call");

            SingletonLogger obj1 = SingletonLogger.Instance;
            obj1.writelog("first call");

            SingletonLogger obj2 = SingletonLogger.Instance;
            obj2.writelog("second call");

            SingletonLogger obj3 = SingletonLogger.Instance;
            obj3.writelog("third call");


        }   

    }
}
