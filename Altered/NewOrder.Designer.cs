namespace Altered
{
    partial class NewOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOrderNumber = new System.Windows.Forms.TextBox();
            this.TxtOrderDate = new System.Windows.Forms.TextBox();
            this.CmbSupplier = new System.Windows.Forms.ComboBox();
            this.tblSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alteredDataSet = new Altered.alteredDataSet();
            this.tblSupplierTableAdapter = new Altered.alteredDataSetTableAdapters.tblSupplierTableAdapter();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalExcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIncl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VatExcluded = new System.Windows.Forms.RadioButton();
            this.VatIncluded = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOrderTotal = new System.Windows.Forms.TextBox();
            this.TxtVat = new System.Windows.Forms.TextBox();
            this.TxtTotalExcl = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.RadPaidNo = new System.Windows.Forms.RadioButton();
            this.RadPaidYes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier:";
            // 
            // TxtOrderNumber
            // 
            this.TxtOrderNumber.Location = new System.Drawing.Point(161, 38);
            this.TxtOrderNumber.Name = "TxtOrderNumber";
            this.TxtOrderNumber.ReadOnly = true;
            this.TxtOrderNumber.Size = new System.Drawing.Size(135, 20);
            this.TxtOrderNumber.TabIndex = 3;
            this.TxtOrderNumber.TabStop = false;
            // 
            // TxtOrderDate
            // 
            this.TxtOrderDate.Location = new System.Drawing.Point(161, 68);
            this.TxtOrderDate.Name = "TxtOrderDate";
            this.TxtOrderDate.ReadOnly = true;
            this.TxtOrderDate.Size = new System.Drawing.Size(135, 20);
            this.TxtOrderDate.TabIndex = 4;
            this.TxtOrderDate.TabStop = false;
            // 
            // CmbSupplier
            // 
            this.CmbSupplier.DataSource = this.tblSupplierBindingSource;
            this.CmbSupplier.DisplayMember = "company";
            this.CmbSupplier.FormattingEnabled = true;
            this.CmbSupplier.Location = new System.Drawing.Point(161, 99);
            this.CmbSupplier.Name = "CmbSupplier";
            this.CmbSupplier.Size = new System.Drawing.Size(135, 21);
            this.CmbSupplier.TabIndex = 1;
            this.CmbSupplier.ValueMember = "supplierID";
            // 
            // tblSupplierBindingSource
            // 
            this.tblSupplierBindingSource.DataMember = "tblSupplier";
            this.tblSupplierBindingSource.DataSource = this.alteredDataSet;
            // 
            // alteredDataSet
            // 
            this.alteredDataSet.DataSetName = "alteredDataSet";
            this.alteredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSupplierTableAdapter
            // 
            this.tblSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // ItemDGV
            // 
            this.ItemDGV.AllowUserToAddRows = false;
            this.ItemDGV.AllowUserToDeleteRows = false;
            this.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.description,
            this.price,
            this.totalExcl,
            this.totalIncl});
            this.ItemDGV.Location = new System.Drawing.Point(41, 163);
            this.ItemDGV.MultiSelect = false;
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.RowHeadersVisible = false;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(697, 150);
            this.ItemDGV.TabIndex = 6;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // totalExcl
            // 
            this.totalExcl.HeaderText = "Total Excl";
            this.totalExcl.Name = "totalExcl";
            // 
            // totalIncl
            // 
            this.totalIncl.HeaderText = "Total Incl";
            this.totalIncl.Name = "totalIncl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VatExcluded);
            this.groupBox1.Controls.Add(this.VatIncluded);
            this.groupBox1.Location = new System.Drawing.Point(621, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VAT";
            // 
            // VatExcluded
            // 
            this.VatExcluded.AutoSize = true;
            this.VatExcluded.Location = new System.Drawing.Point(16, 42);
            this.VatExcluded.Name = "VatExcluded";
            this.VatExcluded.Size = new System.Drawing.Size(69, 17);
            this.VatExcluded.TabIndex = 7;
            this.VatExcluded.TabStop = true;
            this.VatExcluded.Text = "Excluded";
            this.VatExcluded.UseVisualStyleBackColor = true;
            // 
            // VatIncluded
            // 
            this.VatIncluded.AutoSize = true;
            this.VatIncluded.Location = new System.Drawing.Point(16, 19);
            this.VatIncluded.Name = "VatIncluded";
            this.VatIncluded.Size = new System.Drawing.Size(66, 17);
            this.VatIncluded.TabIndex = 6;
            this.VatIncluded.TabStop = true;
            this.VatIncluded.Text = "Included";
            this.VatIncluded.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT 15%:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Excl:";
            // 
            // TxtOrderTotal
            // 
            this.TxtOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrderTotal.Location = new System.Drawing.Point(621, 405);
            this.TxtOrderTotal.Name = "TxtOrderTotal";
            this.TxtOrderTotal.ReadOnly = true;
            this.TxtOrderTotal.Size = new System.Drawing.Size(117, 23);
            this.TxtOrderTotal.TabIndex = 11;
            this.TxtOrderTotal.TabStop = false;
            // 
            // TxtVat
            // 
            this.TxtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVat.Location = new System.Drawing.Point(621, 375);
            this.TxtVat.Name = "TxtVat";
            this.TxtVat.ReadOnly = true;
            this.TxtVat.Size = new System.Drawing.Size(117, 20);
            this.TxtVat.TabIndex = 12;
            this.TxtVat.TabStop = false;
            // 
            // TxtTotalExcl
            // 
            this.TxtTotalExcl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalExcl.Location = new System.Drawing.Point(621, 345);
            this.TxtTotalExcl.Name = "TxtTotalExcl";
            this.TxtTotalExcl.ReadOnly = true;
            this.TxtTotalExcl.Size = new System.Drawing.Size(117, 20);
            this.TxtTotalExcl.TabIndex = 13;
            this.TxtTotalExcl.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(41, 342);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(122, 342);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(203, 342);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Enabled = false;
            this.BtnSubmit.Location = new System.Drawing.Point(122, 411);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(156, 23);
            this.BtnSubmit.TabIndex = 12;
            this.BtnSubmit.Text = "Place Order";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(41, 411);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtInvoiceNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DateInvoiceDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RadPaidNo);
            this.groupBox2.Controls.Add(this.RadPaidYes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(302, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 119);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Paid";
            // 
            // TxtInvoiceNumber
            // 
            this.TxtInvoiceNumber.Enabled = false;
            this.TxtInvoiceNumber.Location = new System.Drawing.Point(66, 46);
            this.TxtInvoiceNumber.Name = "TxtInvoiceNumber";
            this.TxtInvoiceNumber.Size = new System.Drawing.Size(222, 23);
            this.TxtInvoiceNumber.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date:";
            // 
            // DateInvoiceDate
            // 
            this.DateInvoiceDate.Enabled = false;
            this.DateInvoiceDate.Location = new System.Drawing.Point(66, 81);
            this.DateInvoiceDate.Name = "DateInvoiceDate";
            this.DateInvoiceDate.Size = new System.Drawing.Size(222, 23);
            this.DateInvoiceDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Invoice:";
            // 
            // RadPaidNo
            // 
            this.RadPaidNo.AutoSize = true;
            this.RadPaidNo.Checked = true;
            this.RadPaidNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadPaidNo.Location = new System.Drawing.Point(76, 20);
            this.RadPaidNo.Name = "RadPaidNo";
            this.RadPaidNo.Size = new System.Drawing.Size(41, 19);
            this.RadPaidNo.TabIndex = 3;
            this.RadPaidNo.TabStop = true;
            this.RadPaidNo.Text = "No";
            this.RadPaidNo.UseVisualStyleBackColor = true;
            // 
            // RadPaidYes
            // 
            this.RadPaidYes.AutoSize = true;
            this.RadPaidYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadPaidYes.Location = new System.Drawing.Point(7, 20);
            this.RadPaidYes.Name = "RadPaidYes";
            this.RadPaidYes.Size = new System.Drawing.Size(45, 19);
            this.RadPaidYes.TabIndex = 2;
            this.RadPaidYes.Text = "Yes";
            this.RadPaidYes.UseVisualStyleBackColor = true;
            this.RadPaidYes.CheckedChanged += new System.EventHandler(this.RadPaidYes_CheckedChanged);
            // 
            // NewOrder
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtTotalExcl);
            this.Controls.Add(this.TxtVat);
            this.Controls.Add(this.TxtOrderTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ItemDGV);
            this.Controls.Add(this.CmbSupplier);
            this.Controls.Add(this.TxtOrderDate);
            this.Controls.Add(this.TxtOrderNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order: ";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOrderNumber;
        private System.Windows.Forms.TextBox TxtOrderDate;
        private System.Windows.Forms.ComboBox CmbSupplier;
        private alteredDataSet alteredDataSet;
        private System.Windows.Forms.BindingSource tblSupplierBindingSource;
        private alteredDataSetTableAdapters.tblSupplierTableAdapter tblSupplierTableAdapter;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalExcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIncl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VatExcluded;
        private System.Windows.Forms.RadioButton VatIncluded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOrderTotal;
        private System.Windows.Forms.TextBox TxtVat;
        private System.Windows.Forms.TextBox TxtTotalExcl;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtInvoiceNumber;
        private System.Windows.Forms.DateTimePicker DateInvoiceDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RadPaidYes;
        private System.Windows.Forms.RadioButton RadPaidNo;
    }
}