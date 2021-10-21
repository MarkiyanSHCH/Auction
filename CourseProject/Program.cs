using System;

using Domain.Models;
using DAL.Controller;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            void menu()
            {
                ProductController pr = new ProductController();
                CategoryController cr = new CategoryController();
                UserController us = new UserController();

                short userInput = 0;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"1. Show All Products\n2. Show All Categories\n3. Show All Users\n4. Setting");
                    userInput = Convert.ToInt16(Console.ReadLine());
                    switch (userInput)
                    {
                        case 1:
                            {
                                foreach (var item in pr.GetAll())
                                {
                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nAuction Price: {item.AuctionPrice}\nFix Price: {item.FixPrice}");
                                }
                                Console.WriteLine("\nEnter some button to continue.");
                                Console.ReadLine();
                                break;

                            }
                        case 2:
                            {
                                foreach (var item in cr.GetAll())
                                {
                                    Console.WriteLine($"{item.Id}. Name: {item.Name}");
                                }
                                Console.WriteLine("\nEnter some button to continue.");
                                Console.ReadLine();
                                break;
                            }
                        case 3:
                            {
                                foreach (var item in us.GetAll())
                                {
                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nLogin: {item.Login}\nRole: {item.Role}");
                                }
                                Console.WriteLine("\nEnter some button to continue.");
                                Console.ReadLine();
                                break;
                            }



                        case 4:
                            {

                                short i = 0;
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\t\t\t SETTING \n " +
                                                      "\t\tSelect an option from the following: \n" +
                                                      "1.....Product\n" +
                                                      "2.....Category\n" +
                                                      "3.....User\n" +
                                                      "0.....Exit\n\n");
                                    i = Convert.ToInt16(Console.ReadLine());
                                    if (i == 0)
                                    {
                                        menu();
                                        break;
                                    }
                                    switch (i)
                                    {
                                        case 1:
                                            {
                                                short tmp = 0;
                                                while (true)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t Product \n " +
                                                                      "\t\tSelect an option from the following: \n" +
                                                                      "1.....Add Product\n" +
                                                                      "2.....Delete Product\n" +
                                                                      "3.....Edit\n" +
                                                                      "0.....Exit\n\n");
                                                    tmp = Convert.ToInt16(Console.ReadLine());
                                                    if (tmp == 0)
                                                    {
                                                        break;
                                                    }
                                                    switch (tmp)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                string description = "";
                                                                Console.WriteLine("Enter Fix Price: ");
                                                                double FixPrice = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter Auction Price: ");
                                                                double AuctionPrice = Convert.ToInt16(Console.ReadLine());
                                                                bool sell = false;
                                                                DateTime StartDate = DateTime.Now;
                                                                DateTime EndDate;
                                                                Console.WriteLine("Enter Id Category: ");
                                                                int CategoryId = Convert.ToInt16(Console.ReadLine());
                                                                var product = new Product { Name = name, Description = description, FixPrice = FixPrice, AuctionPrice = AuctionPrice, Sell = sell, StartDate = StartDate, CategoryId = CategoryId };
                                                                pr.Create(product);
                                                                Console.WriteLine("Product Added Successfully\n\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in pr.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nAuction Price: {item.AuctionPrice}\nFix Price: {item.FixPrice}");
                                                                }
                                                                Console.WriteLine("Select Product you want delete : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                pr.Delete(sel);
                                                                Console.WriteLine("Product Deleted Successfully");
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in pr.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nAuction Price: {item.AuctionPrice}\nFix Price: {item.FixPrice}");
                                                                }
                                                                Console.WriteLine("Select Product you want update : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                Console.WriteLine("Enter Description: ");
                                                                string description = Console.ReadLine();
                                                                Console.WriteLine("Enter Fix Price: ");
                                                                double FixPrice = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter Auction Price: ");
                                                                double AuctionPrice = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter value sell: ");
                                                                bool sell = Convert.ToBoolean(Console.ReadLine());
                                                                Console.Write("Enter a month: ");
                                                                int month = int.Parse(Console.ReadLine());
                                                                Console.Write("Enter a day: ");
                                                                int day = int.Parse(Console.ReadLine());
                                                                Console.Write("Enter a year: ");
                                                                int year = int.Parse(Console.ReadLine());
                                                                DateTime EndDate = new DateTime(year, month, day);
                                                                Console.WriteLine("Enter Id Category: ");
                                                                int CategoryId = Convert.ToInt16(Console.ReadLine());
                                                                var product = new Product { Name = name, Description = description, FixPrice = FixPrice, AuctionPrice = AuctionPrice, Sell = sell, CategoryId = CategoryId };
                                                                pr.Update(sel, product);
                                                                Console.WriteLine("Product Edited Successfully"); ;
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;

                                                            }
                                                        default:
                                                            Console.Error.WriteLine("Error: wrong operation");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                    }
                                                }
                                                break;
                                            }
                                        case 2:
                                            {

                                                short tmp = 0;
                                                while (true)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t Category \n " +
                                                                      "\t\tSelect an option from the following: \n" +
                                                                      "1.....Add Category\n" +
                                                                      "2.....Delete Category\n" +
                                                                      "3.....Edit\n" +
                                                                      "0.....Exit\n\n");
                                                    tmp = Convert.ToInt16(Console.ReadLine());
                                                    if (tmp == 0)
                                                    {
                                                        break;
                                                    }
                                                    switch (tmp)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                var category = new Category { Name = name };
                                                                cr.Create(category);
                                                                Console.WriteLine("Category Added Successfully\n\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in cr.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}");
                                                                }
                                                                Console.WriteLine("Select Category you want delete : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                cr.Delete(sel);
                                                                Console.WriteLine("Category Deleted Successfully");
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in cr.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}");
                                                                }
                                                                Console.WriteLine("Select Category you want update : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                var product = new Category { Name = name };
                                                                cr.Update(sel, product);
                                                                Console.WriteLine("Category Edited Successfully"); ;
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;

                                                            }
                                                        default:
                                                            Console.Error.WriteLine("Error: wrong operation");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                    }
                                                }

                                                break;
                                            }
                                        case 3:
                                            {
                                                short tmp = 0;
                                                while (true)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t User \n " +
                                                                      "\t\tSelect an option from the following: \n" +
                                                                      "1.....Add Category\n" +
                                                                      "2.....Delete Category\n" +
                                                                      "3.....Edit\n" +
                                                                      "0.....Exit\n\n");
                                                    tmp = Convert.ToInt16(Console.ReadLine());
                                                    if (tmp == 0)
                                                    {
                                                        break;
                                                    }
                                                    switch (tmp)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                var user = new User { Name = name };
                                                                us.Create(user);
                                                                Console.WriteLine("User Added Successfully\n\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in us.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nLogin: {item.Login}\nRole: {item.Role}");
                                                                }
                                                                Console.WriteLine("Select User you want delete : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                us.Delete(sel);
                                                                Console.WriteLine("User Deleted Successfully");
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Console.Clear();
                                                                foreach (var item in us.GetAll())
                                                                {
                                                                    Console.WriteLine($"{item.Id}. Name: {item.Name}\nLogin: {item.Login}\nRole: {item.Role}\nPassword: {item.Password}");
                                                                }
                                                                Console.WriteLine("Select User you want update : ");
                                                                short sel;
                                                                sel = Convert.ToInt16(Console.ReadLine());
                                                                Console.WriteLine("Enter name: ");
                                                                string name = Console.ReadLine();
                                                                Console.WriteLine("Enter Login: ");
                                                                string login = Console.ReadLine();
                                                                Console.WriteLine("Enter role: ");
                                                                string role = Console.ReadLine();
                                                                Console.WriteLine("Enter password: ");
                                                                string password = Console.ReadLine();
                                                                var product = new User { Name = name, Login = login, Role = role, Password = password };
                                                                us.Update(sel, product);
                                                                Console.WriteLine("User Edited Successfully"); ;
                                                                Console.WriteLine("\nEnter some button to continue.");
                                                                Console.ReadLine();
                                                                break;

                                                            }
                                                        default:
                                                            Console.Error.WriteLine("Error: wrong operation");
                                                            Console.WriteLine("\nEnter some button to continue.");
                                                            Console.ReadLine();
                                                            break;
                                                    }
                                                }
                                                break;
                                            }

                                        default:
                                            Console.Error.WriteLine("Error: wrong operation");
                                            Console.WriteLine("\nEnter some button to continue.");
                                            Console.ReadLine();
                                            break;
                                    }
                                }
                                break;
                            }



                        case 0:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.Error.WriteLine("Error: wrong operation");
                            Console.WriteLine("\nEnter some button to continue.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }

    }
}