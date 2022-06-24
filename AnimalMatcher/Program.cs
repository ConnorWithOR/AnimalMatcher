using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace AnimalMatcher
{
    class AnimalMatcher
    {
        public static void Main()
        {
            string[] dogs = { "Frank" };
            string[] cats = { "Sasha" };
            string userChoice;

            MainMenu();

            void MainMenu()
            {
                Console.WriteLine("Animal Matcher");
                Console.WriteLine("---------------------");
                Console.WriteLine("");
                Console.WriteLine("Welcome to Animal Matcher where we hope your next companion is a click away!");
                Console.WriteLine(" ");
                Console.WriteLine("Please choose from the options below:\n 1. View available dogs and cats\n 2. Place a pet up for adoption\n 3. Donate to our mission\n 4. Close Animal Matcher");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ViewDogsAndCats();
                        break;

                    case "2":
                        Console.WriteLine("Please enter the info listed below to add your pet for adoption.");
                        break;

                    case "3":
                        Console.WriteLine("Please enter the amount you would like to donate and currency type (USD,EUR,CAD)");
                        string userDonation = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("We hope to see you again, goodbye!");
                        break;

                }
            }

            void ViewDogsAndCats()
            {
                Console.WriteLine("Would you like to view our available dogs or cats?\n 1. Dogs\n 2. Cats\n 3. Back to main menu"); //Need to create a method that will repeat welcome menu
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        foreach (string dog in dogs)
                        {
                            Console.WriteLine(dog);
                        }
                        break;

                    case "2":
                        foreach (string cat in cats)
                        {
                            Console.WriteLine(cat);
                        }
                        break;

                    case "3":
                        MainMenu();
                        break;
                }

            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //Animal frank = new Animal("Frank", 1, "Louisville", "Frank is full of energy and loves to nibble. He will always be at your side.");
            //Console.WriteLine(frank.ViewAnimal());
        }
    }
}