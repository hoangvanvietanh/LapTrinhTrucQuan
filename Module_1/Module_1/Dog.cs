using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    class Dog : Animal
    {
		public Dog()
		{
			Console.WriteLine("Dog constructor");
		}
		public new void Talk()
		{
			Console.WriteLine("Dog talk");
		}
		public override void Talk2()
		{
			Console.WriteLine("Dog talk");
		}

	}
}
