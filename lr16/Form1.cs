using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lr16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public enum Building_Type
        {
            House,
            Flat,
            Room,
            Undefined
        }

        public static Building_Type ToBuildingType(String type)
        {
            switch (type)
            {
                case "Дом": return Building_Type.House;
                case "Квартира": return Building_Type.Flat;
                case "Комната": return Building_Type.Room;
                default: return Building_Type.Undefined;
            }
        }
        public static String ToString(Building_Type type)
        {
            switch (type)
            {
                case Building_Type.House: return "Дом";
                case Building_Type.Flat: return "Квартира";
                case Building_Type.Room: return "Комната";
                default: return "Не определено";
            }
        }

        class RawDataItem  
        {
            public Building_Type type { get; set; }
            public int rooms { get; set; }
            public int size { get; set; }
            public long price { get; set; }
            public double mSqr_price
            {
                get { return (double)(price / size); }
            }
        }
        class SummaryDataItem  
        {
            public int typeSum { get; set; }
            public Building_Type type { get; set; }
        }

        interface DataInterface
        {
            List<RawDataItem> GetRawData();
            List<SummaryDataItem> GetSummaryData();
        }

        class DataStorage : DataInterface
        {
            private List<RawDataItem> rawdata;
            private List<SummaryDataItem> sumdata;
            private char divider = '*';
            public bool isRdy
            {
                get
                {
                    if (rawdata == null) return false;
                    else return true;
                }
            }

            private DataStorage() { }
            private bool InitData(String datapath)
            {
                rawdata = new List<RawDataItem>();

                try
                {
                    StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] items = line.Split(divider);
                        String typeStr = items[0].Trim();
                        var item = new RawDataItem()
                        {
                            type = ToBuildingType(items[0].Trim()),
                            rooms = Convert.ToInt32(items[1].Trim()),
                            size = Convert.ToInt32(items[2].Trim()),
                            price = Convert.ToInt64(items[3].Trim())
                        };
                        rawdata.Add(item);
                    }

                    sr.Close();
                    BuildSummary();
                }

                catch(IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return false;
                }

                return true;
            }
            private void BuildSummary()
            {
                sumdata = new List<SummaryDataItem>();

            }
            public static DataStorage DataCreator(String path)
            {
                DataStorage d = new DataStorage();
                if (d.InitData(path))
                    return d;
                else
                    return null;
            }
            public List<RawDataItem> GetRawData()
            {
                if (this.isRdy)
                    return rawdata;
                else
                    return null;
            }
            public List<SummaryDataItem> GetSummaryData()
            {
                if (this.isRdy)
                    return sumdata;
                else
                    return null;
            }
        }
    }
}
