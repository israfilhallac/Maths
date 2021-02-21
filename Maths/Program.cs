using System;

namespace Maths
{
    class Program
    {
       

        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            fourOperations.Gather(5, 23);
            fourOperations.Sticker(20, 6);
            fourOperations.Multiplication(5, 6);
            fourOperations.Split(42,6);


        }
    }
}
