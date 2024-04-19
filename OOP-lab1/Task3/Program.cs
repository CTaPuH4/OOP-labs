using System.Numerics;

namespace OOP_task3
{
    class Program
    {
        static void Main(String[] args)
        {
            Comp test1 = new Comp(10);
            Comp test2 = new Comp(20);
            Comp test3 = new Comp(30);
            Leaf a = new Leaf(3);
            Leaf b = new Leaf(1);
            Leaf c = new Leaf(8);
            test1.Insert(a);
            test1.Insert(test2);
            test2.Insert(b);
            test3.Insert(c);
            test2.Insert(test3);
            test1.GetValue();
        }
    }
}