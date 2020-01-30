using System;

namespace Dog_SPL
{
    class DogRun
    {

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.setName("Zeus");
            dog.setAge(4);

            Console.WriteLine("The dogs name is " + dog.getName());
            Console.WriteLine(dog.getName() + " is " + dog.getAge() + " human years old.");
            Console.WriteLine(dog.getName() + " is " + dog.getDogYears() + " dog years old.");
            Console.WriteLine("The Dogs information: " + dog.ToString());

        }
    }
}