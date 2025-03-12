using System;
using OOP;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace OOP

{
    class ManageProduct
    {
        public class InsertNewProduct
        {
            private string server = "localhost";
            private string database = "csharpapp";
            private string username = "root";
            private string password = "";
            private string connString;

            public InsertNewProduct()
            {
                connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }

            public void InsertData(string Product_Name, int Product_Price, string Product_Description)
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected to MySQL!");

                        string query = "INSERT INTO products (Product_Name, Product_Price, Product_Description) VALUES (@name, @price, @description)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", Product_Name);
                            cmd.Parameters.AddWithValue("@price", Product_Price);
                            cmd.Parameters.AddWithValue("@description", Product_Description);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine(@" 
                                                                                                                                        
 ____    _  _____  _      ___ _   _ ____  _____ ____ _____ _____ ____    ____  _   _  ____ ____ _____ ____  _____ _   _ _     _  __   __
|  _ \  / \|_   _|/ \    |_ _| \ | / ___|| ____|  _ |_   _| ____|  _ \  / ___|| | | |/ ___/ ___| ____/ ___||  ___| | | | |   | | \ \ / /
| | | |/ _ \ | | / _ \    | ||  \| \___ \|  _| | |_) || | |  _| | | | | \___ \| | | | |  | |   |  _| \___ \| |_  | | | | |   | |  \ V / 
| |_| / ___ \| |/ ___ \   | || |\  |___) | |___|  _ < | | | |___| |_| |  ___) | |_| | |__| |___| |___ ___) |  _| | |_| | |___| |___| |  
|____/_/   \_|_/_/   \_\ |___|_| \_|____/|_____|_| \_\|_| |_____|____/  |____/ \___/ \____\____|_____|____/|_|    \___/|_____|_____|_|  
                                                                                                                                        
");
                            }
                            else
                            {
                                Console.WriteLine(@" 
                                                                                                           
 _____ _    ___ _     _____ ____    _____ ___    ___ _   _ ____  _____ ____ _____   ____    _  _____  _    
|  ___/ \  |_ _| |   | ____|  _ \  |_   _/ _ \  |_ _| \ | / ___|| ____|  _ |_   _| |  _ \  / \|_   _|/ \   
| |_ / _ \  | || |   |  _| | | | |   | || | | |  | ||  \| \___ \|  _| | |_) || |   | | | |/ _ \ | | / _ \  
|  _/ ___ \ | || |___| |___| |_| |   | || |_| |  | || |\  |___) | |___|  _ < | |   | |_| / ___ \| |/ ___ \ 
|_|/_/   \_|___|_____|_____|____/    |_| \___/  |___|_| \_|____/|_____|_| \_\|_|   |____/_/   \_|_/_/   \_\
                                                                                                           
");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(@" 
                               
 _____ ____  ____   ___  ____  
| ____|  _ \|  _ \ / _ \|  _ \ 
|  _| | |_) | |_) | | | | |_) |
| |___|  _ <|  _ <| |_| |  _ < 
|_____|_| \_|_| \_\\___/|_| \_\
                               
 " + ex.Message);
                    }
                }
            }
        }
    }
}