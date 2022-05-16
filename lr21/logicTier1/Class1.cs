using System;
using DataTier;
using System.Collections.Generic;

namespace LogicTier
{
    public class Item
    {
        private Product _product;
        public Product_Group itemProductGroup
        {
            get { return _product.productGroup; }
            set { _product.productGroup = value; }
        }
        public String itemName
        {
            get { return _product.productName; }
            set { _product.productName = value; }
        }
        public double itemPrice
        {
            get { return _product.price; }
            set { _product.price = value; }
        }
        public String itemWarehouse
        {
            get { return _product.warehouse; }
            set { _product.warehouse = value; }
        }
        public String itemVision
        {
            get
            {
                return _product.productGroup.ToString() + ":" + _product.productName + " - $"
                    + _product.price.ToString();
            }
        }
        public Item(Product p) { _product = p; }
    }

    public class Shop
    {
        private List<Item> _items = new List<Item>();
        public List<Item> itemList
        {
            get { return _items; }
        }

        public Shop(String filename)
        {
            try
            {
                AllProducts tmp = new AllProducts(filename);

                foreach (var t in tmp.allProducts)
                    _items.Add(new Item(t));
            }
            catch (Exception ex) { throw ex; }
        }


    }
}