//aka.ms/new-console-template for more information
using PetstoreRCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.Json;



internal class Program
{
    public static void Main(string[] args)
    {
        var productLogic = new ProductLogicClass();
        
        //they're running the program, they obviously want to add at least 1 so dump them into it first?
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Press 2 to get all the products.");
        Console.WriteLine("Press 3 to get a list of all the product names.");
        Console.WriteLine("Press 4 to geta a item from the product list.");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Cat food or dog leash");
                string userChoice = Console.ReadLine();

                if (userChoice.ToLower() == "cat food")
                {
                    CatFoodClass catFoodn = new CatFoodClass();
                    Console.WriteLine("What's the name of your cat food?");
                    catFoodn.Name = Console.ReadLine();
                    Console.WriteLine("What's the price of your cat food?");
                    bool catPriceValid = false;
                    while (catPriceValid == false)
                    {
                        if (!decimal.TryParse(Console.ReadLine(), out decimal catPriceTemp))
                        {
                            Console.WriteLine("Price with(out) decimals, please.");
                        }
                        else
                        {
                            catFoodn.Price = catPriceTemp;
                            catPriceValid = true;
                        }
                    }
                    Console.WriteLine("What's the quantity of your cat food?");
                    bool catQtyValid = false;
                    while (catQtyValid == false)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int catQtyTemp))
                        {
                            Console.WriteLine("Quantity, please.");
                        }
                        else
                        {
                            catFoodn.Quantity = catQtyTemp;
                            catQtyValid = true;
                        }
                    }
                    Console.WriteLine("What's the Description of your cat food?");
                    catFoodn.Description = Console.ReadLine();
                    Console.WriteLine("What's the weight in pounds of your cat food?");
                    bool catWeightValid = false;
                    while (catWeightValid == false)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int catWeightTemp))
                        {
                            Console.WriteLine("Weight in pounds, please.");
                        }
                        else
                        {
                            catFoodn.WeightPounds = catWeightTemp;
                            catWeightValid = true;
                        }
                    }
                    Console.WriteLine("Is your cat kitten food?");
                    bool catKittenFoodValid = false;
                    while (catKittenFoodValid == false)
                    {
                        if (!bool.TryParse(Console.ReadLine(), out bool catKittenFoodTemp))
                        {
                            Console.WriteLine("True or False, please.");
                        }
                        else
                        {
                            catFoodn.KittenFood = catKittenFoodTemp;
                            catKittenFoodValid = true;
                        }
                    }

                    //finish up
                    Console.WriteLine(" ");
                    productLogic.AddProducts(catFoodn);
                    Console.WriteLine(catFoodn.Name + " was added to the product list.");
                    Console.WriteLine($"There are {productLogic.GetProductCount()} item(s) in the product list now."); 
                    //Console.WriteLine(JsonSerializer.Serialize(catFoodn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to geta a item from the product list.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }

                else if (userChoice.ToLower() == "dog leash")
                {
                    DogLeashClass dogLeashn = new DogLeashClass();
                    Console.WriteLine("What's the name of your dog leash?");
                    dogLeashn.Name = Console.ReadLine();
                    Console.WriteLine("What's the price of your dog leash?");
                    bool dogPriceValid = false;
                    while (dogPriceValid == false)
                    {
                        if (!decimal.TryParse(Console.ReadLine(), out decimal dogLeashPriceTemp))
                        {
                            Console.WriteLine("Price with(out) decimals, please.");
                        }
                        else
                        {
                            dogLeashn.Price = dogLeashPriceTemp;
                            dogPriceValid = true;
                        }
                    }
                    Console.WriteLine("What's the quantity of your dog leash?");
                    bool dogQtyValid = false;
                    while (dogQtyValid == false)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int dogLeashQuantityTemp))
                        {
                            Console.WriteLine("Quantity, please.");
                        }
                        else
                        {
                            dogLeashn.Quantity = dogLeashQuantityTemp;
                            dogQtyValid = true;
                        }
                    }
                    Console.WriteLine("What's the Description of your dog leash?");
                    dogLeashn.Description = Console.ReadLine();
                    Console.WriteLine("What's the length in inches of your dog leash?");
                    bool dogLengthValid = false;
                    while (dogLengthValid == false)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int dogLeashLengthTemp))
                        {
                            Console.WriteLine("Length in inches, please.");
                        }
                        else
                        {
                            dogLeashn.LengthInches = dogLeashLengthTemp;
                            dogLengthValid = true;
                        }
                    }
                    Console.WriteLine("What's the material of your dog leash?");
                    dogLeashn.Material = Console.ReadLine();

                    //finish up
                    Console.WriteLine(" ");
                    productLogic.AddProducts(dogLeashn);
                    Console.WriteLine(dogLeashn.Name + " was added to the products list.");
                    Console.WriteLine($"There are now {productLogic.GetProductCount()} available product(s).");
                    //Console.WriteLine(JsonSerializer.Serialize(dogLeashn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to geta a item from the product list.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();

                }

                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid selection.");
                    Console.WriteLine(" ");

                }
            }

            else if (userInput == "2")
            {
                Console.WriteLine($"There are now {productLogic.GetProductCount()} available product(s).");
            }

            else if (userInput == "3")
            {
                    //return list of names
            }

            else if (userInput == "4")
            {

                Console.WriteLine("Which product are you looking for?");
                string userChoiceProduct = Console.ReadLine();

                if (userChoiceProduct.ToLower() == "cat food")
                {
                    Console.WriteLine("What's the name of the cat food?");
                    //print out names
                    string whichCatName = Console.ReadLine();
                    Console.WriteLine(JsonSerializer.Serialize(productLogic.GetCatFoodByName(whichCatName)));
                }
                else if ((userChoiceProduct.ToLower() == "dog leash"))
                {
                    Console.WriteLine("What's the name of the dog leash?");
                    //print out names
                    string whichDogName = Console.ReadLine();
                    Console.WriteLine(JsonSerializer.Serialize(productLogic.GetDogLeashByName(whichDogName)));
                }
                else if (((userChoiceProduct.ToLower() == "exit"))) ;
                { return; }
                
            }
            else

            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Selection.");
                Console.WriteLine(" ");
                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to get a list of all the product names.");
                Console.WriteLine("Press 4 to geta a item from the product list.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

        }

        Console.WriteLine(" ");
        Console.WriteLine("fin");
    }
}



