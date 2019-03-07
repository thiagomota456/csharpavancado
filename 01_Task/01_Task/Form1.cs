using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string endereco = textBoxSite.Text;

            WebClient web = new WebClient();
            //string html = web.DownloadString(endereco);
            String html = await web.DownloadStringTaskAsync(new Uri(endereco));

            richTextBoxResultado.Text = html; 
        }
        
    }
}
