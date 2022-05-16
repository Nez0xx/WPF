using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace DataTier
{
    public enum Product_Group
    {
        SOFTWARE,
        NET_EQUIPMENT,
        UNDEFINED
    }
    public class Utils
    {
        public Product_Group ToProductGroup(String type)
        {
            switch (type)
            {
                case "ПО": return Product_Group.SOFTWARE;
                case "Сетевое оборудование": return Product_Group.NET_EQUIPMENT;
                default: return Product_Group.UNDEFINED;
            }
        }
        public String ToString(Product_Group type)
        {
            switch (type)
            {
                case Product_Group.SOFTWARE: return "ПО";
                case Product_Group.NET_EQUIPMENT: return "Сетевое оборудование";
                default: return "Не определено";
            }
        }
    }
    public class Product 
    {
        public String productName { get; set; }
        public Product_Group productGroup { get; set; }
        public double price { get; set; }
        public String warehouse { get; set; }

        public Product() { }
    }

    public class AllProducts : Utils
    {
        public List<Product> allProducts { get; }
        private char divider = '%';

        AllProducts() { }
        public AllProducts(String filename)
        {
            Product item = new Product();
            try
            {
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(divider);

                    item.productName = items[0].Trim();
                    item.productGroup = ToProductGroup(items[1].Trim());
                    item.price = Convert.ToDouble(items[2].Trim());
                    item.warehouse = items[3].Trim();

                    allProducts.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex) { throw ex; }
        }
        public static void SaveAll(List<Product> products) { }
    }
}
