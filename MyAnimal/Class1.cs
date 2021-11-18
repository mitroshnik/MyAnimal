using System;
using System.Collections.Generic;
using System.Text;

namespace MyAnimal
{
    abstract class AbstractAnimal : Ianimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public AbstractAnimal(string name)
        {
            Name = name;
        }
        public abstract void Eat(string name);
    }
    class Cat : AbstractAnimal
    {
        public Cat(string name):base(name)
        {

        }
        public override void Eat(string name)
        {
            Console.WriteLine($"{name} поел");
        }
    }
    class Dog : AbstractAnimal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void Eat(string name)
        {
            Console.WriteLine($"{name} поел");
        }
    }
}
