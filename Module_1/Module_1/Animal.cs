using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Talk2()
        {
            Console.WriteLine("Animal talk");
        }

    }
}
