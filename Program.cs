using System;
using System.Data;
using MySql.Data.MySqlClient;
using OOP;

class MainProgram
{
    public static void Main()
    {
        OOP.ManageProduct.InsertNewProduct newProduct = new OOP.ManageProduct.InsertNewProduct();

        string Product_Name;
        string Product_Description;
        int Product_Price;

        int limit = 1;
        int productCount = 0;

        while (productCount < limit)
        {
            Console.Clear();
            Console.WriteLine(@"
                                                                                              
 ___ _   _ ____  _____ ____ _____ ___ _   _  ____   ____  ____   ___  ____  _   _  ____ _____ 
|_ _| \ | / ___|| ____|  _ |_   _|_ _| \ | |/ ___| |  _ \|  _ \ / _ \|  _ \| | | |/ ___|_   _|
 | ||  \| \___ \|  _| | |_) || |  | ||  \| | |  _  | |_) | |_) | | | | | | | | | | |     | |  
 | || |\  |___) | |___|  _ < | |  | || |\  | |_| | |  __/|  _ <| |_| | |_| | |_| | |___  | |  
|___|_| \_|____/|_____|_| \_\|_| |___|_| \_|\____| |_|   |_| \_\\___/|____/ \___/ \____| |_|  
                                                                                              
");

            Console.WriteLine(" ___________________________________________________________________________");
            Console.WriteLine($"|\t\t\t\t\t\t\t\t\t    |\n| Input A Products [{productCount + 1}] You can Insert less than {limit} products:\t\t    |");
            Console.WriteLine("|___________________________________________________________________________|");

            Console.WriteLine("\n>>>>>>>>>>>>>>>> PRODUCT NAME <<<<<<<<<<<<<<<");
            Console.WriteLine(@"Input the product name [max 25 character]");
            Product_Name = Console.ReadLine();
            if (Product_Name.Length > 25)
            {
                Console.WriteLine("Input a product at least less than 25 characters. Please Try Again!");
                continue;
            }

            Console.WriteLine("\n>>>>>>>>>>>>>>>> PRODUCT PRICE <<<<<<<<<<<<<<<");
            Console.WriteLine("Input the product price [at least 1 to 1,000]:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out Product_Price) && Product_Price >= 1 && Product_Price <= 1000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid price. Please enter a price less than 1,000.");
                }
            }

            Console.WriteLine("\n>>>>>>>>>>>>>>>> PRODUCT DESCRIPTION <<<<<<<<<<<<<<<");
            Console.WriteLine("Input the product description [max 50 characters]");
            Product_Description = Console.ReadLine();
            if (Product_Description.Length > 50)
            {
                Console.WriteLine("Invalid description! Please enter a description with less than 50 characters.");
                continue;
            }

            newProduct.InsertData(Product_Name, Product_Price, Product_Description);

            productCount++;

            

            Console.WriteLine(" ___________________________________________________________________________");
            Console.WriteLine($"|\t\t\t\t\t\t\t\t\t    |\n|\t\tYou have {limit - productCount} more products you can add.\t\t\t    |");
            Console.WriteLine("|___________________________________________________________________________|");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        
        Console.WriteLine(@"
                                                                                                                                                                                                       
  ___   ___  ____  ____  _  __   _____  _   _   ____  _____    _    ____ _   _   _     ___ __  __ ___ _____   ____  ____   ___  ____  _   _  ____ _____   ___ _   _ ____  _____ ____ _____ _____ ____  
 / _ \ / _ \|  _ \/ ___|| | \ \ / / _ \| | | | |  _ \| ____|  / \  / ___| | | | | |   |_ _|  \/  |_ _|_   _| |  _ \|  _ \ / _ \|  _ \| | | |/ ___|_   _| |_ _| \ | / ___|| ____|  _ |_   _| ____|  _ \ 
| | | | | | | |_) \___ \| |  \ V | | | | | | | | |_) |  _|   / _ \| |   | |_| | | |    | || |\/| || |  | |   | |_) | |_) | | | | | | | | | | |     | |    | ||  \| \___ \|  _| | |_) || | |  _| | | | |
| |_| | |_| |  __/ ___) |_|   | || |_| | |_| | |  _ <| |___ / ___ | |___|  _  | | |___ | || |  | || |  | |   |  __/|  _ <| |_| | |_| | |_| | |___  | |    | || |\  |___) | |___|  _ < | | | |___| |_| |
 \___/ \___/|_|   |____/(_)   |_| \___/ \___/  |_| \_|_____/_/   \_\____|_| |_| |_____|___|_|  |_|___| |_|   |_|   |_| \_\\___/|____/ \___/ \____| |_|   |___|_| \_|____/|_____|_| \_\|_| |_____|____/ 
                                                                                                                                                                                                       
");
        
    }
}