using System;
namespace Pets
{
    public class Cat : Pets
    {
        public Cat(string name3, string owner3, double weight3) : base("Cat", name3, owner3, weight3)
        {
            name = name3;
            owner = owner3;
            weight = weight3;
        }
        public string meow(int count)
        {
            string meow = null;
            int i;
            for (i = 0; i < count; i++)
                meow += "meow.";
            return meow;

        }
    }
}

