using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sha2;

namespace Sha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            ReadOnlyCollection<byte> byteData= new ReadOnlyCollection<byte>(Encoding.ASCII.GetBytes(data));
            ReadOnlyCollection<byte> hash = Sha256.HashFile(File.OpenRead(@"e:\tohash.txt"));

            richTextBox1.Text = Util.ArrayToString(byteData);

            
        }
    }
}
