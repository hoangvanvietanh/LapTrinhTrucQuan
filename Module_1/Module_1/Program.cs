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
                    case 11:
                        {
                            Console.Write("Basic");
                            Rectangle objRectangle = new Rectangle();
                            objRectangle.Length = 3;
                            objRectangle.Width = 4;
                            objRectangle.CalArea();
                            Console.WriteLine("{0}", objRectangle.Area);
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Array with Object");
                            IndexerClass b = new IndexerClass();
                            b[3] = 256;
                            b[5] = 1024;
                            for (int i = 0; i <= 10; i++)
                            {
                                Console.WriteLine("Element # {0} = {1}", i, b[i]);
                            }
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Polymorphic");
                            MicrosoftSoftware objMS = new MicrosoftSoftware();

                            IBMSoftware objIBM1 = new IBMSoftware(50);

                            IBMSoftware objIBM2 = new IBMSoftware("ssss", 75);

                            Console.ReadLine();
                            break;
                        }
                    case 14:
                        {
                            Console.Write("Inheritance");
                            Animal a1 = new Animal();
                            a1.Talk();
                            Dog d1 = new Dog();
                            d1.Talk();
                            break;
                        }
                    case 15:
                        {
                            Console.Write("Inheritance + virtual");
                            Animal objA = new Animal();
                            Dog objD = new Dog();
                            objA = objD;
                            objA.Talk2();
                            break;
                        }
                    case 16:
                        {
                            Console.Write("Inheritance + override");
                            Rectangles objRec = new Rectangles();
                            objRec.CalculateArea();
                            objRec.CalculateCircumference();
                            break;
                        }
                    case 17:
                        {
                            Console.Write("Interface");
                            Base obj = new Base();
                            obj.Print();
                            ITest ib = (ITest)obj;
                            ib.Print();
                            Base ojB = (Base)ib;
                            ojB.Print();
                            break;
        
                        }
                    default: break;
                }
            } while (number > 0 || number <= 17);


            Console.ReadLine();
        }
    }
}
