using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    public class Dog //Class name Dog
    {
        //Class fields declared and initialized
        public static int dogYears { get; set; }
        public static int dogMonths { get; set; }
        private readonly string name = "King";
        
        //Class method created to make the dog bark
        public static void Bark()
        {
            Console.WriteLine($"Guard dog be like: 'Woof errrr Woof!'\n");
        }

        //Constructor of the same name as the class name
        public Dog()
        {
            Console.WriteLine("Constructor used to create or instantiate an object in the Dog class\n");

            Console.WriteLine($"-----------------\n");

            this.name = name;
            Console.WriteLine($"My dog's name is {this.name}, say hi King: 'woof woof'\n");
          
        }

        //A deconstructor member used when the program is finished running
        ~Dog()
        {
            Console.WriteLine("Destructor being invoke to  delete the object created in the Dog class when the program is finished");
        }

        //A customized constructor named after the class name "Dog"
        public Dog(int dogYears, int dogMonths)
        {
            Dog.dogYears = 17;
            Dog.dogMonths = 45;

            Console.WriteLine($"\nMy dog is {Dog.dogYears} dog years and {Dog.dogMonths} dog months old\n");
        }

    }
}
