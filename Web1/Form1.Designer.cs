namespace Web1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add WebBrowser";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(220, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(312, 12);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(476, 20);
            this.txbAddress.TabIndex = 2;
            // 
            // pnlWeb
            // 
            this.pnlWeb.Location = new System.Drawing.Point(12, 41);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(776, 397);
            this.pnlWeb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlWeb);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Panel pnlWeb;
    }
}

