using System;
using System.Collections;
 
namespace TestName
{
   
    public class A
    {
        public static void Main(string[] args)
        {
        Console.WriteLine(args[0].ToUpper());
        Products p = new Products();
        MainMenu.menu(p);
        }
 
        
    }
 
    public class MainMenu
    {
        public static void menu(Products p) {
            Console.WriteLine("WELCOME TO AMAZON.IN...");
            Console.WriteLine("Enter 1 -> To View all products");
            Console.WriteLine("Enter 2 -> To add new product");
            Console.WriteLine("Enter 3 -> To Exit");
            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
           
            switch(choice) {
                case 1:
                    p.showProducts();
                    menu(p);
                    break;
                case 2:
                    AddProductMenu.menu(p);
                    menu(p);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter Valid Choise..");
                    menu(p);
                    break;
            }
        }
    }
 
    public class AddProductMenu
    {
        public static void menu(Products p) {
            Console.Write("Enter product key: ");
            int productKey = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product value: ");
            string productValue = Console.ReadLine();
 
            if(p.addProduct(productKey, productValue) == 1) {
                Console.WriteLine("Product added successfully..");
            } else {
                Console.WriteLine("Product Key is already present.");
                menu(p);
            }
        }
    }
 
    public class Products
    {
       
        Hashtable productsTable = new Hashtable();
       
        public int addProduct(int productKey, string productValue)
        {
            if(!productsTable.ContainsKey(productKey)) {
                productsTable.Add(productKey, productValue);
                return 1;
            }
            return 0;
        }
        public void showProducts()
        {
            if (productsTable.Count > 0)
            {
                foreach (DictionaryEntry de in productsTable)
                {
                    Console.WriteLine($"Product Key: {de.Key}  Product Value: {de.Value}");
                }
            }
            else
            {
                Console.WriteLine("No Product Present..");
            }
        }
    }
}

//For reference
//Code taken from Jayvirsinh
