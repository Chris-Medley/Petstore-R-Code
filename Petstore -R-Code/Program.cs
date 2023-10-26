//aka.ms/new-console-template for more information
using System.Text.Json;

//they're running the program, they obviously want to add at least 1 so dump them into it first?
Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

//would an if-elseif-break be more efficient here?
while (userInput.ToLower() != "exit")
{
    if (userInput.ToLower() == "1")
    {
        Console.WriteLine("Cat food or dog leash");
        string userChoice = Console.ReadLine();

        if (userChoice.ToLower() == "cat food")
        {
            CatFood catFoodn = new CatFood();
            Console.WriteLine("What's the name of your cat food?");
            catFoodn.Name = Console.ReadLine();
            Console.WriteLine("What's the price of your cat food?");
            catFoodn.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What's the quantity of your cat food?");
            catFoodn.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the Description of your cat food?");
            catFoodn.Description = Console.ReadLine();
            Console.WriteLine("What's the weight in pounds of your cat food?");
            catFoodn.WeightPounds = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this kitten food?");
            catFoodn.KittenFood = bool.Parse(Console.ReadLine());

            Console.WriteLine(JsonSerializer.Serialize(catFoodn));

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
        else if (userChoice.ToLower() == "dog leash")
        {
            DogLeash dogLeashn = new DogLeash();
            Console.WriteLine("What's the name of your dog leash?");
            dogLeashn.Name = Console.ReadLine();
            Console.WriteLine("What's the price of your dog leash?");
            dogLeashn.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What's the quantity of your dog leash?");
            dogLeashn.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the Description of your dog leash?");
            dogLeashn.Description = Console.ReadLine();
            Console.WriteLine("What's the length in inches of your dog leash?");
            dogLeashn.LengthInches = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the material of your dog leash?");
            dogLeashn.Material = Console.ReadLine();

            Console.WriteLine(JsonSerializer.Serialize(dogLeashn));

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();

        }

        else
        {
            Console.WriteLine("Invalid selection.");

        }
    }

    else

            {
                Console.WriteLine("Invalid Selection.");
                Console.WriteLine("Press 1 to add another product");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }

}



public class Product
{
    public string Name = "";
    public decimal Price;
    public int Quantity;
    public string Description = "";

}

public class CatFood : Product
{
    public double WeightPounds;
    public bool KittenFood;

}

public class DogLeash : Product
{
    public int LengthInches;
    public string Material = "";

}
