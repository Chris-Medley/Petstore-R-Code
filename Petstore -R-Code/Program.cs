//aka.ms/new-console-template for more information
using PetstoreRCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.Json;



internal class Program
{
    public static void Main(string[] args)
    {
        var productLogicConst = new ProductLogicClass();
        string userInput;

        Console.WriteLine("Press 1 to add another product");
        Console.WriteLine("Press 2 to get all the products.");
        Console.WriteLine("Press 3 to get a list of all the product names.");
        Console.WriteLine("Press 4 to get a item from the product list.");
        Console.WriteLine("Press 5 to get a list of in stock items.");
        Console.WriteLine("Type 'exit' to quit");
        userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {

            //add product
            if (userInput == "1")
            {
                //chose between dog leash & cat food
                Console.WriteLine("Cat food or dog leash");
                string userChoice = Console.ReadLine();

                //cat food entry
                if (userChoice.ToLower() == "cat food")
                {
                    //cat food entry
                    CatFoodClass catFoodn = new CatFoodClass();
                    Console.WriteLine("What's the name of your cat food?");
                    catFoodn.Name = Console.ReadLine();
                    Console.WriteLine("What's the price of your cat food?");
                    /*
                    try
                    {
                        decimal.TryParse(Console.ReadLine(), out decimal _catPriceTemp);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Price with(out) decimals, please.");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Price with(out) decimals, please.");
                    }
                    */

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
                    productLogicConst.AddProducts(catFoodn);
                    Console.WriteLine(catFoodn.Name + " was added to the product list.");
                    Console.WriteLine($"There are {productLogicConst.GetProductCount()} item(s) in the product list now.");
                    //Console.WriteLine(JsonSerializer.Serialize(catFoodn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add another product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to get a item from the product list.");
                    Console.WriteLine("Press 5 to get a list of in stock items.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }

                //dog leash entry
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
                    productLogicConst.AddProducts(dogLeashn);
                    Console.WriteLine(dogLeashn.Name + " was added to the products list.");
                    Console.WriteLine($"There are now {productLogicConst.GetProductCount()} available product(s).");
                    //Console.WriteLine(JsonSerializer.Serialize(dogLeashn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add another product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to get a item from the product list.");
                    Console.WriteLine("Press 5 to get a list of in stock items.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();

                }

                //"error handling" but not really, need to keep watching and googling try-catch
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid selection.");
                    Console.WriteLine(" ");

                }
            }

            //how many products exit
            else if (userInput == "2")
            {
                Console.WriteLine($"There are now {productLogicConst.GetProductCount()} available product(s)."); //return up a level
                Console.WriteLine(" ");

                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to get a list of all the product names.");
                Console.WriteLine("Press 4 to get a item from the product list.");
                Console.WriteLine("Press 5 to get a list of in stock items.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

            //list of all product names
            else if (userInput == "3")
            {
                //return list of names
                productLogicConst.GetProductNames().ForEach(p => Console.WriteLine(p)); //return up a level
                Console.WriteLine(" ");

                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to get a list of all the product names.");
                Console.WriteLine("Press 4 to get a item from the product list.");
                Console.WriteLine("Press 5 to get a list of in stock items.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

            //look up products by category and then name to display info
            else if (userInput == "4")
            {

                Console.WriteLine("Which product are you looking for, cat food or dog leashes?");
                string userChoiceProduct = Console.ReadLine();

                if (userChoiceProduct.ToLower() == "cat food")
                {
                    Console.WriteLine("What's the name of the cat food?");
                    Console.WriteLine(JsonSerializer.Serialize(productLogicConst.GetCatProductNames())); //pull this out of dictionary better?
                    string whichCatName = Console.ReadLine();
                    if (productLogicConst.GetCatFoodByName(whichCatName) == null)
                    {
                        Console.WriteLine("Product couldn't be found.");
                    }
                    else
                    {
                        Console.WriteLine(JsonSerializer.Serialize(productLogicConst.GetCatFoodByName(whichCatName)));
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add another product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to get a item from the product list.");
                    Console.WriteLine("Press 5 to get a list of in stock items.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
                else if (userChoiceProduct.ToLower() == "dog leash")
                {
                    Console.WriteLine("What's the name of the dog leash?");
                    Console.WriteLine(JsonSerializer.Serialize(productLogicConst.GetDogProductNames())); //pull this out of dictionary better?
                    string whichDogName = Console.ReadLine();
                    if (productLogicConst.GetDogLeashByName(whichDogName) == null)
                    {
                        Console.WriteLine("Product couldn't be found.");
                    }
                    else
                    {
                        Console.WriteLine(JsonSerializer.Serialize(productLogicConst.GetDogLeashByName(whichDogName)));
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add another product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to get a item from the product list.");
                    Console.WriteLine("Press 5 to get a list of in stock items.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
                else if (userChoiceProduct.ToLower() == "exit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Invalid Selection.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add another product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to get a list of all the product names.");
                    Console.WriteLine("Press 4 to get a item from the product list.");
                    Console.WriteLine("Press 5 to get a list of in stock items.");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }

            }
            else if (userInput == "5")
            {
                //return list of names of things with QTY > 0
                Console.WriteLine("The following items are in stock.");
                var instock = productLogicConst.GetOnlyInStockProducts();
                foreach (var item in instock)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(" ");

                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to get a list of all the product names.");
                Console.WriteLine("Press 4 to get a item from the product list.");
                Console.WriteLine("Press 5 to get a list of in stock items.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
            else 
        {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Selection.");
                Console.WriteLine(" ");
                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to get a list of all the product names.");
                Console.WriteLine("Press 4 to get a item from the product list.");
                Console.WriteLine("Press 5 to get a list of in stock items.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

        }

        Console.WriteLine(" ");
        Console.WriteLine("fin");
    }
}



