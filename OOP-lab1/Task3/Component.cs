using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task3
{
    public abstract class Component
    {
        public Component() { }

        public virtual void Delete(Component C)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(Component C)
        {
            throw new NotImplementedException();
        }

        public virtual void GetValue()
        {
            throw new NotImplementedException();
        }

    }
}
