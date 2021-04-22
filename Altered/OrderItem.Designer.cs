namespace Altered
{
    partial class OrderItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VatExcluded = new System.Windows.Forms.RadioButton();
            this.VatIncluded = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(151, 77);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(437, 20);
            this.TxtDescription.TabIndex = 1;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(151, 113);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtPrice.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(324, 176);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 27);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(151, 146);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(120, 20);
            this.TxtQuantity.TabIndex = 3;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(243, 176);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 27);
            this.BtnConfirm.TabIndex = 4;
            this.BtnConfirm.Text = "Add";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VatExcluded);
            this.groupBox1.Controls.Add(this.VatIncluded);
            this.groupBox1.Location = new System.Drawing.Point(50, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VAT";
            // 
            // VatExcluded
            // 
            this.VatExcluded.AutoSize = true;
            this.VatExcluded.Location = new System.Drawing.Point(107, 17);
            this.VatExcluded.Name = "VatExcluded";
            this.VatExcluded.Size = new System.Drawing.Size(69, 17);
            this.VatExcluded.TabIndex = 1;
            this.VatExcluded.TabStop = true;
            this.VatExcluded.Text = "Excluded";
            this.VatExcluded.UseVisualStyleBackColor = true;
            // 
            // VatIncluded
            // 
            this.VatIncluded.AutoSize = true;
            this.VatIncluded.Location = new System.Drawing.Point(22, 17);
            this.VatIncluded.Name = "VatIncluded";
            this.VatIncluded.Size = new System.Drawing.Size(66, 17);
            this.VatIncluded.TabIndex = 0;
            this.VatIncluded.TabStop = true;
            this.VatIncluded.Text = "Included";
            this.VatIncluded.UseVisualStyleBackColor = true;
            // 
            // OrderItem
            // 
            this.AcceptButton = this.BtnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(641, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.NumericUpDown TxtQuantity;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton VatExcluded;
        private System.Windows.Forms.RadioButton VatIncluded;
    }
}