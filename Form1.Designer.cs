namespace Altered
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.CRTYearlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CRTSalesVsExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.supplier = new System.Windows.Forms.TabPage();
            this.SupplierDGV = new System.Windows.Forms.DataGridView();
            this.BtnDeleteSupplier = new System.Windows.Forms.Button();
            this.BtnEditSupplier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SupVatNo = new System.Windows.Forms.RadioButton();
            this.SupVatYes = new System.Windows.Forms.RadioButton();
            this.TxtSupPostCode = new System.Windows.Forms.TextBox();
            this.TxtSupAddress = new System.Windows.Forms.RichTextBox();
            this.TxtSupRegistration = new System.Windows.Forms.TextBox();
            this.TxtSupCellphone = new System.Windows.Forms.TextBox();
            this.TxtSupTelephone = new System.Windows.Forms.TextBox();
            this.TxtSupEmail = new System.Windows.Forms.TextBox();
            this.TxtSupRepName = new System.Windows.Forms.TextBox();
            this.TxtSupCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelSupplier = new System.Windows.Forms.Button();
            this.BtnAddSupplier = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.TabPage();
            this.BtnEditOrder = new System.Windows.Forms.Button();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnViewOrder = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.customers = new System.Windows.Forms.TabPage();
            this.BtnEditCustomer = new System.Windows.Forms.Button();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCusCompany = new System.Windows.Forms.TextBox();
            this.TxtCusRepName = new System.Windows.Forms.TextBox();
            this.TxtCusEmail = new System.Windows.Forms.TextBox();
            this.TxtCusTelephone = new System.Windows.Forms.TextBox();
            this.TxtCusCellphone = new System.Windows.Forms.TextBox();
            this.TxtCusRegistration = new System.Windows.Forms.TextBox();
            this.TxtCusPosCode = new System.Windows.Forms.TextBox();
            this.TxtCusAddress = new System.Windows.Forms.RichTextBox();
            this.CusVatNo = new System.Windows.Forms.RadioButton();
            this.CusVatYes = new System.Windows.Forms.RadioButton();
            this.BtnCancelCustomer = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.invoices = new System.Windows.Forms.TabPage();
            this.BtnConvertInvoice = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnHideInItems = new System.Windows.Forms.Button();
            this.ViewItemsDGV = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCancelUpdate = new System.Windows.Forms.Button();
            this.BtnUpdateInvoice = new System.Windows.Forms.Button();
            this.DateInvoicePaidDate = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.LblInvoiceNumber = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.RadInPaidNo = new System.Windows.Forms.RadioButton();
            this.RadInPaidYes = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.BtnDeleteInvoice = new System.Windows.Forms.Button();
            this.BtnViewInvoice = new System.Windows.Forms.Button();
            this.BtnEditInvoice = new System.Windows.Forms.Button();
            this.BtnNewInvoice = new System.Windows.Forms.Button();
            this.InvoiceDGV = new System.Windows.Forms.DataGridView();
            this.products = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtProductDesc = new System.Windows.Forms.TextBox();
            this.TxtProductPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtPictureLocation = new System.Windows.Forms.TextBox();
            this.BtnCancelProduct = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.BtnEditProduct = new System.Windows.Forms.Button();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.reports = new System.Windows.Forms.TabPage();
            this.ReportsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReportsDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.TxtReportYear = new System.Windows.Forms.TextBox();
            this.BtnClearReports = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnMonthlyExpenses = new System.Windows.Forms.Button();
            this.BtnYearlySales = new System.Windows.Forms.Button();
            this.system = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnEmailInvoice = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRTYearlySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRTSalesVsExpenses)).BeginInit();
            this.supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            this.customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.invoices.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewItemsDGV)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGV)).BeginInit();
            this.products.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.system.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home);
            this.tabControl1.Controls.Add(this.supplier);
            this.tabControl1.Controls.Add(this.order);
            this.tabControl1.Controls.Add(this.customers);
            this.tabControl1.Controls.Add(this.invoices);
            this.tabControl1.Controls.Add(this.products);
            this.tabControl1.Controls.Add(this.reports);
            this.tabControl1.Controls.Add(this.system);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1434, 804);
            this.tabControl1.TabIndex = 0;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.DimGray;
            this.home.Controls.Add(this.CRTYearlySales);
            this.home.Controls.Add(this.CRTSalesVsExpenses);
            this.home.Location = new System.Drawing.Point(4, 25);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1426, 775);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            // 
            // CRTYearlySales
            // 
            chartArea1.Name = "ChartArea1";
            this.CRTYearlySales.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.CRTYearlySales.Legends.Add(legend1);
            this.CRTYearlySales.Location = new System.Drawing.Point(730, 44);
            this.CRTYearlySales.Name = "CRTYearlySales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Expenses";
            this.CRTYearlySales.Series.Add(series1);
            this.CRTYearlySales.Series.Add(series2);
            this.CRTYearlySales.Size = new System.Drawing.Size(677, 300);
            this.CRTYearlySales.TabIndex = 1;
            this.CRTYearlySales.Text = "chart1";
            // 
            // CRTSalesVsExpenses
            // 
            chartArea2.Name = "ChartArea1";
            this.CRTSalesVsExpenses.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.CRTSalesVsExpenses.Legends.Add(legend2);
            this.CRTSalesVsExpenses.Location = new System.Drawing.Point(19, 44);
            this.CRTSalesVsExpenses.Name = "CRTSalesVsExpenses";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sales";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Purchases";
            this.CRTSalesVsExpenses.Series.Add(series3);
            this.CRTSalesVsExpenses.Series.Add(series4);
            this.CRTSalesVsExpenses.Size = new System.Drawing.Size(677, 300);
            this.CRTSalesVsExpenses.TabIndex = 0;
            this.CRTSalesVsExpenses.Text = "chart1";
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.DimGray;
            this.supplier.Controls.Add(this.SupplierDGV);
            this.supplier.Controls.Add(this.BtnDeleteSupplier);
            this.supplier.Controls.Add(this.BtnEditSupplier);
            this.supplier.Controls.Add(this.groupBox1);
            this.supplier.Location = new System.Drawing.Point(4, 25);
            this.supplier.Name = "supplier";
            this.supplier.Padding = new System.Windows.Forms.Padding(3);
            this.supplier.Size = new System.Drawing.Size(1426, 775);
            this.supplier.TabIndex = 1;
            this.supplier.Text = "Supplier";
            // 
            // SupplierDGV
            // 
            this.SupplierDGV.AllowUserToAddRows = false;
            this.SupplierDGV.AllowUserToDeleteRows = false;
            this.SupplierDGV.AllowUserToResizeRows = false;
            this.SupplierDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDGV.Location = new System.Drawing.Point(6, 394);
            this.SupplierDGV.MultiSelect = false;
            this.SupplierDGV.Name = "SupplierDGV";
            this.SupplierDGV.ReadOnly = true;
            this.SupplierDGV.RowHeadersVisible = false;
            this.SupplierDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierDGV.Size = new System.Drawing.Size(1414, 316);
            this.SupplierDGV.TabIndex = 1;
            // 
            // BtnDeleteSupplier
            // 
            this.BtnDeleteSupplier.Location = new System.Drawing.Point(728, 727);
            this.BtnDeleteSupplier.Name = "BtnDeleteSupplier";
            this.BtnDeleteSupplier.Size = new System.Drawing.Size(75, 27);
            this.BtnDeleteSupplier.TabIndex = 13;
            this.BtnDeleteSupplier.Text = "&Delete";
            this.BtnDeleteSupplier.UseVisualStyleBackColor = true;
            this.BtnDeleteSupplier.Click += new System.EventHandler(this.BtnDeleteSupplier_Click);
            // 
            // BtnEditSupplier
            // 
            this.BtnEditSupplier.Location = new System.Drawing.Point(634, 727);
            this.BtnEditSupplier.Name = "BtnEditSupplier";
            this.BtnEditSupplier.Size = new System.Drawing.Size(75, 27);
            this.BtnEditSupplier.TabIndex = 12;
            this.BtnEditSupplier.Text = "&Edit";
            this.BtnEditSupplier.UseVisualStyleBackColor = true;
            this.BtnEditSupplier.Click += new System.EventHandler(this.BtnEditSupplier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SupVatNo);
            this.groupBox1.Controls.Add(this.SupVatYes);
            this.groupBox1.Controls.Add(this.TxtSupPostCode);
            this.groupBox1.Controls.Add(this.TxtSupAddress);
            this.groupBox1.Controls.Add(this.TxtSupRegistration);
            this.groupBox1.Controls.Add(this.TxtSupCellphone);
            this.groupBox1.Controls.Add(this.TxtSupTelephone);
            this.groupBox1.Controls.Add(this.TxtSupEmail);
            this.groupBox1.Controls.Add(this.TxtSupRepName);
            this.groupBox1.Controls.Add(this.TxtSupCompany);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnCancelSupplier);
            this.groupBox1.Controls.Add(this.BtnAddSupplier);
            this.groupBox1.Location = new System.Drawing.Point(215, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Supplier";
            // 
            // SupVatNo
            // 
            this.SupVatNo.AutoSize = true;
            this.SupVatNo.Checked = true;
            this.SupVatNo.Location = new System.Drawing.Point(754, 67);
            this.SupVatNo.Name = "SupVatNo";
            this.SupVatNo.Size = new System.Drawing.Size(44, 21);
            this.SupVatNo.TabIndex = 11;
            this.SupVatNo.TabStop = true;
            this.SupVatNo.Text = "No";
            this.SupVatNo.UseVisualStyleBackColor = true;
            // 
            // SupVatYes
            // 
            this.SupVatYes.AutoSize = true;
            this.SupVatYes.Location = new System.Drawing.Point(684, 67);
            this.SupVatYes.Name = "SupVatYes";
            this.SupVatYes.Size = new System.Drawing.Size(50, 21);
            this.SupVatYes.TabIndex = 10;
            this.SupVatYes.Text = "Yes";
            this.SupVatYes.UseVisualStyleBackColor = true;
            // 
            // TxtSupPostCode
            // 
            this.TxtSupPostCode.Location = new System.Drawing.Point(684, 174);
            this.TxtSupPostCode.Name = "TxtSupPostCode";
            this.TxtSupPostCode.Size = new System.Drawing.Size(284, 23);
            this.TxtSupPostCode.TabIndex = 9;
            // 
            // TxtSupAddress
            // 
            this.TxtSupAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSupAddress.Location = new System.Drawing.Point(684, 106);
            this.TxtSupAddress.Name = "TxtSupAddress";
            this.TxtSupAddress.Size = new System.Drawing.Size(284, 54);
            this.TxtSupAddress.TabIndex = 8;
            this.TxtSupAddress.Text = "";
            // 
            // TxtSupRegistration
            // 
            this.TxtSupRegistration.Location = new System.Drawing.Point(684, 26);
            this.TxtSupRegistration.Name = "TxtSupRegistration";
            this.TxtSupRegistration.Size = new System.Drawing.Size(284, 23);
            this.TxtSupRegistration.TabIndex = 6;
            // 
            // TxtSupCellphone
            // 
            this.TxtSupCellphone.Location = new System.Drawing.Point(160, 174);
            this.TxtSupCellphone.Name = "TxtSupCellphone";
            this.TxtSupCellphone.Size = new System.Drawing.Size(312, 23);
            this.TxtSupCellphone.TabIndex = 5;
            // 
            // TxtSupTelephone
            // 
            this.TxtSupTelephone.Location = new System.Drawing.Point(160, 137);
            this.TxtSupTelephone.Name = "TxtSupTelephone";
            this.TxtSupTelephone.Size = new System.Drawing.Size(312, 23);
            this.TxtSupTelephone.TabIndex = 4;
            // 
            // TxtSupEmail
            // 
            this.TxtSupEmail.Location = new System.Drawing.Point(160, 100);
            this.TxtSupEmail.Name = "TxtSupEmail";
            this.TxtSupEmail.Size = new System.Drawing.Size(312, 23);
            this.TxtSupEmail.TabIndex = 3;
            // 
            // TxtSupRepName
            // 
            this.TxtSupRepName.Location = new System.Drawing.Point(160, 63);
            this.TxtSupRepName.Name = "TxtSupRepName";
            this.TxtSupRepName.Size = new System.Drawing.Size(312, 23);
            this.TxtSupRepName.TabIndex = 2;
            // 
            // TxtSupCompany
            // 
            this.TxtSupCompany.Location = new System.Drawing.Point(160, 26);
            this.TxtSupCompany.Name = "TxtSupCompany";
            this.TxtSupCompany.Size = new System.Drawing.Size(312, 23);
            this.TxtSupCompany.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Postal Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "VAT Registered:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registration Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cellphone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rep Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company:";
            // 
            // BtnCancelSupplier
            // 
            this.BtnCancelSupplier.Location = new System.Drawing.Point(513, 263);
            this.BtnCancelSupplier.Name = "BtnCancelSupplier";
            this.BtnCancelSupplier.Size = new System.Drawing.Size(75, 27);
            this.BtnCancelSupplier.TabIndex = 11;
            this.BtnCancelSupplier.Text = "&Cancel";
            this.BtnCancelSupplier.UseVisualStyleBackColor = true;
            this.BtnCancelSupplier.Click += new System.EventHandler(this.BtnCancelSupplier_Click);
            // 
            // BtnAddSupplier
            // 
            this.BtnAddSupplier.Location = new System.Drawing.Point(419, 263);
            this.BtnAddSupplier.Name = "BtnAddSupplier";
            this.BtnAddSupplier.Size = new System.Drawing.Size(75, 27);
            this.BtnAddSupplier.TabIndex = 10;
            this.BtnAddSupplier.Text = "&Add";
            this.BtnAddSupplier.UseVisualStyleBackColor = true;
            this.BtnAddSupplier.Click += new System.EventHandler(this.BtnAddSupplier_Click);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.DimGray;
            this.order.Controls.Add(this.BtnEditOrder);
            this.order.Controls.Add(this.BtnDeleteOrder);
            this.order.Controls.Add(this.BtnViewOrder);
            this.order.Controls.Add(this.BtnNewOrder);
            this.order.Controls.Add(this.OrdersDGV);
            this.order.Location = new System.Drawing.Point(4, 25);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(1426, 775);
            this.order.TabIndex = 2;
            this.order.Text = "Orders";
            // 
            // BtnEditOrder
            // 
            this.BtnEditOrder.Location = new System.Drawing.Point(629, 444);
            this.BtnEditOrder.Name = "BtnEditOrder";
            this.BtnEditOrder.Size = new System.Drawing.Size(85, 27);
            this.BtnEditOrder.TabIndex = 2;
            this.BtnEditOrder.Text = "&Edit";
            this.BtnEditOrder.UseVisualStyleBackColor = true;
            this.BtnEditOrder.Click += new System.EventHandler(this.BtnEditOrder_Click);
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.Location = new System.Drawing.Point(728, 444);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(85, 27);
            this.BtnDeleteOrder.TabIndex = 3;
            this.BtnDeleteOrder.Text = "&Delete";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            this.BtnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // BtnViewOrder
            // 
            this.BtnViewOrder.Location = new System.Drawing.Point(827, 444);
            this.BtnViewOrder.Name = "BtnViewOrder";
            this.BtnViewOrder.Size = new System.Drawing.Size(85, 27);
            this.BtnViewOrder.TabIndex = 4;
            this.BtnViewOrder.Text = "&View";
            this.BtnViewOrder.UseVisualStyleBackColor = true;
            this.BtnViewOrder.Click += new System.EventHandler(this.BtnViewOrder_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(530, 444);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(85, 27);
            this.BtnNewOrder.TabIndex = 1;
            this.BtnNewOrder.Text = "&New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AllowUserToDeleteRows = false;
            this.OrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Location = new System.Drawing.Point(36, 30);
            this.OrdersDGV.MultiSelect = false;
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.ReadOnly = true;
            this.OrdersDGV.RowHeadersVisible = false;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(1366, 396);
            this.OrdersDGV.TabIndex = 0;
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.DimGray;
            this.customers.Controls.Add(this.BtnEditCustomer);
            this.customers.Controls.Add(this.BtnDeleteCustomer);
            this.customers.Controls.Add(this.CustomerDGV);
            this.customers.Controls.Add(this.groupBox2);
            this.customers.Location = new System.Drawing.Point(4, 25);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(1426, 775);
            this.customers.TabIndex = 3;
            this.customers.Text = "Customers";
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.Location = new System.Drawing.Point(634, 727);
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(75, 27);
            this.BtnEditCustomer.TabIndex = 14;
            this.BtnEditCustomer.Text = "&Edit";
            this.BtnEditCustomer.UseVisualStyleBackColor = true;
            this.BtnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(728, 727);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(75, 27);
            this.BtnDeleteCustomer.TabIndex = 15;
            this.BtnDeleteCustomer.Text = "&Delete";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = true;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToAddRows = false;
            this.CustomerDGV.AllowUserToDeleteRows = false;
            this.CustomerDGV.AllowUserToResizeRows = false;
            this.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Location = new System.Drawing.Point(6, 394);
            this.CustomerDGV.MultiSelect = false;
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.ReadOnly = true;
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerDGV.Size = new System.Drawing.Size(1414, 316);
            this.CustomerDGV.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCusCompany);
            this.groupBox2.Controls.Add(this.TxtCusRepName);
            this.groupBox2.Controls.Add(this.TxtCusEmail);
            this.groupBox2.Controls.Add(this.TxtCusTelephone);
            this.groupBox2.Controls.Add(this.TxtCusCellphone);
            this.groupBox2.Controls.Add(this.TxtCusRegistration);
            this.groupBox2.Controls.Add(this.TxtCusPosCode);
            this.groupBox2.Controls.Add(this.TxtCusAddress);
            this.groupBox2.Controls.Add(this.CusVatNo);
            this.groupBox2.Controls.Add(this.CusVatYes);
            this.groupBox2.Controls.Add(this.BtnCancelCustomer);
            this.groupBox2.Controls.Add(this.BtnAddCustomer);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(215, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1004, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customer";
            // 
            // TxtCusCompany
            // 
            this.TxtCusCompany.Location = new System.Drawing.Point(160, 26);
            this.TxtCusCompany.Name = "TxtCusCompany";
            this.TxtCusCompany.Size = new System.Drawing.Size(312, 23);
            this.TxtCusCompany.TabIndex = 9;
            // 
            // TxtCusRepName
            // 
            this.TxtCusRepName.Location = new System.Drawing.Point(160, 63);
            this.TxtCusRepName.Name = "TxtCusRepName";
            this.TxtCusRepName.Size = new System.Drawing.Size(312, 23);
            this.TxtCusRepName.TabIndex = 10;
            // 
            // TxtCusEmail
            // 
            this.TxtCusEmail.Location = new System.Drawing.Point(160, 100);
            this.TxtCusEmail.Name = "TxtCusEmail";
            this.TxtCusEmail.Size = new System.Drawing.Size(312, 23);
            this.TxtCusEmail.TabIndex = 11;
            // 
            // TxtCusTelephone
            // 
            this.TxtCusTelephone.Location = new System.Drawing.Point(160, 137);
            this.TxtCusTelephone.Name = "TxtCusTelephone";
            this.TxtCusTelephone.Size = new System.Drawing.Size(312, 23);
            this.TxtCusTelephone.TabIndex = 12;
            // 
            // TxtCusCellphone
            // 
            this.TxtCusCellphone.Location = new System.Drawing.Point(160, 174);
            this.TxtCusCellphone.Name = "TxtCusCellphone";
            this.TxtCusCellphone.Size = new System.Drawing.Size(312, 23);
            this.TxtCusCellphone.TabIndex = 13;
            // 
            // TxtCusRegistration
            // 
            this.TxtCusRegistration.Location = new System.Drawing.Point(684, 26);
            this.TxtCusRegistration.Name = "TxtCusRegistration";
            this.TxtCusRegistration.Size = new System.Drawing.Size(284, 23);
            this.TxtCusRegistration.TabIndex = 14;
            // 
            // TxtCusPosCode
            // 
            this.TxtCusPosCode.Location = new System.Drawing.Point(684, 174);
            this.TxtCusPosCode.Name = "TxtCusPosCode";
            this.TxtCusPosCode.Size = new System.Drawing.Size(284, 23);
            this.TxtCusPosCode.TabIndex = 15;
            // 
            // TxtCusAddress
            // 
            this.TxtCusAddress.Location = new System.Drawing.Point(684, 106);
            this.TxtCusAddress.Name = "TxtCusAddress";
            this.TxtCusAddress.Size = new System.Drawing.Size(284, 54);
            this.TxtCusAddress.TabIndex = 16;
            this.TxtCusAddress.Text = "";
            // 
            // CusVatNo
            // 
            this.CusVatNo.AutoSize = true;
            this.CusVatNo.Checked = true;
            this.CusVatNo.Location = new System.Drawing.Point(754, 67);
            this.CusVatNo.Name = "CusVatNo";
            this.CusVatNo.Size = new System.Drawing.Size(44, 21);
            this.CusVatNo.TabIndex = 18;
            this.CusVatNo.TabStop = true;
            this.CusVatNo.Text = "No";
            this.CusVatNo.UseVisualStyleBackColor = true;
            // 
            // CusVatYes
            // 
            this.CusVatYes.AutoSize = true;
            this.CusVatYes.Location = new System.Drawing.Point(684, 67);
            this.CusVatYes.Name = "CusVatYes";
            this.CusVatYes.Size = new System.Drawing.Size(50, 21);
            this.CusVatYes.TabIndex = 17;
            this.CusVatYes.Text = "Yes";
            this.CusVatYes.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCustomer
            // 
            this.BtnCancelCustomer.Location = new System.Drawing.Point(513, 263);
            this.BtnCancelCustomer.Name = "BtnCancelCustomer";
            this.BtnCancelCustomer.Size = new System.Drawing.Size(75, 27);
            this.BtnCancelCustomer.TabIndex = 19;
            this.BtnCancelCustomer.Text = "&Cancel";
            this.BtnCancelCustomer.UseVisualStyleBackColor = true;
            this.BtnCancelCustomer.Click += new System.EventHandler(this.BtnCancelCustomer_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Location = new System.Drawing.Point(419, 263);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(75, 27);
            this.BtnAddCustomer.TabIndex = 1;
            this.BtnAddCustomer.Text = "&Add";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(523, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Postal Code:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(523, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Address:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(523, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "VAT Registered:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Registration Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cellphone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Telephone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Rep Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Company:";
            // 
            // invoices
            // 
            this.invoices.BackColor = System.Drawing.Color.DimGray;
            this.invoices.Controls.Add(this.BtnEmailInvoice);
            this.invoices.Controls.Add(this.BtnConvertInvoice);
            this.invoices.Controls.Add(this.groupBox5);
            this.invoices.Controls.Add(this.groupBox4);
            this.invoices.Controls.Add(this.BtnDeleteInvoice);
            this.invoices.Controls.Add(this.BtnViewInvoice);
            this.invoices.Controls.Add(this.BtnEditInvoice);
            this.invoices.Controls.Add(this.BtnNewInvoice);
            this.invoices.Controls.Add(this.InvoiceDGV);
            this.invoices.Location = new System.Drawing.Point(4, 25);
            this.invoices.Name = "invoices";
            this.invoices.Padding = new System.Windows.Forms.Padding(3);
            this.invoices.Size = new System.Drawing.Size(1426, 775);
            this.invoices.TabIndex = 4;
            this.invoices.Text = "Invoices";
            // 
            // BtnConvertInvoice
            // 
            this.BtnConvertInvoice.Location = new System.Drawing.Point(844, 446);
            this.BtnConvertInvoice.Name = "BtnConvertInvoice";
            this.BtnConvertInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnConvertInvoice.TabIndex = 7;
            this.BtnConvertInvoice.Text = "Convert to PDF";
            this.BtnConvertInvoice.UseVisualStyleBackColor = true;
            this.BtnConvertInvoice.Click += new System.EventHandler(this.BtnConvertInvoice_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnHideInItems);
            this.groupBox5.Controls.Add(this.ViewItemsDGV);
            this.groupBox5.Location = new System.Drawing.Point(623, 512);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(779, 246);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Invoice Items";
            this.groupBox5.Visible = false;
            // 
            // BtnHideInItems
            // 
            this.BtnHideInItems.Location = new System.Drawing.Point(353, 213);
            this.BtnHideInItems.Name = "BtnHideInItems";
            this.BtnHideInItems.Size = new System.Drawing.Size(75, 27);
            this.BtnHideInItems.TabIndex = 1;
            this.BtnHideInItems.Text = "Close";
            this.BtnHideInItems.UseVisualStyleBackColor = true;
            this.BtnHideInItems.Click += new System.EventHandler(this.BtnHideInItems_Click);
            // 
            // ViewItemsDGV
            // 
            this.ViewItemsDGV.AllowUserToAddRows = false;
            this.ViewItemsDGV.AllowUserToDeleteRows = false;
            this.ViewItemsDGV.AllowUserToResizeRows = false;
            this.ViewItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewItemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewItemsDGV.Location = new System.Drawing.Point(7, 29);
            this.ViewItemsDGV.Name = "ViewItemsDGV";
            this.ViewItemsDGV.ReadOnly = true;
            this.ViewItemsDGV.RowHeadersVisible = false;
            this.ViewItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewItemsDGV.Size = new System.Drawing.Size(766, 166);
            this.ViewItemsDGV.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCancelUpdate);
            this.groupBox4.Controls.Add(this.BtnUpdateInvoice);
            this.groupBox4.Controls.Add(this.DateInvoicePaidDate);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.LblInvoiceNumber);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.RadInPaidNo);
            this.groupBox4.Controls.Add(this.RadInPaidYes);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Location = new System.Drawing.Point(36, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 220);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Invoice";
            this.groupBox4.Visible = false;
            // 
            // BtnCancelUpdate
            // 
            this.BtnCancelUpdate.Location = new System.Drawing.Point(273, 181);
            this.BtnCancelUpdate.Name = "BtnCancelUpdate";
            this.BtnCancelUpdate.Size = new System.Drawing.Size(75, 27);
            this.BtnCancelUpdate.TabIndex = 8;
            this.BtnCancelUpdate.Text = "Cancel";
            this.BtnCancelUpdate.UseVisualStyleBackColor = true;
            this.BtnCancelUpdate.Click += new System.EventHandler(this.BtnCancelUpdate_Click);
            // 
            // BtnUpdateInvoice
            // 
            this.BtnUpdateInvoice.Enabled = false;
            this.BtnUpdateInvoice.Location = new System.Drawing.Point(182, 181);
            this.BtnUpdateInvoice.Name = "BtnUpdateInvoice";
            this.BtnUpdateInvoice.Size = new System.Drawing.Size(75, 27);
            this.BtnUpdateInvoice.TabIndex = 7;
            this.BtnUpdateInvoice.Text = "Update";
            this.BtnUpdateInvoice.UseVisualStyleBackColor = true;
            this.BtnUpdateInvoice.Click += new System.EventHandler(this.BtnUpdateInvoice_Click);
            // 
            // DateInvoicePaidDate
            // 
            this.DateInvoicePaidDate.Enabled = false;
            this.DateInvoicePaidDate.Location = new System.Drawing.Point(135, 109);
            this.DateInvoicePaidDate.Name = "DateInvoicePaidDate";
            this.DateInvoicePaidDate.Size = new System.Drawing.Size(243, 23);
            this.DateInvoicePaidDate.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 17);
            this.label24.TabIndex = 5;
            this.label24.Text = "Payment Date:";
            // 
            // LblInvoiceNumber
            // 
            this.LblInvoiceNumber.AutoSize = true;
            this.LblInvoiceNumber.Location = new System.Drawing.Point(132, 72);
            this.LblInvoiceNumber.Name = "LblInvoiceNumber";
            this.LblInvoiceNumber.Size = new System.Drawing.Size(54, 17);
            this.LblInvoiceNumber.TabIndex = 4;
            this.LblInvoiceNumber.Text = "label24";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 17);
            this.label23.TabIndex = 3;
            this.label23.Text = "Invoice Number:";
            // 
            // RadInPaidNo
            // 
            this.RadInPaidNo.AutoSize = true;
            this.RadInPaidNo.Checked = true;
            this.RadInPaidNo.Location = new System.Drawing.Point(118, 29);
            this.RadInPaidNo.Name = "RadInPaidNo";
            this.RadInPaidNo.Size = new System.Drawing.Size(44, 21);
            this.RadInPaidNo.TabIndex = 2;
            this.RadInPaidNo.TabStop = true;
            this.RadInPaidNo.Text = "No";
            this.RadInPaidNo.UseVisualStyleBackColor = true;
            // 
            // RadInPaidYes
            // 
            this.RadInPaidYes.AutoSize = true;
            this.RadInPaidYes.Location = new System.Drawing.Point(62, 29);
            this.RadInPaidYes.Name = "RadInPaidYes";
            this.RadInPaidYes.Size = new System.Drawing.Size(50, 21);
            this.RadInPaidYes.TabIndex = 1;
            this.RadInPaidYes.Text = "Yes";
            this.RadInPaidYes.UseVisualStyleBackColor = true;
            this.RadInPaidYes.CheckedChanged += new System.EventHandler(this.RadInPaidYes_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 17);
            this.label22.TabIndex = 0;
            this.label22.Text = "Paid:";
            // 
            // BtnDeleteInvoice
            // 
            this.BtnDeleteInvoice.Location = new System.Drawing.Point(723, 446);
            this.BtnDeleteInvoice.Name = "BtnDeleteInvoice";
            this.BtnDeleteInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnDeleteInvoice.TabIndex = 4;
            this.BtnDeleteInvoice.Text = "Delete";
            this.BtnDeleteInvoice.UseVisualStyleBackColor = true;
            this.BtnDeleteInvoice.Click += new System.EventHandler(this.BtnDeleteInvoice_Click);
            // 
            // BtnViewInvoice
            // 
            this.BtnViewInvoice.Location = new System.Drawing.Point(602, 446);
            this.BtnViewInvoice.Name = "BtnViewInvoice";
            this.BtnViewInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnViewInvoice.TabIndex = 3;
            this.BtnViewInvoice.Text = "View";
            this.BtnViewInvoice.UseVisualStyleBackColor = true;
            this.BtnViewInvoice.Click += new System.EventHandler(this.BtnViewInvoice_Click);
            // 
            // BtnEditInvoice
            // 
            this.BtnEditInvoice.Location = new System.Drawing.Point(481, 446);
            this.BtnEditInvoice.Name = "BtnEditInvoice";
            this.BtnEditInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnEditInvoice.TabIndex = 2;
            this.BtnEditInvoice.Text = "Edit";
            this.BtnEditInvoice.UseVisualStyleBackColor = true;
            this.BtnEditInvoice.Click += new System.EventHandler(this.BtnEditInvoice_Click);
            // 
            // BtnNewInvoice
            // 
            this.BtnNewInvoice.Location = new System.Drawing.Point(360, 446);
            this.BtnNewInvoice.Name = "BtnNewInvoice";
            this.BtnNewInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnNewInvoice.TabIndex = 1;
            this.BtnNewInvoice.Text = "New Invoice";
            this.BtnNewInvoice.UseVisualStyleBackColor = true;
            this.BtnNewInvoice.Click += new System.EventHandler(this.BtnNewInvoice_Click);
            // 
            // InvoiceDGV
            // 
            this.InvoiceDGV.AllowUserToAddRows = false;
            this.InvoiceDGV.AllowUserToDeleteRows = false;
            this.InvoiceDGV.AllowUserToResizeRows = false;
            this.InvoiceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDGV.Location = new System.Drawing.Point(36, 30);
            this.InvoiceDGV.MultiSelect = false;
            this.InvoiceDGV.Name = "InvoiceDGV";
            this.InvoiceDGV.ReadOnly = true;
            this.InvoiceDGV.RowHeadersVisible = false;
            this.InvoiceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceDGV.Size = new System.Drawing.Size(1366, 396);
            this.InvoiceDGV.TabIndex = 0;
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.DimGray;
            this.products.Controls.Add(this.groupBox3);
            this.products.Controls.Add(this.BtnDeleteProduct);
            this.products.Controls.Add(this.BtnEditProduct);
            this.products.Controls.Add(this.ProductDGV);
            this.products.Location = new System.Drawing.Point(4, 25);
            this.products.Name = "products";
            this.products.Padding = new System.Windows.Forms.Padding(3);
            this.products.Size = new System.Drawing.Size(1426, 775);
            this.products.TabIndex = 5;
            this.products.Text = "Products";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtProductID);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.TxtProductDesc);
            this.groupBox3.Controls.Add(this.TxtProductPrice);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.TxtPictureLocation);
            this.groupBox3.Controls.Add(this.BtnCancelProduct);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.BtnAddProduct);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(808, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 583);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // TxtProductID
            // 
            this.TxtProductID.Location = new System.Drawing.Point(176, 12);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(100, 23);
            this.TxtProductID.TabIndex = 19;
            this.TxtProductID.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Description:";
            // 
            // TxtProductDesc
            // 
            this.TxtProductDesc.Location = new System.Drawing.Point(176, 45);
            this.TxtProductDesc.Name = "TxtProductDesc";
            this.TxtProductDesc.Size = new System.Drawing.Size(312, 23);
            this.TxtProductDesc.TabIndex = 10;
            // 
            // TxtProductPrice
            // 
            this.TxtProductPrice.Location = new System.Drawing.Point(176, 91);
            this.TxtProductPrice.Name = "TxtProductPrice";
            this.TxtProductPrice.Size = new System.Drawing.Size(312, 23);
            this.TxtProductPrice.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(176, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 312);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TxtPictureLocation
            // 
            this.TxtPictureLocation.Location = new System.Drawing.Point(176, 137);
            this.TxtPictureLocation.Name = "TxtPictureLocation";
            this.TxtPictureLocation.Size = new System.Drawing.Size(312, 23);
            this.TxtPictureLocation.TabIndex = 12;
            // 
            // BtnCancelProduct
            // 
            this.BtnCancelProduct.Location = new System.Drawing.Point(356, 527);
            this.BtnCancelProduct.Name = "BtnCancelProduct";
            this.BtnCancelProduct.Size = new System.Drawing.Size(75, 27);
            this.BtnCancelProduct.TabIndex = 17;
            this.BtnCancelProduct.Text = "Cancel";
            this.BtnCancelProduct.UseVisualStyleBackColor = true;
            this.BtnCancelProduct.Click += new System.EventHandler(this.BtnCancelProduct_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "Price:";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Location = new System.Drawing.Point(275, 527);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(75, 27);
            this.BtnAddProduct.TabIndex = 16;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 17);
            this.label21.TabIndex = 15;
            this.label21.Text = "Picture Location:";
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Location = new System.Drawing.Point(400, 723);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(75, 27);
            this.BtnDeleteProduct.TabIndex = 20;
            this.BtnDeleteProduct.Text = "Delete";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // BtnEditProduct
            // 
            this.BtnEditProduct.Location = new System.Drawing.Point(303, 723);
            this.BtnEditProduct.Name = "BtnEditProduct";
            this.BtnEditProduct.Size = new System.Drawing.Size(75, 27);
            this.BtnEditProduct.TabIndex = 19;
            this.BtnEditProduct.Text = "Edit";
            this.BtnEditProduct.UseVisualStyleBackColor = true;
            this.BtnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // ProductDGV
            // 
            this.ProductDGV.AllowUserToAddRows = false;
            this.ProductDGV.AllowUserToDeleteRows = false;
            this.ProductDGV.AllowUserToResizeRows = false;
            this.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(36, 30);
            this.ProductDGV.MultiSelect = false;
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.ReadOnly = true;
            this.ProductDGV.RowHeadersVisible = false;
            this.ProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDGV.Size = new System.Drawing.Size(706, 673);
            this.ProductDGV.TabIndex = 9;
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.DimGray;
            this.reports.Controls.Add(this.ReportsChart);
            this.reports.Controls.Add(this.ReportsDGV);
            this.reports.Controls.Add(this.panel1);
            this.reports.Location = new System.Drawing.Point(4, 25);
            this.reports.Name = "reports";
            this.reports.Padding = new System.Windows.Forms.Padding(3);
            this.reports.Size = new System.Drawing.Size(1426, 775);
            this.reports.TabIndex = 6;
            this.reports.Text = "Reports";
            // 
            // ReportsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ReportsChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.ReportsChart.Legends.Add(legend3);
            this.ReportsChart.Location = new System.Drawing.Point(444, 57);
            this.ReportsChart.Name = "ReportsChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ReportsChart.Series.Add(series5);
            this.ReportsChart.Size = new System.Drawing.Size(856, 300);
            this.ReportsChart.TabIndex = 2;
            this.ReportsChart.Text = "chart1";
            this.ReportsChart.Visible = false;
            // 
            // ReportsDGV
            // 
            this.ReportsDGV.AllowUserToAddRows = false;
            this.ReportsDGV.AllowUserToDeleteRows = false;
            this.ReportsDGV.AllowUserToResizeRows = false;
            this.ReportsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsDGV.Location = new System.Drawing.Point(444, 422);
            this.ReportsDGV.Name = "ReportsDGV";
            this.ReportsDGV.ReadOnly = true;
            this.ReportsDGV.RowHeadersVisible = false;
            this.ReportsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportsDGV.Size = new System.Drawing.Size(856, 315);
            this.ReportsDGV.TabIndex = 1;
            this.ReportsDGV.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.TxtReportYear);
            this.panel1.Controls.Add(this.BtnClearReports);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnMonthlyExpenses);
            this.panel1.Controls.Add(this.BtnYearlySales);
            this.panel1.Location = new System.Drawing.Point(35, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 680);
            this.panel1.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 29);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 17);
            this.label25.TabIndex = 5;
            this.label25.Text = "Report Year:";
            // 
            // TxtReportYear
            // 
            this.TxtReportYear.Location = new System.Drawing.Point(31, 48);
            this.TxtReportYear.Name = "TxtReportYear";
            this.TxtReportYear.Size = new System.Drawing.Size(174, 23);
            this.TxtReportYear.TabIndex = 4;
            this.TxtReportYear.Text = "2021";
            // 
            // BtnClearReports
            // 
            this.BtnClearReports.Location = new System.Drawing.Point(31, 229);
            this.BtnClearReports.Name = "BtnClearReports";
            this.BtnClearReports.Size = new System.Drawing.Size(174, 39);
            this.BtnClearReports.TabIndex = 3;
            this.BtnClearReports.Text = "Clear Reports";
            this.BtnClearReports.UseVisualStyleBackColor = true;
            this.BtnClearReports.Click += new System.EventHandler(this.BtnClearReports_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // BtnMonthlyExpenses
            // 
            this.BtnMonthlyExpenses.Location = new System.Drawing.Point(31, 139);
            this.BtnMonthlyExpenses.Name = "BtnMonthlyExpenses";
            this.BtnMonthlyExpenses.Size = new System.Drawing.Size(174, 39);
            this.BtnMonthlyExpenses.TabIndex = 1;
            this.BtnMonthlyExpenses.Text = "Monthly Purchases";
            this.BtnMonthlyExpenses.UseVisualStyleBackColor = true;
            this.BtnMonthlyExpenses.Click += new System.EventHandler(this.BtnMonthlyExpenses_Click);
            // 
            // BtnYearlySales
            // 
            this.BtnYearlySales.Location = new System.Drawing.Point(31, 94);
            this.BtnYearlySales.Name = "BtnYearlySales";
            this.BtnYearlySales.Size = new System.Drawing.Size(174, 39);
            this.BtnYearlySales.TabIndex = 0;
            this.BtnYearlySales.Text = "Monthly Sales";
            this.BtnYearlySales.UseVisualStyleBackColor = true;
            this.BtnYearlySales.Click += new System.EventHandler(this.BtnYearlySales_Click);
            // 
            // system
            // 
            this.system.BackColor = System.Drawing.Color.DimGray;
            this.system.Controls.Add(this.groupBox6);
            this.system.Location = new System.Drawing.Point(4, 25);
            this.system.Name = "system";
            this.system.Padding = new System.Windows.Forms.Padding(3);
            this.system.Size = new System.Drawing.Size(1426, 775);
            this.system.TabIndex = 7;
            this.system.Text = "System";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnRestore);
            this.groupBox6.Controls.Add(this.BtnBackup);
            this.groupBox6.Location = new System.Drawing.Point(34, 46);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(297, 222);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Database Maintenance";
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(28, 156);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(75, 27);
            this.BtnRestore.TabIndex = 1;
            this.BtnRestore.Text = "Restore";
            this.BtnRestore.UseVisualStyleBackColor = true;
            // 
            // BtnBackup
            // 
            this.BtnBackup.Location = new System.Drawing.Point(28, 46);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(75, 27);
            this.BtnBackup.TabIndex = 0;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(1372, 9);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(75, 23);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnEmailInvoice
            // 
            this.BtnEmailInvoice.Location = new System.Drawing.Point(965, 446);
            this.BtnEmailInvoice.Name = "BtnEmailInvoice";
            this.BtnEmailInvoice.Size = new System.Drawing.Size(115, 27);
            this.BtnEmailInvoice.TabIndex = 8;
            this.BtnEmailInvoice.Text = "Email";
            this.BtnEmailInvoice.UseVisualStyleBackColor = true;
            this.BtnEmailInvoice.Click += new System.EventHandler(this.BtnEmailInvoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1459, 829);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altered EMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CRTYearlySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRTSalesVsExpenses)).EndInit();
            this.supplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            this.customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.invoices.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewItemsDGV)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDGV)).EndInit();
            this.products.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.system.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage supplier;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCancelSupplier;
        private System.Windows.Forms.Button BtnAddSupplier;
        private System.Windows.Forms.Button BtnDeleteSupplier;
        private System.Windows.Forms.Button BtnEditSupplier;
        private System.Windows.Forms.DataGridView SupplierDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SupVatNo;
        private System.Windows.Forms.RadioButton SupVatYes;
        private System.Windows.Forms.TextBox TxtSupPostCode;
        private System.Windows.Forms.RichTextBox TxtSupAddress;
        private System.Windows.Forms.TextBox TxtSupRegistration;
        private System.Windows.Forms.TextBox TxtSupCellphone;
        private System.Windows.Forms.TextBox TxtSupTelephone;
        private System.Windows.Forms.TextBox TxtSupEmail;
        private System.Windows.Forms.TextBox TxtSupRepName;
        private System.Windows.Forms.TextBox TxtSupCompany;
        private System.Windows.Forms.Button BtnEditOrder;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Button BtnViewOrder;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCancelCustomer;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton CusVatNo;
        private System.Windows.Forms.RadioButton CusVatYes;
        private System.Windows.Forms.RichTextBox TxtCusAddress;
        private System.Windows.Forms.TextBox TxtCusPosCode;
        private System.Windows.Forms.TextBox TxtCusRegistration;
        private System.Windows.Forms.TextBox TxtCusCellphone;
        private System.Windows.Forms.TextBox TxtCusTelephone;
        private System.Windows.Forms.TextBox TxtCusEmail;
        private System.Windows.Forms.TextBox TxtCusRepName;
        private System.Windows.Forms.TextBox TxtCusCompany;
        private System.Windows.Forms.Button BtnDeleteCustomer;
        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.Button BtnEditCustomer;
        private System.Windows.Forms.TabPage invoices;
        private System.Windows.Forms.DataGridView InvoiceDGV;
        private System.Windows.Forms.Button BtnDeleteInvoice;
        private System.Windows.Forms.Button BtnViewInvoice;
        private System.Windows.Forms.Button BtnEditInvoice;
        private System.Windows.Forms.Button BtnNewInvoice;
        private System.Windows.Forms.TabPage products;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtProductDesc;
        private System.Windows.Forms.TextBox TxtProductPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPictureLocation;
        private System.Windows.Forms.Button BtnCancelProduct;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.Button BtnEditProduct;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnCancelUpdate;
        private System.Windows.Forms.Button BtnUpdateInvoice;
        private System.Windows.Forms.DateTimePicker DateInvoicePaidDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label LblInvoiceNumber;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton RadInPaidNo;
        private System.Windows.Forms.RadioButton RadInPaidYes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnHideInItems;
        private System.Windows.Forms.DataGridView ViewItemsDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart CRTSalesVsExpenses;
        private System.Windows.Forms.TabPage reports;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReportsChart;
        private System.Windows.Forms.DataGridView ReportsDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClearReports;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnMonthlyExpenses;
        private System.Windows.Forms.Button BtnYearlySales;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TxtReportYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart CRTYearlySales;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.TabPage system;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button BtnConvertInvoice;
        private System.Windows.Forms.Button BtnEmailInvoice;
    }
}

