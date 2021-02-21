using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class FourOperations
    {
        public void Gather(int number1,int number2)
        {
            int total = number1 + number2;
            Console.WriteLine("Sonuc :" +total);
        }
        public void  Sticker(int number1,int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Sonuc :" + result);
        }
        public void Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Sonuc :" + result);
        }

        public void Split(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Sonuc :" + result);
        }
    }
}
