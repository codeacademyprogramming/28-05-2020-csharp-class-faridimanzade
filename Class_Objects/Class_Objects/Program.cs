using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Objects
{
    class Program
    {

        /* Name: Laptop, price: 1000,
           Name: SD-card, price: 30,
           Name: USB-hab, price: 12 */

        static void Main(string[] args)
        {
            /* OBJECT OF LAPTOP */
            Invoice laptop = new Invoice("01", "Ezio", "Asus");
            laptop.article = "Laptop";
            laptop.quantity = "10";
            laptop.CostCalculation(true);

            /* OBJECT OF SD-card */
            Invoice sdCard = new Invoice("09589789", "Arno", "Lenovo");
            sdCard.article = "SD-card";
            sdCard.quantity = "100";
            sdCard.CostCalculation(false);

            /* OBJECT OF USB-hab */
            Invoice usbHab = new Invoice("0367", "Connor", "Hewlett-Packard");
            usbHab.article = "USB-hab";
            usbHab.quantity = "1";
            usbHab.CostCalculation(false);
        }
    }

    class Invoice
    {
        private string account;
        private string customer;
        private string provider;

        public string article { get; set; }
        public string quantity { get; set; }


        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }


        public void CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {
                Console.WriteLine($"ID: {account} | Customer: {customer} | Provider: {provider}");
                double price = (1000 * Convert.ToInt32(quantity) * 0.18) + (1000 * Convert.ToInt32(quantity));

                switch (article)
                {
                    case "Laptop":
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} with EDV is: {price} AZN \n");
                        break;
                    case "SD-card":
                        price = (30 * Convert.ToInt32(quantity) * 0.18) + (30 * Convert.ToInt32(quantity));
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} with EDV is: {price} AZN \n");
                        break;
                    case "USB-hab":
                        price = (12 * Convert.ToInt32(quantity) * 0.18) + (12 * Convert.ToInt32(quantity));
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} with EDV is: {price} AZN \n");
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!! \n");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"ID: {account} | Customer: {customer} | Provider: {provider}");
                double price = 1000 * Convert.ToInt32(quantity);

                switch (article)
                {
                    case "Laptop":
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} without EDV is: {price} AZN \n");
                        break;
                    case "SD-card":
                        price = 30 * Convert.ToInt32(quantity);
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} without EDV is: {price} AZN \n");
                        break;
                    case "USB-hab":
                        price = 12 * Convert.ToInt32(quantity);
                        Console.WriteLine($"Product: {article} | Price depending on quantity {quantity} without EDV is: {price} AZN \n");
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!! \n");
                        break;
                }
            }
        }

    }


}
