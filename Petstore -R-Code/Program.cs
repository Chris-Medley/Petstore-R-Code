//aka.ms/new-console-template for more information
using System;
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
        Console.WriteLine("Press 3 to geta a item from the product list.");
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
                    Console.WriteLine(" ");
                    productLogic.AddProducts(catFoodn);
                    Console.WriteLine(catFoodn.Name + " was added to the product list.");
                    Console.WriteLine(productLogic.GetAllProducts());
                    //Console.WriteLine(JsonSerializer.Serialize(catFoodn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to geta a item from the product list.");
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
                    Console.WriteLine(" ");
                    productLogic.AddProducts(dogLeashn);
                    Console.WriteLine(dogLeashn.Name + " was added to the products list.");
                    Console.WriteLine(productLogic.GetAllProducts());
                    //Console.WriteLine(JsonSerializer.Serialize(dogLeashn)); //breakout wasn't happening here, look into it
                    Console.WriteLine(" ");
                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine("Press 2 to get all the products.");
                    Console.WriteLine("Press 3 to geta a item from the product list.");
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
                Console.WriteLine("Which product are you looking for?");
                string userChoiceProduct = Console.ReadLine();

                if (userChoiceProduct.ToLower() == "cat food")
                {
                    string whichCatName = Console.ReadLine();
                    Console.WriteLine(productLogic.GetCatFoodByName(whichCatName));
                }
                else if ((userChoiceProduct.ToLower() == "dog leash"))
                {
                    string whichDogName = Console.ReadLine();
                    Console.WriteLine(productLogic.GetDogLeashByName(whichDogName));
                }
                else;
            }

            else if (userInput == "3")
            {
                productLogic.GetAllProducts();
            }
            else

            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Selection.");
                Console.WriteLine(" ");
                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Press 2 to get all the products.");
                Console.WriteLine("Press 3 to geta a item from the product list.");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

        }

        Console.WriteLine(" ");
        Console.WriteLine("fin");
    }
}

public class ProductClass
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

}

public class CatFoodClass : ProductClass
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }

}

public class DogLeashClass : ProductClass
{
    public int LengthInches { get; set; }
    public string Material { get; set; }

}
public class ProductLogicClass
{ 
    private List<ProductClass> _products = new List<ProductClass>();
    private Dictionary<string, DogLeashClass> _dogLeashDict = new Dictionary<string, DogLeashClass>();
    private Dictionary<string, CatFoodClass> _catFoodDict = new Dictionary<string, CatFoodClass>();

    public void AddProducts(ProductClass product)
    { 
        _products.Add(product); 
        if (product is DogLeashClass)
        {
            _dogLeashDict.Add(product.Name, product as DogLeashClass);
        }
        else
        {
            _catFoodDict.Add(product.Name, product as CatFoodClass);
        }
    }
        
    public List<ProductClass> GetAllProducts()
    {
        return _products;
    }

    public DogLeashClass GetDogLeashByName(string dogName)
    {
        return _dogLeashDict[dogName];
    }

    public CatFoodClass GetCatFoodByName(string catName)
    {
        return _catFoodDict[catName];
    }
}

