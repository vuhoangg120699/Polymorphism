using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Problem2
{
    public abstract class Animals
    {
        protected Animals(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public string Name { get; set; }

        public string FavouriteFood { get; set; }

        public virtual string ExplainMyself()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
    public class Cat : Animals
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }
        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("MEEOW");
            return sb.ToString();
        }
    }
    public class Dog : Animals
    {
        public Dog(string name, string favouriteFood)
        : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("DJAAF");
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Cat("Pesho", "Whiskas");
            Animals dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());
            Console.ReadKey();
        }
    }
}
