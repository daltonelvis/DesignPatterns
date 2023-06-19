// See https://aka.ms/new-console-template for more information
using DesignPatterns.DesignPatterns.Builder;
using DesignPatterns.DesignPatterns.Factories.SimpleFactory;
using DesignPatterns.DesignPatterns.Singleton;

Console.WriteLine("-------------Design patterns start--------------");

BuilderTest.TestBuilderexample();

Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);

FactoryTest.TestSimpleFactory();

FactoryTest.TestFactoryMethod();

FactoryTest.TestAbstractFactory();

Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);

SingletonTest.TestSingleTon();


