namespace NodeOrdersAnalysis
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
            this.CDdataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCD = new System.Windows.Forms.Button();
            this.SalesPersonButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CDdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CDdataGridView
            // 
            this.CDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CDdataGridView.Location = new System.Drawing.Point(122, 154);
            this.CDdataGridView.Name = "CDdataGridView";
            this.CDdataGridView.Size = new System.Drawing.Size(551, 308);
            this.CDdataGridView.TabIndex = 0;
            // 
            // buttonCD
            // 
            this.buttonCD.Location = new System.Drawing.Point(339, 67);
            this.buttonCD.Name = "buttonCD";
            this.buttonCD.Size = new System.Drawing.Size(90, 23);
            this.buttonCD.TabIndex = 1;
            this.buttonCD.Text = "CD Analysis";
            this.buttonCD.UseVisualStyleBackColor = true;
            this.buttonCD.Click += new System.EventHandler(this.buttonCD_Click);
            // 
            // SalesPersonButton
            // 
            this.SalesPersonButton.Location = new System.Drawing.Point(503, 66);
            this.SalesPersonButton.Name = "SalesPersonButton";
            this.SalesPersonButton.Size = new System.Drawing.Size(119, 23);
            this.SalesPersonButton.TabIndex = 2;
            this.SalesPersonButton.Text = "SalesPerson Analysis";
            this.SalesPersonButton.UseVisualStyleBackColor = true;
            this.SalesPersonButton.Click += new System.EventHandler(this.SalesPersonButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Store Analysis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(382, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Orders Analysis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(894, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SalesPersonButton);
            this.Controls.Add(this.buttonCD);
            this.Controls.Add(this.CDdataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CDdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CDdataGridView;
        private System.Windows.Forms.Button buttonCD;
        private System.Windows.Forms.Button SalesPersonButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

