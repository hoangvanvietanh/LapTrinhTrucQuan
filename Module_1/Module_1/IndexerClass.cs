using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    class IndexerClass
    {
		private int[] myArray = new int[100];
		public int this[int index]
		{
			get
			{
				if(index < 0 || index >= 100)    return 0;
		   else
					return myArray[index];
			}
			set
			{
				if (!(index < 0 || index >= 100))
					myArray[index] = value;
			}
		}

	}
}
