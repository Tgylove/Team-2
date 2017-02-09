namespace DataAnalysisApp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(61, 130);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(262, 49);
            this.btnCD.TabIndex = 1;
            this.btnCD.Text = "CD Analysis";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(686, 130);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(262, 49);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales Person Analysis";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(1344, 130);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(262, 49);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Store Analysis";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 857);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStore;
    }
}

