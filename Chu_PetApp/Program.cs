using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chu_PetApp
{
    /* Class: Program
     * Author: Maxwell Chu
     * Purpose: Holds the main method
     * Restrictions: None
     */
    internal class Program
    {
        /* Method: Main
         * Purpose: Interacts with the user regarding pets
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            Pets pets = new Pets();
            Random rand = new Random();
            string userLicense = "";
            string userName = "";
            int userAge = 0;
            int selector = 0;
            for (int i = 0; i < 50; i++)
            {
                //1 in 10 chance of adding an animal
                if(rand.Next(1,11) == 1)
                {
                    if(rand.Next(0,2) == 0)
                    {
                        //add a dog
                        Console.WriteLine("You bought a dog!");
                        Console.WriteLine("Dog's Name =>");
                        userName = Console.ReadLine();
                        Console.WriteLine("Age =>");
                        while (!int.TryParse(Console.ReadLine(), out userAge))
                        {
                            Console.WriteLine("That's not an age.");
                        }
                        Console.WriteLine("License =>");
                        userLicense = Console.ReadLine();
                        pets.Add(new Dog(userLicense, userName, userAge));
                    }
                    else
                    {
                        //else add a cat
                        Console.WriteLine("You bought a cat!");
                        Console.WriteLine("Cat's Name =>");
                        userName = Console.ReadLine();
                        Console.WriteLine("Age =>");
                        while (!int.TryParse(Console.ReadLine(), out userAge))
                        {
                            Console.WriteLine("That's not an age.");
                        } 
                        pets.Add(new Cat());
                    }
                }
                else
                {
                    //choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0,pets.Count)];
                    if(thisPet == null)
                    {
                        
                    } else if (thisPet is Dog)
                    {
                        iDog = (IDog)thisPet;
                        selector = rand.Next(1, 6);
                        if(selector == 1)
                        {
                            iDog.Eat();
                        } 
                        else if (selector == 2)
                        {
                            iDog.Play();
                        }
                        else if (selector == 3)
                        {
                            iDog.Bark();
                        }
                        else if (selector == 4)
                        {
                            iDog.NeedWalk();
                        }
                        else if (selector == 5)
                        {
                            iDog.GotoVet();
                        }
                    } else if (thisPet is Cat)
                    {
                        iCat = (ICat)thisPet;
                        selector = rand.Next(1, 6);
                        if (selector == 1)
                        {
                            iCat.Eat();
                        }
                        else if (selector == 2)
                        {
                            iCat.Play();
                        }
                        else if (selector == 3)
                        {
                            iCat.Purr();
                        }
                        else if (selector == 4)
                        {
                            iCat.Scratch();
                        }
                        else if (selector == 5)
                        {
                            thisPet.GotoVet();
                        }
                    }
                }
            }
        }
    }
    /* Class: Pets
     * Author: Maxwell Chu
     * Purpose: Holds the list of pets
     * Restrictions: None
     */
    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }
                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at the index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }
        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }
    /* Class: Pet
     * Author: Maxwell Chu
     * Purpose: The parent class of an individual pet
     * Restrictions: None
     */
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();
        public Pet()
        {

        }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
    }
    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }
    /* Class: Cat
     * Author: Maxwell Chu
     * Purpose: The child class of Pet which holds the information of a cat
     * Restrictions: None
     */
    public class Cat : Pet, ICat
    {
        public override void Eat()
        {;
            Console.WriteLine(this.Name + ": Yuck, I don't like that!");
        }
        public override void Play()
        {
            Console.WriteLine(this.Name + ": Where's that mouse...");
        }
        public void Purr()
        {
            Console.WriteLine(this.Name + ": purrrrrrrrrrrrrrrrrrrr...");
        }
        public void Scratch()
        {
            Console.WriteLine(this.Name + ": Buy me a sctrach post."); ;
        }
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": Hiss!");
        }
        public Cat()
        {

        }
    }
    /* Class: Dog
     * Author: Maxwell Chu
     * Purpose: The child class of Pet which holds the information of a dog
     * Restrictions: None
     */
    public class Dog : Pet, IDog
    {
        public string license;
        public override void Eat()
        {
            Console.WriteLine(this.Name + ": Yummy, I will eat anything!");
        }
        public override void Play()
        {
            Console.WriteLine(this.Name + ": Throw the ball, throw the ball!");
        }
        public void Bark()
        {
            Console.WriteLine(this.Name + ": Woof woof!");
        }
        public void NeedWalk()
        {
            Console.WriteLine(this.Name + ": Woof woof, I need to go out.");
        }
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + ": Whimper, whimper, no vet!");
        }
        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }
    }
}