
namespace SerbaJaya_POS
{
    partial class ReportMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.Employee = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.TabPage();
            this.Supplier = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sales = new System.Windows.Forms.TabPage();
            this.PurchaseOrder = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlReport.SuspendLayout();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 82);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serba Jaya Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerbaJaya_POS.Properties.Resources.report1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlReport
            // 
            this.tabControlReport.Controls.Add(this.Employee);
            this.tabControlReport.Controls.Add(this.Item);
            this.tabControlReport.Controls.Add(this.Supplier);
            this.tabControlReport.Controls.Add(this.Sales);
            this.tabControlReport.Controls.Add(this.PurchaseOrder);
            this.tabControlReport.Location = new System.Drawing.Point(12, 169);
            this.tabControlReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(351, 756);
            this.tabControlReport.TabIndex = 23;
            this.tabControlReport.SelectedIndexChanged += new System.EventHandler(this.tabControlReport_SelectedIndexChanged);
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.button2);
            this.Employee.Controls.Add(this.button1);
            this.Employee.Controls.Add(this.textBox1);
            this.Employee.Controls.Add(this.label6);
            this.Employee.Location = new System.Drawing.Point(4, 29);
            this.Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employee.Size = new System.Drawing.Size(343, 723);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 63);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cetak Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 63);
            this.button1.TabIndex = 36;
            this.button1.Text = "Filter Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Source Table";
            // 
            // Item
            // 
            this.Item.Location = new System.Drawing.Point(4, 29);
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(3);
            this.Item.Size = new System.Drawing.Size(343, 723);
            this.Item.TabIndex = 2;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            // 
            // Supplier
            // 
            this.Supplier.Location = new System.Drawing.Point(4, 29);
            this.Supplier.Name = "Supplier";
            this.Supplier.Padding = new System.Windows.Forms.Padding(3);
            this.Supplier.Size = new System.Drawing.Size(343, 723);
            this.Supplier.TabIndex = 3;
            this.Supplier.Text = "Supplier";
            this.Supplier.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(396, 191);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1499, 612);
            this.dgvReport.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 33;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBox1.Location = new System.Drawing.Point(369, 169);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1543, 756);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(396, 852);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1500, 53);
            this.tbSearch.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 824);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1884, 148);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(4, 29);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(343, 723);
            this.Sales.TabIndex = 4;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // PurchaseOrder
            // 
            this.PurchaseOrder.Location = new System.Drawing.Point(4, 29);
            this.PurchaseOrder.Name = "PurchaseOrder";
            this.PurchaseOrder.Size = new System.Drawing.Size(343, 723);
            this.PurchaseOrder.TabIndex = 5;
            this.PurchaseOrder.Text = "Purchase Order";
            this.PurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabControlReport);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportMenu";
            this.Text = "ReportMenu";
            this.Load += new System.EventHandler(this.ReportMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlReport.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            this.Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label5;
  
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Item;
        private System.Windows.Forms.TabPage Supplier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage PurchaseOrder;
    }
}