﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            // int number1 ;
            // int number2 = 100;
            // var result2 = Add3( out number1,number2);
            // //ref = referans tipe dönüştürmek için kullanılır
            //// var result = Add2( );
            //Console.WriteLine(result2);
            // Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));


            Console.ReadLine();
        }

        static void Add()
        {

            Console.WriteLine("Added!");


        }
        // void= işlem yapmak için kullanılır
        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;



        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;

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
        // params = Metohotumuza aynı tipte istediğimiz kadar parametre gönderebiliriz
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();



        }
    }
}

