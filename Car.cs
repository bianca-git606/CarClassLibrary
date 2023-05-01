using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {   //get-set just means you can set and get the values
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car() {

            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }
        //prints a string when referencing an object
        override public string ToString() 
        {
            return Make + "\t" + Model + "\t" + Price;
        }
    }
}
