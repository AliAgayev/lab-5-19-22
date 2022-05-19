using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("1-ci ededi daxil edin: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"{firstNumber} ile {secondNumber} ededleri arasindaki ededlerin toplami = {sum}");
            #endregion

            #region Task2
            Console.WriteLine("1-ci ededi daxil edin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int count = 0;
            int avg = 0;
            for (int i = number1; i <= number2; i++)
            {
                total = total + i;
                count++;      
            }
            avg = total / count;
            Console.WriteLine($"{number1} ile {number2} ededlerinin ededi ortasi = {avg}");
            #endregion

            #region Task3
            bool isContiniue = true;
            string sorgu = "";
            do
            {
                Console.WriteLine("Yasinizi daxil edin: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 18)
                {
                    Console.WriteLine("Texniki Ingilis dili balini daxil edin: ");
                    int engPoint = Convert.ToInt32(Console.ReadLine());
                    if (engPoint > 50)
                    {
                        Console.WriteLine("Tebrikler siz kursa qeydiyyata alindiniz");

                        Console.WriteLine("Basqa telebe varmi? he/yox");
                        sorgu = Console.ReadLine().ToLower();
                        if (sorgu=="he")
                        {
                            isContiniue = true;
                        }
                        else
                        {
                            isContiniue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sizin texniki ingilis dili baliniz 50-den az olduguna gore qeydiyyata alina bilmediniz");
                        Console.WriteLine("Basqa telebe varmi? he/yox");
                        sorgu = Console.ReadLine().ToLower();
                        if (sorgu == "he")
                        {
                            isContiniue = true;
                        }
                        else
                        {
                            isContiniue = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Yasiniz 18-den az olduguna gore qeydiyyata alina bilmediniz");
                }
            } while (isContiniue);
           
            #endregion

            #region Task4
            Console.WriteLine("1-ci ededi daxil edin: ");
            int numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil edin: ");
            int numberSecond = Convert.ToInt32(Console.ReadLine());
            int oddNumberSum = 0;
            for (int i = numberFirst; i < numberSecond; i++)
            {
                if (i%2!=0)
                {
                    oddNumberSum = oddNumberSum + i;
                }
            }
            Console.WriteLine($"{numberFirst} ile {numberSecond} ededleri arasindaki tek ededlerin cemi = {oddNumberSum}");
            #endregion

        }
    }
}
