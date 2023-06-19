using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Singleton
{
    internal sealed class SingletonLogger
    {
        private static int instanceCount;

        // laziness + thread safety best and simple approach from .net 4 
        private static readonly Lazy<SingletonLogger> instance = new Lazy<SingletonLogger>(() =>
        {
            Console.WriteLine("some code to execute before initialization");
            return new SingletonLogger();
        });

       // public SingletonLogger()
        private SingletonLogger()
        {
            Console.WriteLine("Initializing constuctor");
            instanceCount++;
        }

        // new way to use getter (short form)
        public static SingletonLogger Instance => instance.Value;

        public void writelog(string message)
        {
            Console.WriteLine(message + " Instance Count=" + instanceCount);
        }


    }
}
