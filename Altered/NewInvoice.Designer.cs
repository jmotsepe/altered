namespace Altered
{
    partial class NewInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadPaidNo = new System.Windows.Forms.RadioButton();
            this.RadPaidYes = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadVatYes = new System.Windows.Forms.RadioButton();
            this.RadVatNo = new System.Windows.Forms.RadioButton();
            this.LblInvoiceNumber = new System.Windows.Forms.Label();
            this.LblInvoiceDate = new System.Windows.Forms.Label();
            this.CmbCustomerID = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alteredDataSet = new Altered.alteredDataSet();
            this.ItemDGV = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTotalEx = new System.Windows.Forms.Label();
            this.LblVat = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tblCustomerTableAdapter = new Altered.alteredDataSetTableAdapters.tblCustomerTableAdapter();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadPaidNo);
            this.groupBox1.Controls.Add(this.RadPaidYes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(340, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paid";
            // 
            // RadPaidNo
            // 
            this.RadPaidNo.AutoSize = true;
            this.RadPaidNo.Checked = true;
            this.RadPaidNo.Location = new System.Drawing.Point(25, 56);
            this.RadPaidNo.Name = "RadPaidNo";
            this.RadPaidNo.Size = new System.Drawing.Size(44, 21);
            this.RadPaidNo.TabIndex = 1;
            this.RadPaidNo.TabStop = true;
            this.RadPaidNo.Text = "No";
            this.RadPaidNo.UseVisualStyleBackColor = true;
            // 
            // RadPaidYes
            // 
            this.RadPaidYes.AutoSize = true;
            this.RadPaidYes.Location = new System.Drawing.Point(25, 28);
            this.RadPaidYes.Name = "RadPaidYes";
            this.RadPaidYes.Size = new System.Drawing.Size(50, 21);
            this.RadPaidYes.TabIndex = 0;
            this.RadPaidYes.Text = "Yes";
            this.RadPaidYes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadVatYes);
            this.groupBox2.Controls.Add(this.RadVatNo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(561, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 91);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VAT";
            // 
            // RadVatYes
            // 
            this.RadVatYes.AutoSize = true;
            this.RadVatYes.Location = new System.Drawing.Point(15, 22);
            this.RadVatYes.Name = "RadVatYes";
            this.RadVatYes.Size = new System.Drawing.Size(95, 21);
            this.RadVatYes.TabIndex = 1;
            this.RadVatYes.Text = "Registered";
            this.RadVatYes.UseVisualStyleBackColor = true;
            // 
            // RadVatNo
            // 
            this.RadVatNo.AutoSize = true;
            this.RadVatNo.Checked = true;
            this.RadVatNo.Location = new System.Drawing.Point(15, 49);
            this.RadVatNo.Name = "RadVatNo";
            this.RadVatNo.Size = new System.Drawing.Size(122, 21);
            this.RadVatNo.TabIndex = 0;
            this.RadVatNo.TabStop = true;
            this.RadVatNo.Text = "Not-Registered";
            this.RadVatNo.UseVisualStyleBackColor = true;
            // 
            // LblInvoiceNumber
            // 
            this.LblInvoiceNumber.AutoSize = true;
            this.LblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceNumber.Location = new System.Drawing.Point(156, 30);
            this.LblInvoiceNumber.Name = "LblInvoiceNumber";
            this.LblInvoiceNumber.Size = new System.Drawing.Size(90, 17);
            this.LblInvoiceNumber.TabIndex = 5;
            this.LblInvoiceNumber.Text = "Invoice Date:";
            // 
            // LblInvoiceDate
            // 
            this.LblInvoiceDate.AutoSize = true;
            this.LblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceDate.Location = new System.Drawing.Point(303, 314);
            this.LblInvoiceDate.Name = "LblInvoiceDate";
            this.LblInvoiceDate.Size = new System.Drawing.Size(90, 17);
            this.LblInvoiceDate.TabIndex = 6;
            this.LblInvoiceDate.Text = "Invoice Date:";
            this.LblInvoiceDate.Visible = false;
            // 
            // CmbCustomerID
            // 
            this.CmbCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustomerID.DataSource = this.tblCustomerBindingSource;
            this.CmbCustomerID.DisplayMember = "rep_name";
            this.CmbCustomerID.FormattingEnabled = true;
            this.CmbCustomerID.Location = new System.Drawing.Point(159, 83);
            this.CmbCustomerID.Name = "CmbCustomerID";
            this.CmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.CmbCustomerID.TabIndex = 7;
            this.CmbCustomerID.ValueMember = "customerID";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.alteredDataSet;
            // 
            // alteredDataSet
            // 
            this.alteredDataSet.DataSetName = "alteredDataSet";
            this.alteredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemDGV
            // 
            this.ItemDGV.AllowUserToAddRows = false;
            this.ItemDGV.AllowUserToDeleteRows = false;
            this.ItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.quantity,
            this.description,
            this.price,
            this.total});
            this.ItemDGV.Location = new System.Drawing.Point(26, 137);
            this.ItemDGV.Name = "ItemDGV";
            this.ItemDGV.ReadOnly = true;
            this.ItemDGV.RowHeadersVisible = false;
            this.ItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDGV.Size = new System.Drawing.Size(744, 150);
            this.ItemDGV.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(26, 314);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(107, 314);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(188, 314);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(26, 359);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.Location = new System.Drawing.Point(107, 359);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(156, 23);
            this.BtnConfirm.TabIndex = 13;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Excl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "15% VAT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // LblTotalEx
            // 
            this.LblTotalEx.AutoSize = true;
            this.LblTotalEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalEx.Location = new System.Drawing.Point(637, 304);
            this.LblTotalEx.Name = "LblTotalEx";
            this.LblTotalEx.Size = new System.Drawing.Size(44, 17);
            this.LblTotalEx.TabIndex = 17;
            this.LblTotalEx.Text = "Total:";
            // 
            // LblVat
            // 
            this.LblVat.AutoSize = true;
            this.LblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVat.Location = new System.Drawing.Point(637, 342);
            this.LblVat.Name = "LblVat";
            this.LblVat.Size = new System.Drawing.Size(44, 17);
            this.LblVat.TabIndex = 18;
            this.LblVat.Text = "Total:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(637, 380);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 17);
            this.LblTotal.TabIndex = 19;
            this.LblTotal.Text = "Total:";
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // itemID
            // 
            this.itemID.HeaderText = "itemID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Visible = false;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 50F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // description
            // 
            this.description.FillWeight = 300F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 80F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 80F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // DateInvoiceDate
            // 
            this.DateInvoiceDate.Location = new System.Drawing.Point(159, 54);
            this.DateInvoiceDate.Name = "DateInvoiceDate";
            this.DateInvoiceDate.Size = new System.Drawing.Size(175, 20);
            this.DateInvoiceDate.TabIndex = 20;
            // 
            // NewInvoice
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateInvoiceDate);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblVat);
            this.Controls.Add(this.LblTotalEx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ItemDGV);
            this.Controls.Add(this.CmbCustomerID);
            this.Controls.Add(this.LblInvoiceDate);
            this.Controls.Add(this.LblInvoiceNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "NewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadPaidNo;
        private System.Windows.Forms.RadioButton RadPaidYes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadVatYes;
        private System.Windows.Forms.RadioButton RadVatNo;
        private System.Windows.Forms.Label LblInvoiceNumber;
        private System.Windows.Forms.Label LblInvoiceDate;
        private System.Windows.Forms.ComboBox CmbCustomerID;
        private System.Windows.Forms.DataGridView ItemDGV;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTotalEx;
        private System.Windows.Forms.Label LblVat;
        private System.Windows.Forms.Label LblTotal;
        private alteredDataSet alteredDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private alteredDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DateTimePicker DateInvoiceDate;
    }
}