using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp_TuDienNoiAnh_Viet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.txbExplaination = new System.Windows.Forms.TextBox();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSpeakEnglish);
            this.panel1.Controls.Add(this.cbWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 349);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbExplaination);
            this.panel2.Controls.Add(this.txbMeaning);
            this.panel2.Location = new System.Drawing.Point(172, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 349);
            this.panel2.TabIndex = 1;
            // 
            // txbMeaning
            // 
            this.txbMeaning.Location = new System.Drawing.Point(3, 3);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.Size = new System.Drawing.Size(359, 20);
            this.txbMeaning.TabIndex = 0;
            // 
            // txbExplaination
            // 
            this.txbExplaination.Location = new System.Drawing.Point(3, 29);
            this.txbExplaination.Multiline = true;
            this.txbExplaination.Name = "txbExplaination";
            this.txbExplaination.Size = new System.Drawing.Size(359, 317);
            this.txbExplaination.TabIndex = 1;
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(0, 3);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(124, 345);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // btnSpeakEnglish
            // 
            
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(130, 3);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(20, 23);
            this.btnSpeakEnglish.TabIndex = 1;
            this.btnSpeakEnglish.UseVisualStyleBackColor = true;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // button1
            // 

            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(368, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 

            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(368, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anh - Việt | Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbExplaination;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}