using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TuDienNoiAnh_Viet
{
    public partial class Form1 : Form
    {
        DictionaryManager dictionary;
        SpeakText VietNam;
        SpeakText English;
        public Form1()
        {
            InitializeComponent();

            cbWord.DisplayMember = "Key";

            WebBrowser wbVN = new WebBrowser();
            wbVN.Width = 0;
            wbVN.Height = 0;
            wbVN.Visible = false;
            wbVN.ScriptErrorsSuppressed = true;
            wbVN.Navigate(Cons.VietNamLink);


            this.Controls.Add(wbVN);

            WebBrowser wbEn = new WebBrowser();
            wbEn.Width = 0;
            wbEn.Height = 0;
            wbEn.Visible = false;
            wbEn.ScriptErrorsSuppressed = true;
            wbEn.Navigate(Cons.EnglishLink);
            this.Controls.Add(wbEn);

            VietNam = new SpeakText(wbVN);
            English = new SpeakText(wbEn);

            dictionary = new DictionaryManager();

            dictionary.LoadDataToCombobox(cbWord);
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }

            dictionary.Serialize();
        }

        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.DataSource == null)
                return;

            DictionaryData data = cb.SelectedItem as DictionaryData;

            txbMeaning.Text = data.Meaning;
            txbExplaination.Text = data.Explaination;
        }

        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            English.Speak((cbWord.SelectedItem as DictionaryData).Key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VietNam.Speak(txbMeaning.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VietNam.Speak(txbExplaination.Text);
        }
    }
}
