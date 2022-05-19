using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataTier_NF
{
    public class Product
    {
        public String productName { get; set; }
        public String productGroup { get; set; }
        public double price { get; set; }
        public String warehouse { get; set; }

        public Product() { }
    }

    public class AllProducts
    {
        //public List<Product> allProducts;
        //private char divider = '%';

        public AllProducts() { }
        public static List<Product> GetProductsList(String filename)
        {
            List<Product> productsList = new List<Product>();    
            try
            {
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    Product item = new Product();
                    string[] items = line.Split('%');

                    item.productName = items[0].Trim();
                    item.productGroup = items[1].Trim();
                    item.price = Convert.ToDouble(items[2].Trim());
                    item.warehouse = items[3].Trim();

                    productsList.Add(item);
                }
                sr.Close();
                return productsList;
            }
            catch (Exception ex) { throw ex; }
        }
        public static void SaveAll(List<Product> products) { }
    }
}
