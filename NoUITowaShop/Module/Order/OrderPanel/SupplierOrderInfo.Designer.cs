
namespace NoUITowaShop.Module.Order.OrderPanel
{
    partial class SupplierOrderInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSupplierOrder = new System.Windows.Forms.GroupBox();
            this.tbpGB = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdvancedSearch = new System.Windows.Forms.Button();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbSupplierListName = new System.Windows.Forms.ComboBox();
            this.gbSupplierOrder.SuspendLayout();
            this.tbpGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSupplierOrder
            // 
            this.gbSupplierOrder.Controls.Add(this.tbpGB);
            this.gbSupplierOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSupplierOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplierOrder.Location = new System.Drawing.Point(0, 0);
            this.gbSupplierOrder.Name = "gbSupplierOrder";
            this.gbSupplierOrder.Size = new System.Drawing.Size(343, 110);
            this.gbSupplierOrder.TabIndex = 1;
            this.gbSupplierOrder.TabStop = false;
            this.gbSupplierOrder.Text = "Supplier Info";
            // 
            // tbpGB
            // 
            this.tbpGB.ColumnCount = 3;
            this.tbpGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbpGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbpGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tbpGB.Controls.Add(this.btnAdvancedSearch, 2, 0);
            this.tbpGB.Controls.Add(this.lbCustomerPhone, 0, 1);
            this.tbpGB.Controls.Add(this.lbName, 0, 0);
            this.tbpGB.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tbpGB.Controls.Add(this.cbSupplierListName, 1, 0);
            this.tbpGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpGB.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpGB.Location = new System.Drawing.Point(3, 26);
            this.tbpGB.Name = "tbpGB";
            this.tbpGB.RowCount = 2;
            this.tbpGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpGB.Size = new System.Drawing.Size(337, 81);
            this.tbpGB.TabIndex = 0;
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvancedSearch.BackColor = System.Drawing.Color.Coral;
            this.btnAdvancedSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(288, 3);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(46, 34);
            this.btnAdvancedSearch.TabIndex = 1;
            this.btnAdvancedSearch.Text = "?";
            this.btnAdvancedSearch.UseVisualStyleBackColor = false;
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.lbCustomerPhone.Location = new System.Drawing.Point(3, 40);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(79, 41);
            this.lbCustomerPhone.TabIndex = 0;
            this.lbCustomerPhone.Text = "Phone";
            this.lbCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F);
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 40);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(88, 43);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(194, 30);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // cbSupplierListName
            // 
            this.cbSupplierListName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSupplierListName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierListName.FormattingEnabled = true;
            this.cbSupplierListName.Location = new System.Drawing.Point(88, 3);
            this.cbSupplierListName.Name = "cbSupplierListName";
            this.cbSupplierListName.Size = new System.Drawing.Size(194, 32);
            this.cbSupplierListName.TabIndex = 2;
            // 
            // SupplierOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSupplierOrder);
            this.Name = "SupplierOrderInfo";
            this.Size = new System.Drawing.Size(343, 110);
            this.gbSupplierOrder.ResumeLayout(false);
            this.tbpGB.ResumeLayout(false);
            this.tbpGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSupplierOrder;
        private System.Windows.Forms.TableLayoutPanel tbpGB;
        private System.Windows.Forms.Button btnAdvancedSearch;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cbSupplierListName;
    }
}
