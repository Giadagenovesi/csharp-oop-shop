using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        //ATTRIBUTI
        private int code;
        private string name;
        private string description;
        private float price;
        private float iva;

       
        //PROPRIETÀ

        public int Code
        {
            get { return code; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        public float taxedPrice
        {
            get { return Price + (Price /100 * iva); }
        }

        //COSTRUTTORE
        public Prodotto(string name, float price, float iva)
        {
            Random random = new Random();
            code = random.Next(00000001, 99999999);
            Name = name;
            Price = price;
            Iva = iva;
        }

        //METODO

        public string GenerateFullName()
        {
            string productFullName = name + code;
            return productFullName;
        }

        





    }

 
}
