namespace Decorator
{
    // 定义一个对象接口，可以给这些对象动态地添加职责
    abstract class Component{
        public abstract void Operation();
    }

    // 定义了一个具体的对象，也可以给这个对象添加一些职责
    class ConcreteComponent : Component{
        public override void Operation(){
            System.Console.WriteLine("具体对象操作");
        }
    }

    // 装饰抽象类继承了Component，从外类来扩展Component类的功能，单对于Component来说，无需知道Decorator的存在的
    abstract class Decorator : Component{
        protected Component component;
        // 设置Component
        public void SetComponent(Component component){
            this.component = component;
        }

        // 重写Operation，实际执行的是Component的Operation
        public override void Operation(){
            if (component != null){
                component.Operation();
            }
        }
    }

    // 具体的装饰对象，起到给Component添加职责的功能
    class ConcreteDecoratorA : Decorator{
        // 本类独有功能，以区别于concreteDecoratorB
        private string addedState;
        public override void Operation(){
            // 首先运行原Component的Operation()
            base.Operation();
            // 再执行本类的功能，如addedState，相当于对原Component进行了装饰。
            addedState = "New State";
            System.Console.WriteLine("具体装饰对象A的操作");
        }
    }

    class ConcreteDecoratorB : Decorator{
        public override void Operation(){
            // 首先运行原Component的Operation()            
            base.Operation();

            // 再执行本类的功能，如AddedBehavior()
            AddedBehavior();
            System.Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior(){
            // 本类独有方法，区别于ConcreteDecoratorA
        }
    }
}