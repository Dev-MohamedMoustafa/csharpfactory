/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Factory
    {
        public static IAnimal CreateInstance(string animal)
        {
            if (animal == "Dog")
            {
                return new Dog();
            }
            else if (animal == "Cat")
            {
                return new Cat();
            }
            else
            {
                return new NoAnimal();
            }
        }
    }
}
