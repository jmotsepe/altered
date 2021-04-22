namespace Altered
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.CmbItem = new System.Windows.Forms.ComboBox();
            this.tblProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alteredDataSet1 = new Altered.alteredDataSet1();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblProductsTableAdapter = new Altered.alteredDataSet1TableAdapters.tblProductsTableAdapter();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbItem
            // 
            this.CmbItem.DataSource = this.tblProductsBindingSource;
            this.CmbItem.DisplayMember = "description";
            this.CmbItem.FormattingEnabled = true;
            this.CmbItem.Location = new System.Drawing.Point(149, 33);
            this.CmbItem.Name = "CmbItem";
            this.CmbItem.Size = new System.Drawing.Size(474, 21);
            this.CmbItem.TabIndex = 0;
            this.CmbItem.ValueMember = "productID";
            this.CmbItem.SelectedIndexChanged += new System.EventHandler(this.CmbItem_SelectedIndexChanged);
            // 
            // tblProductsBindingSource
            // 
            this.tblProductsBindingSource.DataMember = "tblProducts";
            this.tblProductsBindingSource.DataSource = this.alteredDataSet1;
            // 
            // alteredDataSet1
            // 
            this.alteredDataSet1.DataSetName = "alteredDataSet1";
            this.alteredDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(149, 74);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtPrice.TabIndex = 1;
            this.TxtPrice.TabStop = false;
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(149, 111);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(100, 20);
            this.NumQuantity.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(256, 200);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 27);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(363, 200);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 27);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // tblProductsTableAdapter
            // 
            this.tblProductsTableAdapter.ClearBeforeFill = true;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(278, 73);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(345, 20);
            this.TxtDescription.TabIndex = 8;
            this.TxtDescription.Visible = false;
            // 
            // AddItem
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(684, 248);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.CmbItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alteredDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbItem;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.NumericUpDown NumQuantity;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private alteredDataSet1 alteredDataSet1;
        private System.Windows.Forms.BindingSource tblProductsBindingSource;
        private alteredDataSet1TableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.TextBox TxtDescription;
    }
}