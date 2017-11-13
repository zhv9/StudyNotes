using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // 接口
    interface IFly
    {
        void Fly();
    }
    interface ILanguage
    {
        void Speak();
    }

    // 继承关系 空心三角形
    class Bird : Animal{

    }
    // 实现接口 空心三角形 + 虚线
    class WideGoose : IFly{

    }
    // 关联关系 实线箭头
    class Penguin : Bird{
        private Climate climate; // 在企鹅中，引用气候Climate对象。
    }
    // 聚合(拥有)关系 空心菱形加箭头
    class WideGooseAggregate{
        private WideGoose[] arrayWideGoose; // 在雁群类中，有大雁数组对象arrayWideGoose。
    }
    // 组合(拥有)关系 实心菱形加箭头
    class Bird
    {
        private Wing wing;
        public Bird{
            wing = new Wing(); // 在鸟类中，初始化时，实例化翅膀Wing，他们之间同时生成
        }
    }
    // 依赖关系 用虚线箭头表示
    abstract class Animal{
        public Metabolism(Oxygen oxygen, Water water){
            // 动物依赖氧气和水
        }
    }
}
