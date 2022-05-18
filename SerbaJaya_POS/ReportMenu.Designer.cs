
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
            this.cbStatusEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportEmployee = new System.Windows.Forms.Button();
            this.btnFilterEmployee = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.TabPage();
            this.btnReportItem = new System.Windows.Forms.Button();
            this.btnFilterItem = new System.Windows.Forms.Button();
            this.cbStatusItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btnFilterSales = new System.Windows.Forms.Button();
            this.cbEmployeeSales = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEndSales = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSales = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PurchaseOrder = new System.Windows.Forms.TabPage();
            this.btnReportPO = new System.Windows.Forms.Button();
            this.btnFilterPO = new System.Windows.Forms.Button();
            this.dtpStartPO = new System.Windows.Forms.DateTimePicker();
            this.dtpEndPO = new System.Windows.Forms.DateTimePicker();
            this.cbSupplierPO = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEmployee = new System.Windows.Forms.CheckBox();
            this.checkPO = new System.Windows.Forms.CheckBox();
            this.cbStatusPO = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlReport.SuspendLayout();
            this.Employee.SuspendLayout();
            this.Item.SuspendLayout();
            this.Sales.SuspendLayout();
            this.PurchaseOrder.SuspendLayout();
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
            this.Employee.Controls.Add(this.cbStatusEmployee);
            this.Employee.Controls.Add(this.label4);
            this.Employee.Controls.Add(this.cbPosition);
            this.Employee.Controls.Add(this.label2);
            this.Employee.Controls.Add(this.btnReportEmployee);
            this.Employee.Controls.Add(this.btnFilterEmployee);
            this.Employee.Location = new System.Drawing.Point(4, 29);
            this.Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Employee.Size = new System.Drawing.Size(343, 723);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // cbStatusEmployee
            // 
            this.cbStatusEmployee.FormattingEnabled = true;
            this.cbStatusEmployee.Items.AddRange(new object[] {
            "Active",
            "Not Active",
            "- BOTH -"});
            this.cbStatusEmployee.Location = new System.Drawing.Point(26, 146);
            this.cbStatusEmployee.Name = "cbStatusEmployee";
            this.cbStatusEmployee.Size = new System.Drawing.Size(288, 28);
            this.cbStatusEmployee.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Status :";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Cashier",
            "Warehouse"});
            this.cbPosition.Location = new System.Drawing.Point(26, 65);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(288, 28);
            this.cbPosition.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Position :";
            // 
            // btnReportEmployee
            // 
            this.btnReportEmployee.Location = new System.Drawing.Point(174, 632);
            this.btnReportEmployee.Name = "btnReportEmployee";
            this.btnReportEmployee.Size = new System.Drawing.Size(140, 63);
            this.btnReportEmployee.TabIndex = 37;
            this.btnReportEmployee.Text = "Cetak Report";
            this.btnReportEmployee.UseVisualStyleBackColor = true;
            // 
            // btnFilterEmployee
            // 
            this.btnFilterEmployee.Location = new System.Drawing.Point(26, 632);
            this.btnFilterEmployee.Name = "btnFilterEmployee";
            this.btnFilterEmployee.Size = new System.Drawing.Size(127, 63);
            this.btnFilterEmployee.TabIndex = 36;
            this.btnFilterEmployee.Text = "Filter Data";
            this.btnFilterEmployee.UseVisualStyleBackColor = true;
            this.btnFilterEmployee.Click += new System.EventHandler(this.btnFilterEmployee_Click);
            // 
            // Item
            // 
            this.Item.Controls.Add(this.btnReportItem);
            this.Item.Controls.Add(this.btnFilterItem);
            this.Item.Controls.Add(this.cbStatusItem);
            this.Item.Controls.Add(this.label3);
            this.Item.Location = new System.Drawing.Point(4, 29);
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(3);
            this.Item.Size = new System.Drawing.Size(343, 723);
            this.Item.TabIndex = 2;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            // 
            // btnReportItem
            // 
            this.btnReportItem.Location = new System.Drawing.Point(170, 626);
            this.btnReportItem.Name = "btnReportItem";
            this.btnReportItem.Size = new System.Drawing.Size(140, 63);
            this.btnReportItem.TabIndex = 47;
            this.btnReportItem.Text = "Cetak Report";
            this.btnReportItem.UseVisualStyleBackColor = true;
            // 
            // btnFilterItem
            // 
            this.btnFilterItem.Location = new System.Drawing.Point(22, 626);
            this.btnFilterItem.Name = "btnFilterItem";
            this.btnFilterItem.Size = new System.Drawing.Size(127, 63);
            this.btnFilterItem.TabIndex = 46;
            this.btnFilterItem.Text = "Filter Data";
            this.btnFilterItem.UseVisualStyleBackColor = true;
            this.btnFilterItem.Click += new System.EventHandler(this.btnFilterItem_Click);
            // 
            // cbStatusItem
            // 
            this.cbStatusItem.FormattingEnabled = true;
            this.cbStatusItem.Items.AddRange(new object[] {
            "Active",
            "Not Active",
            "- BOTH -"});
            this.cbStatusItem.Location = new System.Drawing.Point(21, 59);
            this.cbStatusItem.Name = "cbStatusItem";
            this.cbStatusItem.Size = new System.Drawing.Size(288, 28);
            this.cbStatusItem.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Status :";
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.checkEmployee);
            this.Sales.Controls.Add(this.button5);
            this.Sales.Controls.Add(this.btnFilterSales);
            this.Sales.Controls.Add(this.cbEmployeeSales);
            this.Sales.Controls.Add(this.label11);
            this.Sales.Controls.Add(this.dtpEndSales);
            this.Sales.Controls.Add(this.dtpStartSales);
            this.Sales.Controls.Add(this.label6);
            this.Sales.Controls.Add(this.label7);
            this.Sales.Location = new System.Drawing.Point(4, 29);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(343, 723);
            this.Sales.TabIndex = 4;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 635);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 63);
            this.button5.TabIndex = 55;
            this.button5.Text = "Cetak Report";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnFilterSales
            // 
            this.btnFilterSales.Location = new System.Drawing.Point(22, 635);
            this.btnFilterSales.Name = "btnFilterSales";
            this.btnFilterSales.Size = new System.Drawing.Size(127, 63);
            this.btnFilterSales.TabIndex = 54;
            this.btnFilterSales.Text = "Filter Data";
            this.btnFilterSales.UseVisualStyleBackColor = true;
            this.btnFilterSales.Click += new System.EventHandler(this.btnFilterSales_Click);
            // 
            // cbEmployeeSales
            // 
            this.cbEmployeeSales.FormattingEnabled = true;
            this.cbEmployeeSales.Items.AddRange(new object[] {
            "Active",
            "Not Acctive",
            "- BOTH -"});
            this.cbEmployeeSales.Location = new System.Drawing.Point(23, 221);
            this.cbEmployeeSales.Name = "cbEmployeeSales";
            this.cbEmployeeSales.Size = new System.Drawing.Size(288, 28);
            this.cbEmployeeSales.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Employee :";
            // 
            // dtpEndSales
            // 
            this.dtpEndSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndSales.Location = new System.Drawing.Point(22, 142);
            this.dtpEndSales.Name = "dtpEndSales";
            this.dtpEndSales.Size = new System.Drawing.Size(288, 30);
            this.dtpEndSales.TabIndex = 47;
            // 
            // dtpStartSales
            // 
            this.dtpStartSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartSales.Location = new System.Drawing.Point(22, 61);
            this.dtpStartSales.Name = "dtpStartSales";
            this.dtpStartSales.Size = new System.Drawing.Size(288, 30);
            this.dtpStartSales.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Date End :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date Start :";
            // 
            // PurchaseOrder
            // 
            this.PurchaseOrder.Controls.Add(this.cbStatusPO);
            this.PurchaseOrder.Controls.Add(this.label12);
            this.PurchaseOrder.Controls.Add(this.checkPO);
            this.PurchaseOrder.Controls.Add(this.btnReportPO);
            this.PurchaseOrder.Controls.Add(this.btnFilterPO);
            this.PurchaseOrder.Controls.Add(this.dtpStartPO);
            this.PurchaseOrder.Controls.Add(this.dtpEndPO);
            this.PurchaseOrder.Controls.Add(this.cbSupplierPO);
            this.PurchaseOrder.Controls.Add(this.label10);
            this.PurchaseOrder.Controls.Add(this.label8);
            this.PurchaseOrder.Controls.Add(this.label9);
            this.PurchaseOrder.Location = new System.Drawing.Point(4, 29);
            this.PurchaseOrder.Name = "PurchaseOrder";
            this.PurchaseOrder.Size = new System.Drawing.Size(343, 723);
            this.PurchaseOrder.TabIndex = 5;
            this.PurchaseOrder.Text = "Purchase Order";
            this.PurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // btnReportPO
            // 
            this.btnReportPO.Location = new System.Drawing.Point(170, 635);
            this.btnReportPO.Name = "btnReportPO";
            this.btnReportPO.Size = new System.Drawing.Size(140, 63);
            this.btnReportPO.TabIndex = 55;
            this.btnReportPO.Text = "Cetak Report";
            this.btnReportPO.UseVisualStyleBackColor = true;
            // 
            // btnFilterPO
            // 
            this.btnFilterPO.Location = new System.Drawing.Point(22, 635);
            this.btnFilterPO.Name = "btnFilterPO";
            this.btnFilterPO.Size = new System.Drawing.Size(127, 63);
            this.btnFilterPO.TabIndex = 54;
            this.btnFilterPO.Text = "Filter Data";
            this.btnFilterPO.UseVisualStyleBackColor = true;
            this.btnFilterPO.Click += new System.EventHandler(this.btnFilterPO_Click);
            // 
            // dtpStartPO
            // 
            this.dtpStartPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartPO.Location = new System.Drawing.Point(22, 57);
            this.dtpStartPO.Name = "dtpStartPO";
            this.dtpStartPO.Size = new System.Drawing.Size(288, 30);
            this.dtpStartPO.TabIndex = 53;
            // 
            // dtpEndPO
            // 
            this.dtpEndPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndPO.Location = new System.Drawing.Point(22, 148);
            this.dtpEndPO.Name = "dtpEndPO";
            this.dtpEndPO.Size = new System.Drawing.Size(288, 30);
            this.dtpEndPO.TabIndex = 52;
            // 
            // cbSupplierPO
            // 
            this.cbSupplierPO.FormattingEnabled = true;
            this.cbSupplierPO.Items.AddRange(new object[] {
            ""});
            this.cbSupplierPO.Location = new System.Drawing.Point(22, 222);
            this.cbSupplierPO.Name = "cbSupplierPO";
            this.cbSupplierPO.Size = new System.Drawing.Size(288, 28);
            this.cbSupplierPO.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Supplier :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Date End :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Date Start :";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(396, 191);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1499, 716);
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
            // checkEmployee
            // 
            this.checkEmployee.AutoSize = true;
            this.checkEmployee.Location = new System.Drawing.Point(22, 256);
            this.checkEmployee.Name = "checkEmployee";
            this.checkEmployee.Size = new System.Drawing.Size(101, 24);
            this.checkEmployee.TabIndex = 56;
            this.checkEmployee.Text = "Select All";
            this.checkEmployee.UseVisualStyleBackColor = true;
            this.checkEmployee.CheckedChanged += new System.EventHandler(this.checkEmployee_CheckedChanged);
            // 
            // checkPO
            // 
            this.checkPO.AutoSize = true;
            this.checkPO.Location = new System.Drawing.Point(22, 256);
            this.checkPO.Name = "checkPO";
            this.checkPO.Size = new System.Drawing.Size(101, 24);
            this.checkPO.TabIndex = 57;
            this.checkPO.Text = "Select All";
            this.checkPO.UseVisualStyleBackColor = true;
            this.checkPO.CheckedChanged += new System.EventHandler(this.checkPO_CheckedChanged);
            // 
            // cbStatusPO
            // 
            this.cbStatusPO.FormattingEnabled = true;
            this.cbStatusPO.Items.AddRange(new object[] {
            "Active",
            "Not Active",
            "- BOTH -"});
            this.cbStatusPO.Location = new System.Drawing.Point(22, 334);
            this.cbStatusPO.Name = "cbStatusPO";
            this.cbStatusPO.Size = new System.Drawing.Size(288, 28);
            this.cbStatusPO.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 58;
            this.label12.Text = "Status :";
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label5);
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
            this.Item.ResumeLayout(false);
            this.Item.PerformLayout();
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            this.PurchaseOrder.ResumeLayout(false);
            this.PurchaseOrder.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Item;
        private System.Windows.Forms.Button btnReportEmployee;
        private System.Windows.Forms.Button btnFilterEmployee;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.TabPage PurchaseOrder;
        private System.Windows.Forms.ComboBox cbStatusEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReportItem;
        private System.Windows.Forms.Button btnFilterItem;
        private System.Windows.Forms.ComboBox cbStatusItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnFilterSales;
        private System.Windows.Forms.ComboBox cbEmployeeSales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEndSales;
        private System.Windows.Forms.DateTimePicker dtpStartSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReportPO;
        private System.Windows.Forms.Button btnFilterPO;
        private System.Windows.Forms.DateTimePicker dtpStartPO;
        private System.Windows.Forms.DateTimePicker dtpEndPO;
        private System.Windows.Forms.ComboBox cbSupplierPO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkEmployee;
        private System.Windows.Forms.CheckBox checkPO;
        private System.Windows.Forms.ComboBox cbStatusPO;
        private System.Windows.Forms.Label label12;
    }
}