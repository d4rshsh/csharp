using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ArrayObjLibrary;

namespace Aug26
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
           List<Product> productlist = new List<Product>();

            productlist.Add(new Product { Product_ID = 1, Product_Name = "Grinder", Product_Price = 7900 });
            productlist.Add(new Product { Product_ID = 2, Product_Name = "Television", Product_Price = 39000 });
            Console.WriteLine("Enter  1.Show Products  2.Add Product 3.Remove Product ");
            int ch= Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Product Details:");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("Product ID : " + item.Product_ID);
                        Console.WriteLine("Product Name : " + item.Product_Name);
                        Console.WriteLine("Product Price : " + item.Product_Price);
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    Console.WriteLine("enter the length of Product list you want to add");
                    int n = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 0; i < n; i++)
                    {
                        Product products = new Product();
                        Console.WriteLine("Enter the Product ID");
                        products.Product_ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Product Name");
                        products.Product_Name = Console.ReadLine();
                        Console.WriteLine("Enter the Price of the product");
                        products.Product_Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------------------------------");
                        productlist.Add(products);
                    }
                    Console.WriteLine("Product Details:");

                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.ProductID);
                        Console.WriteLine("ProductName : " + item.ProductName);
                        Console.WriteLine("ProductPrice : " + item.ProductPrice);
                        Console.WriteLine();
                    }
                    break;
                 
                case 3:
                    Console.WriteLine("Product List:");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.Product_ID);
                        Console.WriteLine("ProductName : " + item.Product_Name);
                        Console.WriteLine("ProductPrice : " + item.Product_Price);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Enter the index of product You want to remove");
                    int num=Convert.ToInt32(Console.ReadLine());
                    productlist.RemoveAt(num);

                    Console.WriteLine("Product is successfully removed");
                    Console.WriteLine("Edited Product Details");
                    foreach (var item in productlist)
                    {
                        Console.WriteLine("ProductID : " + item.Product_ID);
                        Console.WriteLine("ProductName : " + item.Product_Name);
                        Console.WriteLine("ProductPrice : " + item.Product_Price);
                        Console.WriteLine();
                    }
                   
                    break;
            }
            Console.ReadLine();          
        }      
        
    }
}
