using System;
namespace Pets
{
    public class Dog : Pets
    {

        public Dog(string name2, string owner2, double weight2) : base("Dog", name2,owner2 , weight2)
        {
            name = name2;
            owner = owner2;
            weight = weight2;
        }

        public string bark(int count)
        {
            string bark = null;
            int i;
            for (i = 0; i < count; i++)
                bark += "bark!";
            return bark;

        }
    }
}

