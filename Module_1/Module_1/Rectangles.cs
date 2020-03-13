using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
	class Rectangles : Shape
	{
		public Rectangles() 
		{
			m_Height = 20;
			m_Width = 30;
		}
	

		public override void CalculateArea()
		{
			Console.WriteLine("Area : {0}", m_Height * m_Width);
		}
		public override void CalculateCircumference()
		{
			Console.WriteLine("Circumference =  {0}", (m_Height + m_Width) * 2);
		}
		

	}
	interface ITest
	{
		void Print();

	}
	class Base : ITest
	{
		public void Print()
		{
			Console.WriteLine("Print method called");
		}
	}

}
