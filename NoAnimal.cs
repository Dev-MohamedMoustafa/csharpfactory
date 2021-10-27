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
    public class NoAnimal : IAnimal
    {
        public string Name { get; set; }

        public string MakeSound(string sound)
        {
            return "No Animal Selected Yet";
        }
    }
}
