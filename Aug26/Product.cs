using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObjLibrary
{

    public class Product
    {
        private string pname;

        public string ProductName
        {
            get { return pname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Product Name cannot be null");
                }
                else
                {
                    pname = value;
                }

            }
        }

        private int pid;

        public int Product_ID
        {
            get { return pid; }
            set
            {
                if (value != 0)
                {
                    pid = value;

                }
                else
                {

                    Console.WriteLine("ProductID cannot be zero or null");
                }
            }
        }

        private int price;

        public int Product_Price
        {
            get { return price; }
            set
            {
                if (value != 0)
                {
                    price = value;

                }
                else
                {

                    Console.WriteLine("Product Price cannot be zero or null");
                }
            }
        }

        public void AcceptProductData(int pid, string pname, int price)
        {
            ProductID = pid;
            ProductName = pname;
            ProductPrice = price;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ProductID : " + Product_ID);
            Console.WriteLine("ProductName : " + Product_Name);
            Console.WriteLine("ProductPrice : " + Product_Price);
            Console.WriteLine("-----------------------------");

        }
    }
}

