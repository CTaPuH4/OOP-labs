using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task3
{
    class Leaf : Component
    {
        private int val;

        public Leaf(int v)
        {
            val = v;
        }

        public override void GetValue()
        {
            Console.Write(val);
        }

        public override void Delete(Component C)
        {
            Console.WriteLine("Leaf component has no children(((");
        }

        public override void Insert(Component C)
        {
            Console.WriteLine("Leaf component can't have children(((");
        }
    }
}
