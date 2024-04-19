using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task3
{
    class Comp : Component
    {
        private int val;

        private List<Component> children = new List<Component>();

        public Comp(int v)
        {
            this.val = v;
        }

        public override void Delete(Component C)
        {
            this.children.Remove(C);
        }

        public override void Insert(Component C)
        {
            this.children.Add(C);
        }

        public override void GetValue()
        {
            int result = 0;
            result += this.val;
            Console.Write($"[{this.val}](");
            for (int i = 0; i < this.children.Count; i++)
            {
                if (i == (this.children.Count - 1))
                {
                    this.children[i].GetValue();
                }
                else if (this.children[i] != null)
                {
                    this.children[i].GetValue();
                    Console.Write(", ");
                }
            }
            Console.Write(")");
        }
    }
}
