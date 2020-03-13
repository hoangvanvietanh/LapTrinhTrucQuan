using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    class IBMSoftware : Software
    {
        public IBMSoftware(int y) : base(y)
        {
            Console.WriteLine(m_x);

        }
        public IBMSoftware(string s, int f) : this(f)
        {
            Console.WriteLine(s);
        }
    }
}
