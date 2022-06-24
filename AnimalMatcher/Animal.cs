using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMatcher
{
    internal class Animal
    {
        private string name;
        private int age;
        private string location;
        private string bio;

        public Animal(
            string name,
            int age,
            string location,
            string bio)
        {
            this.name = name;   
            this.age = age; 
            this.location = location;   
            this.bio = bio;
        }
            


    }
}
