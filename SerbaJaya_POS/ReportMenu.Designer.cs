
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
            this.checkPosition = new System.Windows.Forms.CheckBox();
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
            this.checkDateSales = new System.Windows.Forms.CheckBox();
            this.checkEmployee = new System.Windows.Forms.CheckBox();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.btnFilterSales = new System.Windows.Forms.Button();
            this.cbEmployeeSales = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEndSales = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSales = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PurchaseOrder = new System.Windows.Forms.TabPage();
            this.checkPODate = new System.Windows.Forms.CheckBox();
            this.cbStatusPO = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkPO = new System.Windows.Forms.CheckBox();
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
            this.label1.Location = new System.Drawing.Point(143, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 69);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serba Jaya Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SerbaJaya_POS.Properties.Resources.report1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 102);
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
            this.tabControlReport.Location = new System.Drawing.Point(11, 135);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(312, 605);
            this.tabControlReport.TabIndex = 23;
            this.tabControlReport.SelectedIndexChanged += new System.EventHandler(this.tabControlReport_SelectedIndexChanged);
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.checkPosition);
            this.Employee.Controls.Add(this.cbStatusEmployee);
            this.Employee.Controls.Add(this.label4);
            this.Employee.Controls.Add(this.cbPosition);
            this.Employee.Controls.Add(this.label2);
            this.Employee.Controls.Add(this.btnReportEmployee);
            this.Employee.Controls.Add(this.btnFilterEmployee);
            this.Employee.Location = new System.Drawing.Point(4, 25);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Employee.Size = new System.Drawing.Size(304, 576);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // checkPosition
            // 
            this.checkPosition.AutoSize = true;
            this.checkPosition.Location = new System.Drawing.Point(23, 79);
            this.checkPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPosition.Name = "checkPosition";
            this.checkPosition.Size = new System.Drawing.Size(88, 21);
            this.checkPosition.TabIndex = 57;
            this.checkPosition.Text = "Select All";
            this.checkPosition.UseVisualStyleBackColor = true;
            this.checkPosition.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbStatusEmployee
            // 
            this.cbStatusEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatusEmployee.DisplayMember = "- BOTH -";
            this.cbStatusEmployee.FormattingEnabled = true;
            this.cbStatusEmployee.Items.AddRange(new object[] {
            "Active",
            "Not Active",
            "- BOTH -"});
            this.cbStatusEmployee.Location = new System.Drawing.Point(23, 137);
            this.cbStatusEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusEmployee.Name = "cbStatusEmployee";
            this.cbStatusEmployee.Size = new System.Drawing.Size(256, 24);
            this.cbStatusEmployee.TabIndex = 41;
            this.cbStatusEmployee.Text = "- BOTH -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Status :";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Cashier",
            "Warehouse"});
            this.cbPosition.Location = new System.Drawing.Point(23, 52);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(256, 24);
            this.cbPosition.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Position :";
            // 
            // btnReportEmployee
            // 
            this.btnReportEmployee.Location = new System.Drawing.Point(155, 506);
            this.btnReportEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportEmployee.Name = "btnReportEmployee";
            this.btnReportEmployee.Size = new System.Drawing.Size(124, 50);
            this.btnReportEmployee.TabIndex = 37;
            this.btnReportEmployee.Text = "Cetak Report";
            this.btnReportEmployee.UseVisualStyleBackColor = true;
            this.btnReportEmployee.Click += new System.EventHandler(this.btnReportEmployee_Click);
            // 
            // btnFilterEmployee
            // 
            this.btnFilterEmployee.Location = new System.Drawing.Point(23, 506);
            this.btnFilterEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilterEmployee.Name = "btnFilterEmployee";
            this.btnFilterEmployee.Size = new System.Drawing.Size(113, 50);
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
            this.Item.Location = new System.Drawing.Point(4, 25);
            this.Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item.Name = "Item";
            this.Item.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item.Size = new System.Drawing.Size(304, 576);
            this.Item.TabIndex = 2;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            // 
            // btnReportItem
            // 
            this.btnReportItem.Location = new System.Drawing.Point(151, 501);
            this.btnReportItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportItem.Name = "btnReportItem";
            this.btnReportItem.Size = new System.Drawing.Size(124, 50);
            this.btnReportItem.TabIndex = 47;
            this.btnReportItem.Text = "Cetak Report";
            this.btnReportItem.UseVisualStyleBackColor = true;
            this.btnReportItem.Click += new System.EventHandler(this.btnReportItem_Click);
            // 
            // btnFilterItem
            // 
            this.btnFilterItem.Location = new System.Drawing.Point(20, 501);
            this.btnFilterItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilterItem.Name = "btnFilterItem";
            this.btnFilterItem.Size = new System.Drawing.Size(113, 50);
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
            this.cbStatusItem.Location = new System.Drawing.Point(19, 47);
            this.cbStatusItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusItem.Name = "cbStatusItem";
            this.cbStatusItem.Size = new System.Drawing.Size(256, 24);
            this.cbStatusItem.TabIndex = 45;
            this.cbStatusItem.Text = "- BOTH -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Status :";
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.checkDateSales);
            this.Sales.Controls.Add(this.checkEmployee);
            this.Sales.Controls.Add(this.btnReportSales);
            this.Sales.Controls.Add(this.btnFilterSales);
            this.Sales.Controls.Add(this.cbEmployeeSales);
            this.Sales.Controls.Add(this.label11);
            this.Sales.Controls.Add(this.dtpEndSales);
            this.Sales.Controls.Add(this.dtpStartSales);
            this.Sales.Controls.Add(this.label6);
            this.Sales.Controls.Add(this.label7);
            this.Sales.Location = new System.Drawing.Point(4, 25);
            this.Sales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sales.Size = new System.Drawing.Size(304, 576);
            this.Sales.TabIndex = 4;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // checkDateSales
            // 
            this.checkDateSales.AutoSize = true;
            this.checkDateSales.Location = new System.Drawing.Point(20, 142);
            this.checkDateSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkDateSales.Name = "checkDateSales";
            this.checkDateSales.Size = new System.Drawing.Size(80, 21);
            this.checkDateSales.TabIndex = 61;
            this.checkDateSales.Text = "All Time";
            this.checkDateSales.UseVisualStyleBackColor = true;
            this.checkDateSales.CheckedChanged += new System.EventHandler(this.cbDateSales_CheckedChanged);
            // 
            // checkEmployee
            // 
            this.checkEmployee.AutoSize = true;
            this.checkEmployee.Location = new System.Drawing.Point(20, 235);
            this.checkEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEmployee.Name = "checkEmployee";
            this.checkEmployee.Size = new System.Drawing.Size(88, 21);
            this.checkEmployee.TabIndex = 56;
            this.checkEmployee.Text = "Select All";
            this.checkEmployee.UseVisualStyleBackColor = true;
            this.checkEmployee.CheckedChanged += new System.EventHandler(this.checkEmployee_CheckedChanged);
            // 
            // btnReportSales
            // 
            this.btnReportSales.Location = new System.Drawing.Point(151, 508);
            this.btnReportSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(124, 50);
            this.btnReportSales.TabIndex = 55;
            this.btnReportSales.Text = "Cetak Report";
            this.btnReportSales.UseVisualStyleBackColor = true;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            // 
            // btnFilterSales
            // 
            this.btnFilterSales.Location = new System.Drawing.Point(20, 508);
            this.btnFilterSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilterSales.Name = "btnFilterSales";
            this.btnFilterSales.Size = new System.Drawing.Size(113, 50);
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
            this.cbEmployeeSales.Location = new System.Drawing.Point(20, 207);
            this.cbEmployeeSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeSales.Name = "cbEmployeeSales";
            this.cbEmployeeSales.Size = new System.Drawing.Size(256, 24);
            this.cbEmployeeSales.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Employee :";
            // 
            // dtpEndSales
            // 
            this.dtpEndSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndSales.Location = new System.Drawing.Point(20, 114);
            this.dtpEndSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndSales.Name = "dtpEndSales";
            this.dtpEndSales.Size = new System.Drawing.Size(256, 26);
            this.dtpEndSales.TabIndex = 47;
            // 
            // dtpStartSales
            // 
            this.dtpStartSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartSales.Location = new System.Drawing.Point(20, 49);
            this.dtpStartSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartSales.Name = "dtpStartSales";
            this.dtpStartSales.Size = new System.Drawing.Size(256, 26);
            this.dtpStartSales.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Date End :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Date Start :";
            // 
            // PurchaseOrder
            // 
            this.PurchaseOrder.Controls.Add(this.checkPODate);
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
            this.PurchaseOrder.Location = new System.Drawing.Point(4, 25);
            this.PurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PurchaseOrder.Name = "PurchaseOrder";
            this.PurchaseOrder.Size = new System.Drawing.Size(304, 576);
            this.PurchaseOrder.TabIndex = 5;
            this.PurchaseOrder.Text = "Purchase Order";
            this.PurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // checkPODate
            // 
            this.checkPODate.AutoSize = true;
            this.checkPODate.Location = new System.Drawing.Point(20, 147);
            this.checkPODate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPODate.Name = "checkPODate";
            this.checkPODate.Size = new System.Drawing.Size(80, 21);
            this.checkPODate.TabIndex = 60;
            this.checkPODate.Text = "All Time";
            this.checkPODate.UseVisualStyleBackColor = true;
            this.checkPODate.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbStatusPO
            // 
            this.cbStatusPO.FormattingEnabled = true;
            this.cbStatusPO.Items.AddRange(new object[] {
            "Active",
            "Not Active",
            "- BOTH -"});
            this.cbStatusPO.Location = new System.Drawing.Point(20, 291);
            this.cbStatusPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusPO.Name = "cbStatusPO";
            this.cbStatusPO.Size = new System.Drawing.Size(256, 24);
            this.cbStatusPO.TabIndex = 59;
            this.cbStatusPO.Text = "- BOTH -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Status :";
            // 
            // checkPO
            // 
            this.checkPO.AutoSize = true;
            this.checkPO.Location = new System.Drawing.Point(20, 233);
            this.checkPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPO.Name = "checkPO";
            this.checkPO.Size = new System.Drawing.Size(88, 21);
            this.checkPO.TabIndex = 57;
            this.checkPO.Text = "Select All";
            this.checkPO.UseVisualStyleBackColor = true;
            this.checkPO.CheckedChanged += new System.EventHandler(this.checkPO_CheckedChanged);
            // 
            // btnReportPO
            // 
            this.btnReportPO.Location = new System.Drawing.Point(151, 508);
            this.btnReportPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportPO.Name = "btnReportPO";
            this.btnReportPO.Size = new System.Drawing.Size(124, 50);
            this.btnReportPO.TabIndex = 55;
            this.btnReportPO.Text = "Cetak Report";
            this.btnReportPO.UseVisualStyleBackColor = true;
            this.btnReportPO.Click += new System.EventHandler(this.btnReportPO_Click);
            // 
            // btnFilterPO
            // 
            this.btnFilterPO.Location = new System.Drawing.Point(20, 508);
            this.btnFilterPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilterPO.Name = "btnFilterPO";
            this.btnFilterPO.Size = new System.Drawing.Size(113, 50);
            this.btnFilterPO.TabIndex = 54;
            this.btnFilterPO.Text = "Filter Data";
            this.btnFilterPO.UseVisualStyleBackColor = true;
            this.btnFilterPO.Click += new System.EventHandler(this.btnFilterPO_Click);
            // 
            // dtpStartPO
            // 
            this.dtpStartPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartPO.Location = new System.Drawing.Point(20, 46);
            this.dtpStartPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartPO.Name = "dtpStartPO";
            this.dtpStartPO.Size = new System.Drawing.Size(256, 26);
            this.dtpStartPO.TabIndex = 53;
            // 
            // dtpEndPO
            // 
            this.dtpEndPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndPO.Location = new System.Drawing.Point(20, 118);
            this.dtpEndPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndPO.Name = "dtpEndPO";
            this.dtpEndPO.Size = new System.Drawing.Size(256, 26);
            this.dtpEndPO.TabIndex = 52;
            // 
            // cbSupplierPO
            // 
            this.cbSupplierPO.FormattingEnabled = true;
            this.cbSupplierPO.Items.AddRange(new object[] {
            ""});
            this.cbSupplierPO.Location = new System.Drawing.Point(20, 206);
            this.cbSupplierPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSupplierPO.Name = "cbSupplierPO";
            this.cbSupplierPO.Size = new System.Drawing.Size(256, 24);
            this.cbSupplierPO.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Supplier :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Date End :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Date Start :";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(352, 153);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1332, 573);
            this.dgvReport.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 33;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.richTextBox1.Location = new System.Drawing.Point(328, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1372, 606);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1675, 118);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabControlReport);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button btnReportSales;
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
        private System.Windows.Forms.CheckBox checkPosition;
        private System.Windows.Forms.CheckBox checkPODate;
        private System.Windows.Forms.CheckBox checkDateSales;
    }
}