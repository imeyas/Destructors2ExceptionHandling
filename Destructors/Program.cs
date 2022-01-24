using System;

namespace Destructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instantiating dogs and getting the count of dog objets created
            var newDog = new Dog()
            {
             
            };

            Console.WriteLine($"-----------------\n");

            var firstCat = new Cat();
            var secondCat = new Cat();
            var thirdCat = new Cat();
            var fourthCat = new Cat();
            var fifthCat = new Cat();
            var sixthCat = new Cat();
            var seventhCat = new Cat();

            Console.WriteLine($"\nTotal count of cat objects created: \n\n{Cat.count}\n");

            Console.WriteLine($"-----------------\n");

            //Using static keyword to create a method that prints dog barking
            Dog.Bark();

            Console.WriteLine($"-----------------\n");

            //More on using static keyword and instantiating a new dog to call it
            var dogYearsMonths = new Dog(Dog.dogYears, Dog.dogMonths);

            Console.WriteLine($"-----------------\n");

            //Using the Math class as an example of a Static Class to get the answer to 8 to the 9th power
            Console.WriteLine($"\n8 to the 9th power = {Math.Pow(8, 9)}\n");

            Console.WriteLine($"-----------------\n");

            //Using static class DateTime to find the current date and time, current day, and amount of days in a given month

            Console.WriteLine($"The date and time now is: {DateTime.Now.ToString()}\n");

            Console.WriteLine($"-----------------\n");

            Console.WriteLine($"Today is: {DateTime.Today.ToString()}\n");

            Console.WriteLine($"-----------------\n");

            Console.WriteLine($"The month of July, 2017, had {DateTime.DaysInMonth(2017, 7)} days on the calendar\n");

            Console.WriteLine($"-----------------\n");

            //Instantiating a new object of the Clients class
            var newClient = new Clients();
            newClient[0] = "Dave";
            newClient[1] = "Bob";
            newClient[2] = "Eric";
            newClient[3] = "Jared";
            newClient[4] = "Ethan";
            newClient[5] = "David";
            newClient[6] = "Alex";

            Console.WriteLine($"You currently have seven new clients and there names are: {newClient[0]}, {newClient[1]}, {newClient[2]}, {newClient[3]}, {newClient[4]}, {newClient[5]}," +
                $"{newClient[6]}... Congratulations!\n");

            Console.WriteLine($"-----------------\n");

            //Instantiating and using box 1 and box2 to create an instance or object of the Box class in box3 and printing the values of box3 on screen
            var box1 = new Box(17, 45);
            var box2 = new Box(19, 17);
            var box3 = box1 + box2;

            Console.WriteLine($"Box 3's height = {box3.Height}\n");
            Console.WriteLine($"Box 3's width = {box3.Width}\n");

            Console.WriteLine($"-----------------\n");

            //Exception handling code with try, catch and finally blocks
            int x = 0;
            try
            {
                x /= x;
                x += 1;
            }
            catch (Exception e)
            {
                x += 3;
            }
            finally
            {
                x += 4;
            }
            Console.WriteLine(x);


    }
    }
}
