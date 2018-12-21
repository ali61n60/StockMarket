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
using StockMarket.Model;

namespace StockMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       private void ReadData()
        {
            using (var reader = new StreamReader(@"C:\Users\test\Documents\TseClient 2.0\ghadir.csv",Encoding.Unicode))
            {
                List<StockPointData> listA = new List<StockPointData>();
                StockPointData tempPoint;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    tempPoint = new StockPointData();
                    tempPoint.StockName = values[0];
                    tempPoint.Date = values[1];
                    tempPoint.FirstPrice = values[2];
                    tempPoint.MaxPrice = values[3];
                    tempPoint.MinPrice = values[4];
                    tempPoint.FinalPrice = values[5];
                    tempPoint.Voume = values[6];
                    tempPoint.Value = values[7];
                    tempPoint.NumberOfDeals = values[8];
                    tempPoint.YesterdayPrice = values[9];
                    tempPoint.CompanyCode = values[10];
                    tempPoint.LatinName = values[11];
                    tempPoint.CompanyName = values[12];
                    tempPoint.Date2 = values[13];
                    tempPoint.LastPrice = values[14];
                    listA.Add(tempPoint);                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadData();
        }
    }
}

