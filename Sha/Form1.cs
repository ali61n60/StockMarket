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


//ReadOnlyCollection<byte> hash = Sha256.HashFile(File.OpenRead(@"e:\tohash.txt"));
//System.Console.Out.WriteLine("{0}", Util.ArrayToString(hash));
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
            //ReadOnlyCollection<byte> byteData= new ReadOnlyCollection<byte>(Encoding.ASCII.GetBytes(data));
            ReadOnlyCollection<byte> hash1 = Sha256.HashFile(File.OpenRead(@"e:\tohash.txt"));
            ReadOnlyCollection<byte> hash2 = Sha256.HashString(data);

            richTextBox1.Text = Util.ArrayToString(hash1)+"\n\n\n\n";
            richTextBox1.Text += Util.ArrayToString(hash2);



        }

       
    }
}
