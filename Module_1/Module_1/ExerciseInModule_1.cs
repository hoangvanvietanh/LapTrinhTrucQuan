using System;
using System.Collections.Generic;
using System.Text;

namespace Module_1
{
    class ExerciseInModule_1
    {
        public void Exercise_1()
        {
            Console.WriteLine("=====Hello======");
            Console.WriteLine("Welcome to");
            Console.WriteLine("C# 2020 Programming!");
            Console.WriteLine("Programming by Viet Anh");
        }

        public void Exercise_2()
        {
            Console.WriteLine("=====Hello======");
            Console.WriteLine("{0}\n{1}", "Welcome to", "C# 2020 programming!");
            Console.WriteLine("Programming by Viet Anh");
        }

        public void Exercise_3()
        {
            Console.Clear();
            Console.WriteLine("======Sum=======");
            int number1, number2, sum = 0;

            Console.Write("{0}", "Enter number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine(number1 + " + " + number2 + " = " + sum);
        }

        public void Exercise_4()//_CalculateTheAreaOfTheRectangle
        {
            Console.Clear();
            Console.WriteLine("========Calculate The Area Of The Rectangle======");
            int length, width, acreage = 0, perimeter = 0;

            Console.Write("{0}", "Enter the length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width : ");
            width = Convert.ToInt32(Console.ReadLine());

            acreage = length * width;
            perimeter = (length + width) * 2;

            Console.WriteLine("Your perimeter: " + perimeter);
            Console.WriteLine("Your acreage: " + acreage);
        }

        public void Exercise_5()//_CalculateFirstDegreeEquation
        {
            Console.Clear();
            Console.WriteLine("==========Calculate First Degree Equation=========");
            int a, b;

            Console.Write("{0}", "Enter number a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                Console.WriteLine("The equation has a unique solution: x = " + (-b / a));
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("The equation has countless solutions");
            }
            else
            {
                Console.WriteLine("The eqution has no solutions");
            }

        }

        public void Exercise_6()//_CalculateQuadraticEquation
        {
            Console.Clear();
            Console.WriteLine("=============CalculateQuadraticEquation===========");
            double a, b, c;
            double delta = 0;

            Console.Write("{0}", "Enter number a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("The equation has a unique solution: x = " + (-b / a));
                }
                else if (b == 0 && c == 0)
                {
                    Console.WriteLine("The equation has countless solutions");
                }
                else
                {
                    Console.WriteLine("The eqution has no solutions");
                }
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("The eqution has no solutions");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("The equation has a double solution: x1,2 = " + (-b / (2 * a)));
                }
                else
                {
                    Console.WriteLine("The equation has 2 distint solutions : ");
                    Console.WriteLine("x1 = " + (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x2 = " + (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }

        }

        public void Exercise_7()//_TrigonometricFunctions
        {
            Console.Clear();
            Console.WriteLine("==========Trigonometric Functions=======");
            int corner;

            Console.Write("{0}", "Enter a corner: ");
            corner = Convert.ToInt32(Console.ReadLine());

            double rad = corner * Math.PI / 180;
            Console.WriteLine("Sin " + "<" + corner + "> = " + Math.Sin(rad));
            Console.WriteLine("Cos " + "<" + corner + "> = " + Math.Cos(rad));
            Console.WriteLine("Tan " + "<" + corner + "> = " + Math.Tan(rad));
            Console.WriteLine("Cot " + "<" + corner + "> = " + (-Math.Tan(rad)));
        }

        public void Exercise_8()
        {
            Console.Clear();
            Console.WriteLine("======Calculate the area of the perimeter of a triangle=====");
            //_PerimeterAreaOfaTriangle
            int a, b, c;

            Console.Write("{0}", "Enter edge a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter edge b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter edge c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a >= b + c || b >= a + c || c >= a + b)
                Console.WriteLine("Ba canh vua nhap khong phai la canh cua tam giac");
            else
            {
                Console.WriteLine("Your perimeter: " + perimeter(a, b, c));
                Console.WriteLine("Your acreage: " + acreage(a, b, c));
            }
        }

        public float perimeter(int a, int b, int c)
        {
            return a + b + c;
        }
        public double acreage(int a, int b, int c)
        {
            float p = perimeter(a, b, c) / 2;
            return Convert.ToDouble(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }


        public void Exercise_9()
        {
            Console.Clear();
            Console.WriteLine("=======Calculate the sum of series========");
            int x, n;

            Console.Write("{0}", "Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i) / CalculateFactorial(i);
            }

            Console.WriteLine("S<{0},{1}> = {2}", x, n, sum);
        }

        public float CalculateFactorial(int x)
        {
            int f = 1;
            for (int i = 1; i <= x; i++)
            {
                f = f * i;
            }

            return f;
        }

        public void Exercise_10()
        {
            Console.Clear();
            Console.WriteLine("=====Solve the system of equations 2 hidden======");
            float a1, b1, c1;
            float a2, b2, c2;



            Console.WriteLine("Enter the correct structure below !!!");
            Console.WriteLine("|aX + bY = c");
            Console.WriteLine("|a'X + b'Y = c'");

            Console.Write("{0}", "Enter a: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a': ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b': ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c': ");
            c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("|{0}X + {1}Y = {2}", a1, b1, c1);
            Console.WriteLine("|{0}X + {1}Y = {2}", a2, b2, c2);
            float D = 0, Dx = 0, Dy = 0;

            //Phương pháp Cramer
            D = a1 * b2 - a2 * b1;
            Dx = c1 * b2 - c2 * b1;
            Dy = a1 * c2 - a2 * c1;
            Console.WriteLine("Results: ");
            Console.WriteLine("|x = {0}", Dx / D);
            Console.WriteLine("|y = {0}", Dy / D);
        }
    }
}
