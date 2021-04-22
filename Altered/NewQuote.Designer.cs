
namespace Altered
{
    partial class NewQuote
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
            this.DateQuoteDate = new System.Windows.Forms.DateTimePicker();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblVat = new System.Windows.Forms.Label();
            this.LblTotalEx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.QuoteItemDGV = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbCustomerID = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alteredDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alteredDataSet = new Altered.alteredDataSet();
            this.LblQuoteDate = new System.Windows.Forms.Label();
            this.LblQuoteNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadVatYes = new System.Windows.Forms.RadioButton();
            this.RadVatNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alteredDataSet1 = new Altered.alteredDataSet1();
            this.alteredDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new Altered.alteredDataSetTableAdapters.tblCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuoteItemDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DateQuoteDate
            // 
            this.DateQuoteDate.Location = new System.Drawing.Point(306, 340);
            this.DateQuoteDate.Name = "DateQuoteDate";
            this.DateQuoteDate.Size = new System.Drawing.Size(175, 20);
            this.DateQuoteDate.TabIndex = 41;
            this.DateQuoteDate.Visible = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(637, 378);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 17);
            this.LblTotal.TabIndex = 40;
            this.LblTotal.Text = "Total:";
            // 
            // LblVat
            // 
            this.LblVat.AutoSize = true;
            this.LblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVat.Location = new System.Drawing.Point(637, 340);
            this.LblVat.Name = "LblVat";
            this.LblVat.Size = new System.Drawing.Size(44, 17);
            this.LblVat.TabIndex = 39;
            this.LblVat.Text = "Total:";
            // 
            // LblTotalEx
            // 
            this.LblTotalEx.AutoSize = true;
            this.LblTotalEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalEx.Location = new System.Drawing.Point(637, 302);
            this.LblTotalEx.Name = "LblTotalEx";
            this.LblTotalEx.Size = new System.Drawing.Size(44, 17);
            this.LblTotalEx.TabIndex = 38;
            this.LblTotalEx.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "15% VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total Excl:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.Location = new System.Drawing.Point(107, 357);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(156, 23);
            this.BtnConfirm.TabIndex = 34;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(26, 357);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(188, 312);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 32;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Location = new System.Drawing.Point(107, 312);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 31;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(26, 312);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 30;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // QuoteItemDGV
            // 
            this.QuoteItemDGV.AllowUserToAddRows = false;
            this.QuoteItemDGV.AllowUserToDeleteRows = false;
            this.QuoteItemDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuoteItemDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuoteItemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuoteItemDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.quantity,
            this.description,
            this.price,
            this.total});
            this.QuoteItemDGV.Location = new System.Drawing.Point(26, 135);
            this.QuoteItemDGV.Name = "QuoteItemDGV";
            this.QuoteItemDGV.ReadOnly = true;
            this.QuoteItemDGV.RowHeadersVisible = false;
            this.QuoteItemDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuoteItemDGV.Size = new System.Drawing.Size(744, 150);
            this.QuoteItemDGV.TabIndex = 29;
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
            // CmbCustomerID
            // 
            this.CmbCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCustomerID.DataSource = this.tblCustomerBindingSource;
            this.CmbCustomerID.DisplayMember = "rep_name";
            this.CmbCustomerID.FormattingEnabled = true;
            this.CmbCustomerID.Location = new System.Drawing.Point(159, 81);
            this.CmbCustomerID.Name = "CmbCustomerID";
            this.CmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.CmbCustomerID.TabIndex = 28;
            this.CmbCustomerID.ValueMember = "customerID";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.alteredDataSetBindingSource;
            // 
            // alteredDataSetBindingSource
            // 
            this.alteredDataSetBindingSource.DataSource = this.alteredDataSet;
            this.alteredDataSetBindingSource.Position = 0;
            // 
            // alteredDataSet
            // 
            this.alteredDataSet.DataSetName = "alteredDataSet";
            this.alteredDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LblQuoteDate
            // 
            this.LblQuoteDate.AutoSize = true;
            this.LblQuoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuoteDate.Location = new System.Drawing.Point(156, 55);
            this.LblQuoteDate.Name = "LblQuoteDate";
            this.LblQuoteDate.Size = new System.Drawing.Size(90, 17);
            this.LblQuoteDate.TabIndex = 27;
            this.LblQuoteDate.Text = "Invoice Date:";
            // 
            // LblQuoteNumber
            // 
            this.LblQuoteNumber.AutoSize = true;
            this.LblQuoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuoteNumber.Location = new System.Drawing.Point(156, 28);
            this.LblQuoteNumber.Name = "LblQuoteNumber";
            this.LblQuoteNumber.Size = new System.Drawing.Size(103, 17);
            this.LblQuoteNumber.TabIndex = 26;
            this.LblQuoteNumber.Text = "Quote number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadVatYes);
            this.groupBox2.Controls.Add(this.RadVatNo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(561, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 91);
            this.groupBox2.TabIndex = 25;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quote Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quote Number:";
            // 
            // alteredDataSet1
            // 
            this.alteredDataSet1.DataSetName = "alteredDataSet1";
            this.alteredDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alteredDataSet1BindingSource
            // 
            this.alteredDataSet1BindingSource.DataSource = this.alteredDataSet1;
            this.alteredDataSet1BindingSource.Position = 0;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // NewQuote
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(810, 449);
            this.Controls.Add(this.DateQuoteDate);
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
            this.Controls.Add(this.QuoteItemDGV);
            this.Controls.Add(this.CmbCustomerID);
            this.Controls.Add(this.LblQuoteDate);
            this.Controls.Add(this.LblQuoteNumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(826, 488);
            this.MinimumSize = new System.Drawing.Size(826, 488);
            this.Name = "NewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewQuote";
            this.Load += new System.EventHandler(this.NewQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuoteItemDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateQuoteDate;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblVat;
        private System.Windows.Forms.Label LblTotalEx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView QuoteItemDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox CmbCustomerID;
        private System.Windows.Forms.Label LblQuoteDate;
        private System.Windows.Forms.Label LblQuoteNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadVatYes;
        private System.Windows.Forms.RadioButton RadVatNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource alteredDataSetBindingSource;
        private alteredDataSet alteredDataSet;
        private alteredDataSet1 alteredDataSet1;
        private System.Windows.Forms.BindingSource alteredDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private alteredDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
    }
}