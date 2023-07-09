using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web1
{
    public partial class Form1 : Form
    {
        WebBrowser wb;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 900;
            wb.Height = 400;
            wb.DocumentCompleted += wb_DocumentCompleted;
            pnlWeb.Controls.Add(wb);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string link = txbAddress.Text;
            wb.Navigate(link);
        }
    }
}
