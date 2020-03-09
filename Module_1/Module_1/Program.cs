using System;

namespace Module_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            ExerciseInModule_1 module1 = new ExerciseInModule_1();
            Console.Clear();
            do
            {

                Console.Write("Choose the exercise: ");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1: module1.Exercise_1(); break;
                    case 2: module1.Exercise_2(); break;
                    case 3: module1.Exercise_3(); break;
                    case 4: module1.Exercise_4(); break;
                    case 5: module1.Exercise_5(); break;
                    case 6: module1.Exercise_6(); break;
                    case 7: module1.Exercise_7(); break;
                    case 8: module1.Exercise_8(); break;
                    case 9: module1.Exercise_9(); break;
                    case 10: module1.Exercise_10(); break;
                    default: break;
                }
            } while (number > 0 || number <= 10);


            Console.ReadLine();
        }
    }
}
