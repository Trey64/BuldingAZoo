using System;

namespace lab04tom
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**Here are some characteristics of grizzly bears**");
            Bears grizzly = new Bears("brown", "picnic baskets", true); //instantiation of object
            grizzly.Sound = "Grizzly bears roar"; //inherited from base class Animal
            grizzly.Viviparous(); //inherited from abstract class Mammals, which is derived from base class Animal
            grizzly.AnimalNoise(); //inherited from base class Animal
            Console.WriteLine($"The grizzly bear has {grizzly.Color} fur"); //inherited from Bears class, which is derived from Mammals, which is derived from base class Animal

            Console.WriteLine();
            Console.WriteLine("**Here are some characteristics of panda bears**");
            Bears panda = new Bears("black and white", "bamboo", false); //instantiation of object
            panda.Eat(); //abstract method inherited from base class Animal
            panda.BearMunchies(); //inherited from Bears class, which derives from abstract class Mammals, which is derived from base class Animal
            panda.Hibernate(); //inherited from Bears class, which inherits abstract method from abstract class Mammals, which is derived from base class Animal

            Console.WriteLine();
            Console.WriteLine("**Here are some characteristics of rattlesnakes**");
            Snakes rattlesnake = new Snakes(); //instantiation of object
            rattlesnake.Legs = 0; //inherited from base class Animal
            rattlesnake.NumberOfLegs(); //inherited from base class Animal
            rattlesnake.Oviparous(); //inherited from abstract class Reptiles
            rattlesnake.ShedSkin(); //inherited from Snakes class, which derives from Reptiles, which derives from base class Animal

            Console.WriteLine();
            Console.WriteLine("**Here are some characteristics of anacondas**");
            Snakes anaconda = new Snakes(); //instantiation of object
            anaconda.Sound = "Anacondas hiss"; //inherited from base class
            anaconda.AnimalNoise(); //inherited from base class
            anaconda.SleepWithEyesOpen(); //inherited from Snakes class, which inherits abstract method from Reptiles class, which is derived from base class Animal
            anaconda.HasColdBlood(); //inherited from Reptiles class, which is derived from base class Animal

            Console.WriteLine();
            Console.WriteLine("**Here are some characteristics of geckos**");
            Lizards gecko = new Lizards(); //instantiation of object
            gecko.HasColdBlood(); //inherited from Reptiles class, which is derived from base class Animal
            gecko.ChangesColor = false; //inherited from Lizards class, derived from Reptiles, derived from base class Animal
            gecko.HasCamo(); //inherited from Lizards class, derived from Reptiles, derived from base class Animal
            gecko.Oviparous(); //inherited from Reptiles class, which is derived from base class Animal


            Console.WriteLine();
            Console.WriteLine("**Here are some characteristics of chameleons**");
            Lizards chameleon = new Lizards(); //instantiation of object
            chameleon.ChangesColor = true; //inherited from Lizards class, derived from Reptiles, derived from base class Animal
            chameleon.HasCamo(); //inherited from Lizards class, derived from Reptiles, derived from base class Animal
            chameleon.Eat(); //inherited from base class
            chameleon.Legs = 4; //inherited from base class
            chameleon.NumberOfLegs(); //inherited from base class

            Console.Read();
        }
    }
}
