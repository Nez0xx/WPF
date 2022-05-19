using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier_NF;

namespace LogicTier_NF
{
    public class Item
    {
        private Product _product;
        public String itemProductGroup
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
                return _product.productGroup + ": " + _product.productName + " - $"
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
        public String MaxInWarehouse
        {
            get
            {
                Dictionary<String, int> maxInWarehouse = new Dictionary<String, int>();
                foreach(var a in _items)
                {
                    if (!maxInWarehouse.ContainsKey(a.itemWarehouse))
                        maxInWarehouse.Add(a.itemWarehouse, 1);
                    else
                        ++maxInWarehouse[a.itemWarehouse];
                }

                int tempCount=0;
                String tempStr="";
                foreach(var b in maxInWarehouse)
                {
                    if (b.Value > tempCount)
                    {
                        tempCount = b.Value;
                        tempStr = b.Key;
                    }
                }

                return tempStr + "\n(" + tempCount + " товара(ов))";
            }
        }
        public Dictionary<String, double> avgPricePerGroup
        {
            get
            {
                Dictionary<String, double> avgPricePerGroup = new Dictionary<String, double>();
                Dictionary<String, double> temp = new Dictionary<String, double>();
                Dictionary<String, int> countProductsPerGroup = new Dictionary<String, int>();
                foreach(var a in _items)
                {
                    if (!temp.ContainsKey(a.itemProductGroup))
                    {
                        temp.Add(a.itemProductGroup, a.itemPrice);
                        countProductsPerGroup[a.itemProductGroup] = 1;
                    }
                    else
                    {
                        temp[a.itemProductGroup] += a.itemPrice;
                        ++countProductsPerGroup[a.itemProductGroup];
                    }
                }
                foreach(var b in temp)
                    avgPricePerGroup.Add(b.Key, b.Value / countProductsPerGroup[b.Key]);

                return avgPricePerGroup;
            }
        }
        public String avgPricePerGroupVision
        {
            get
            {
                String outLine = "";
                foreach (var a in avgPricePerGroup)
                    outLine += a.Key + " -- $" + Math.Round(a.Value, 3).ToString() + "\n";
                return outLine;
            }
        }

        public Shop(String filename)
        {
            try
            {
                List<Product> tmp = AllProducts.GetProductsList(filename);
                foreach (var t in tmp)
                    _items.Add(new Item(t));
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
