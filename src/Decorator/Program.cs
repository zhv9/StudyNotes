using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Decorator
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // 先用ConcreteComponent实例化对象c
            // 然后用ConcreteComponentA的实例化对象d1包装c
            d1.SetComponent(c);
            // 再用ConcreteComponentB的实例化对象d2包装d1
            d2.SetComponent(d1);
            //最终执行d2的Operation()
            d2.Operation();

            Console.Read();
        }
    }
}
