using System;

namespace MyAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractAnimal Ivan = new Cat("Иван");
            Ivan.Eat("Иван");
            Console.ReadKey();
        }
    }
}
