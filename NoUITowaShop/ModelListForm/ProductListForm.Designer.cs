
namespace NoUITowaShop.ModelListForm
{
    partial class ProductListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbHeader_Option = new System.Windows.Forms.TableLayoutPanel();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.tbOptionBTN = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cbCategoryList = new System.Windows.Forms.ComboBox();
            this.gbSupplier = new System.Windows.Forms.GroupBox();
            this.cbSupplierNameList = new System.Windows.Forms.ComboBox();
            this.gbSearchProduct = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbProductOrders = new System.Windows.Forms.TableLayoutPanel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TableLayoutPanel();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.tbQuanitty = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuanityValue = new System.Windows.Forms.NumericUpDown();
            this.lbDiscounts = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.checkboxIsMutiAdded = new System.Windows.Forms.CheckBox();
            this.gbProductList = new System.Windows.Forms.GroupBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.tbHeader_Option.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.tbOptionBTN.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.gbSupplier.SuspendLayout();
            this.gbSearchProduct.SuspendLayout();
            this.tbProductOrders.SuspendLayout();
            this.tbDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountValue)).BeginInit();
            this.tbQuanitty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanityValue)).BeginInit();
            this.gbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHeader_Option
            // 
            this.tbHeader_Option.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbHeader_Option.ColumnCount = 4;
            this.tbHeader_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68435F));
            this.tbHeader_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.39215F));
            this.tbHeader_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.39215F));
            this.tbHeader_Option.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.53136F));
            this.tbHeader_Option.Controls.Add(this.gbOption, 3, 0);
            this.tbHeader_Option.Controls.Add(this.gbCategory, 2, 0);
            this.tbHeader_Option.Controls.Add(this.gbSupplier, 1, 0);
            this.tbHeader_Option.Controls.Add(this.gbSearchProduct, 0, 0);
            this.tbHeader_Option.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbHeader_Option.Location = new System.Drawing.Point(3, 3);
            this.tbHeader_Option.Name = "tbHeader_Option";
            this.tbHeader_Option.RowCount = 1;
            this.tbHeader_Option.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbHeader_Option.Size = new System.Drawing.Size(1026, 62);
            this.tbHeader_Option.TabIndex = 0;
            // 
            // gbOption
            // 
            this.gbOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbOption.Controls.Add(this.tbOptionBTN);
            this.gbOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOption.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOption.Location = new System.Drawing.Point(783, 0);
            this.gbOption.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(243, 59);
            this.gbOption.TabIndex = 4;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // tbOptionBTN
            // 
            this.tbOptionBTN.ColumnCount = 2;
            this.tbOptionBTN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbOptionBTN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbOptionBTN.Controls.Add(this.btnCancel, 1, 0);
            this.tbOptionBTN.Controls.Add(this.btnAddProduct, 0, 0);
            this.tbOptionBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOptionBTN.Location = new System.Drawing.Point(3, 23);
            this.tbOptionBTN.Margin = new System.Windows.Forms.Padding(0);
            this.tbOptionBTN.Name = "tbOptionBTN";
            this.tbOptionBTN.RowCount = 1;
            this.tbOptionBTN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbOptionBTN.Size = new System.Drawing.Size(237, 33);
            this.tbOptionBTN.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(118, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(113, 33);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // gbCategory
            // 
            this.gbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbCategory.Controls.Add(this.cbCategoryList);
            this.gbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategory.Location = new System.Drawing.Point(567, 3);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(213, 56);
            this.gbCategory.TabIndex = 3;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // cbCategoryList
            // 
            this.cbCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategoryList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoryList.FormattingEnabled = true;
            this.cbCategoryList.Location = new System.Drawing.Point(3, 23);
            this.cbCategoryList.Name = "cbCategoryList";
            this.cbCategoryList.Size = new System.Drawing.Size(207, 31);
            this.cbCategoryList.TabIndex = 1;
            // 
            // gbSupplier
            // 
            this.gbSupplier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSupplier.Controls.Add(this.cbSupplierNameList);
            this.gbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSupplier.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplier.Location = new System.Drawing.Point(348, 3);
            this.gbSupplier.Name = "gbSupplier";
            this.gbSupplier.Size = new System.Drawing.Size(213, 56);
            this.gbSupplier.TabIndex = 2;
            this.gbSupplier.TabStop = false;
            this.gbSupplier.Text = "Supplier";
            // 
            // cbSupplierNameList
            // 
            this.cbSupplierNameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSupplierNameList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplierNameList.FormattingEnabled = true;
            this.cbSupplierNameList.Location = new System.Drawing.Point(3, 23);
            this.cbSupplierNameList.Name = "cbSupplierNameList";
            this.cbSupplierNameList.Size = new System.Drawing.Size(207, 32);
            this.cbSupplierNameList.TabIndex = 0;
            // 
            // gbSearchProduct
            // 
            this.gbSearchProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbSearchProduct.Controls.Add(this.txtSearch);
            this.gbSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchProduct.Location = new System.Drawing.Point(3, 3);
            this.gbSearchProduct.Name = "gbSearchProduct";
            this.gbSearchProduct.Size = new System.Drawing.Size(339, 56);
            this.gbSearchProduct.TabIndex = 0;
            this.gbSearchProduct.TabStop = false;
            this.gbSearchProduct.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // tbProductOrders
            // 
            this.tbProductOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbProductOrders.ColumnCount = 5;
            this.tbProductOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.29372F));
            this.tbProductOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.16814F));
            this.tbProductOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.46902F));
            this.tbProductOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tbProductOrders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tbProductOrders.Controls.Add(this.lbMessage, 0, 0);
            this.tbProductOrders.Controls.Add(this.tbDiscount, 2, 0);
            this.tbProductOrders.Controls.Add(this.tbQuanitty, 3, 0);
            this.tbProductOrders.Controls.Add(this.lbProductID, 1, 0);
            this.tbProductOrders.Controls.Add(this.checkboxIsMutiAdded, 4, 0);
            this.tbProductOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbProductOrders.Location = new System.Drawing.Point(3, 65);
            this.tbProductOrders.Name = "tbProductOrders";
            this.tbProductOrders.RowCount = 1;
            this.tbProductOrders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbProductOrders.Size = new System.Drawing.Size(1026, 37);
            this.tbProductOrders.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(3, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(234, 37);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscount
            // 
            this.tbDiscount.ColumnCount = 2;
            this.tbDiscount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.96916F));
            this.tbDiscount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.03084F));
            this.tbDiscount.Controls.Add(this.lbDiscount, 0, 0);
            this.tbDiscount.Controls.Add(this.txtDiscountValue, 1, 0);
            this.tbDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDiscount.Location = new System.Drawing.Point(335, 0);
            this.tbDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.RowCount = 1;
            this.tbDiscount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDiscount.Size = new System.Drawing.Size(219, 37);
            this.tbDiscount.TabIndex = 0;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDiscount.Location = new System.Drawing.Point(3, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(83, 37);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "Discount";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.Location = new System.Drawing.Point(92, 3);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(124, 33);
            this.txtDiscountValue.TabIndex = 1;
            // 
            // tbQuanitty
            // 
            this.tbQuanitty.ColumnCount = 2;
            this.tbQuanitty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuanitty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuanitty.Controls.Add(this.txtQuanityValue, 0, 0);
            this.tbQuanitty.Controls.Add(this.lbDiscounts, 0, 0);
            this.tbQuanitty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuanitty.Location = new System.Drawing.Point(554, 0);
            this.tbQuanitty.Margin = new System.Windows.Forms.Padding(0);
            this.tbQuanitty.Name = "tbQuanitty";
            this.tbQuanitty.RowCount = 1;
            this.tbQuanitty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbQuanitty.Size = new System.Drawing.Size(214, 37);
            this.tbQuanitty.TabIndex = 1;
            // 
            // txtQuanityValue
            // 
            this.txtQuanityValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuanityValue.Location = new System.Drawing.Point(110, 3);
            this.txtQuanityValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtQuanityValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuanityValue.Name = "txtQuanityValue";
            this.txtQuanityValue.Size = new System.Drawing.Size(101, 33);
            this.txtQuanityValue.TabIndex = 2;
            this.txtQuanityValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDiscounts
            // 
            this.lbDiscounts.AutoSize = true;
            this.lbDiscounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDiscounts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscounts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDiscounts.Location = new System.Drawing.Point(3, 0);
            this.lbDiscounts.Name = "lbDiscounts";
            this.lbDiscounts.Size = new System.Drawing.Size(101, 37);
            this.lbDiscounts.TabIndex = 1;
            this.lbDiscounts.Text = "Quantity";
            this.lbDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductID.Location = new System.Drawing.Point(243, 0);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(89, 37);
            this.lbProductID.TabIndex = 2;
            this.lbProductID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkboxIsMutiAdded
            // 
            this.checkboxIsMutiAdded.AutoSize = true;
            this.checkboxIsMutiAdded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkboxIsMutiAdded.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxIsMutiAdded.Location = new System.Drawing.Point(771, 3);
            this.checkboxIsMutiAdded.Name = "checkboxIsMutiAdded";
            this.checkboxIsMutiAdded.Size = new System.Drawing.Size(252, 31);
            this.checkboxIsMutiAdded.TabIndex = 5;
            this.checkboxIsMutiAdded.Text = "Multiple Added";
            this.checkboxIsMutiAdded.UseVisualStyleBackColor = true;
            // 
            // gbProductList
            // 
            this.gbProductList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbProductList.Controls.Add(this.dgvProductList);
            this.gbProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductList.Location = new System.Drawing.Point(3, 102);
            this.gbProductList.Name = "gbProductList";
            this.gbProductList.Size = new System.Drawing.Size(1026, 513);
            this.gbProductList.TabIndex = 2;
            this.gbProductList.TabStop = false;
            this.gbProductList.Text = "Product List";
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductList.ColumnHeadersHeight = 29;
            this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductList.Location = new System.Drawing.Point(3, 20);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1020, 490);
            this.dgvProductList.TabIndex = 1;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1032, 618);
            this.Controls.Add(this.gbProductList);
            this.Controls.Add(this.tbProductOrders);
            this.Controls.Add(this.tbHeader_Option);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductListForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductListForm";
            this.tbHeader_Option.ResumeLayout(false);
            this.gbOption.ResumeLayout(false);
            this.tbOptionBTN.ResumeLayout(false);
            this.gbCategory.ResumeLayout(false);
            this.gbSupplier.ResumeLayout(false);
            this.gbSearchProduct.ResumeLayout(false);
            this.gbSearchProduct.PerformLayout();
            this.tbProductOrders.ResumeLayout(false);
            this.tbProductOrders.PerformLayout();
            this.tbDiscount.ResumeLayout(false);
            this.tbDiscount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountValue)).EndInit();
            this.tbQuanitty.ResumeLayout(false);
            this.tbQuanitty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanityValue)).EndInit();
            this.gbProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbHeader_Option;
        private System.Windows.Forms.GroupBox gbSearchProduct;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.TableLayoutPanel tbOptionBTN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tbProductOrders;
        private System.Windows.Forms.TableLayoutPanel tbDiscount;
        private System.Windows.Forms.TableLayoutPanel tbQuanitty;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.NumericUpDown txtDiscountValue;
        private System.Windows.Forms.NumericUpDown txtQuanityValue;
        private System.Windows.Forms.Label lbDiscounts;
        private System.Windows.Forms.GroupBox gbProductList;
        private System.Windows.Forms.ComboBox cbCategoryList;
        private System.Windows.Forms.ComboBox cbSupplierNameList;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.CheckBox checkboxIsMutiAdded;
    }
}