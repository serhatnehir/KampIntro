using System;

namespace MetotOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();

            //var result = Add2(4);

            //int number1 ; //değer tip değişkenin kendi ile ilgilenir - ref de değer verilmiş olmalı ama out da gerek yok
            //int number2 = 100;

            //var result2 = Add3(out number1, number2); //20, 100
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);


            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(2,3,4,5,6)); //istediğim kadar sayı yazabilirim

            Console.ReadLine(); // uygulama dursun diye
        }

        static void Add() // void git şu işlemi yap demek, bir yere bir şey yaz bir yere bir kayıt yap
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int x,  int number1 = 20, int number2=30) //30'u burada defoult parametre olarak kullandık
        { 
            var result= number1 + number2;
            return result;
        }


        static int Add3(out int number1, int number2) // 20, 100
        {
            number1 = 30; //burada başka değişken tanımlıyoruz
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers) //numbers numaralar - params ile istediğin kadar parametre gönderebilirsin
        {
            return numbers.Sum(); // dizideki bütün sayıları topla sonucuda return et
        }


    }
}
