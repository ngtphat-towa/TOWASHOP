
namespace NoUITowaShop.Module.Order
{
    partial class OrderForm
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
            this.tabTableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.lbOrderType = new System.Windows.Forms.Label();
            this.lbOrderStatus = new System.Windows.Forms.Label();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbRecentRecord = new System.Windows.Forms.GroupBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.tbOrderDetailList = new System.Windows.Forms.TableLayoutPanel();
            this.gbReceipt = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rbtnIsCredit = new System.Windows.Forms.RadioButton();
            this.rbtnIsCash = new System.Windows.Forms.RadioButton();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.gbGrandTotal = new System.Windows.Forms.GroupBox();
            this.tbGrandTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lbGrandTotoal = new System.Windows.Forms.Label();
            this.gbTotalDiscount = new System.Windows.Forms.GroupBox();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.gbToal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tbOrderDetailsInfo = new System.Windows.Forms.TableLayoutPanel();
            this.gbSaleInfo = new System.Windows.Forms.GroupBox();
            this.tbSaleInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbCreatedByAccount = new System.Windows.Forms.Label();
            this.dateCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.gbComment = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelOrderControl = new System.Windows.Forms.Panel();
            this.tbProductCart = new System.Windows.Forms.TableLayoutPanel();
            this.gbProductSearch = new System.Windows.Forms.GroupBox();
            this.tb_gbCart = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.txtQuantityValue = new System.Windows.Forms.NumericUpDown();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbProduct_ID_Barcode = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.btnShowProductList = new System.Windows.Forms.Button();
            this.txtDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnResetChange = new System.Windows.Forms.Button();
            this.tabTableHeader.SuspendLayout();
            this.gbRecentRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.tbOrderDetailList.SuspendLayout();
            this.gbReceipt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbGrandTotal.SuspendLayout();
            this.tbGrandTotal.SuspendLayout();
            this.gbTotalDiscount.SuspendLayout();
            this.gbToal.SuspendLayout();
            this.tbOrderDetailsInfo.SuspendLayout();
            this.gbSaleInfo.SuspendLayout();
            this.tbSaleInfo.SuspendLayout();
            this.gbComment.SuspendLayout();
            this.tbProductCart.SuspendLayout();
            this.gbProductSearch.SuspendLayout();
            this.tb_gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTableHeader
            // 
            this.tabTableHeader.BackColor = System.Drawing.Color.Crimson;
            this.tabTableHeader.ColumnCount = 7;
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16667F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.91667F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16667F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58333F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.33333F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.83333F));
            this.tabTableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.916667F));
            this.tabTableHeader.Controls.Add(this.cbOrderType, 1, 0);
            this.tabTableHeader.Controls.Add(this.lbOrderType, 0, 0);
            this.tabTableHeader.Controls.Add(this.lbOrderStatus, 2, 0);
            this.tabTableHeader.Controls.Add(this.cbOrderStatus, 3, 0);
            this.tabTableHeader.Controls.Add(this.btnCancel, 6, 0);
            this.tabTableHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabTableHeader.Location = new System.Drawing.Point(0, 0);
            this.tabTableHeader.Name = "tabTableHeader";
            this.tabTableHeader.RowCount = 1;
            this.tabTableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabTableHeader.Size = new System.Drawing.Size(1200, 35);
            this.tabTableHeader.TabIndex = 0;
            // 
            // cbOrderType
            // 
            this.cbOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Items.AddRange(new object[] {
            "Retail Order",
            "Customer Order",
            "Supply Stock"});
            this.cbOrderType.Location = new System.Drawing.Point(149, 3);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(209, 32);
            this.cbOrderType.TabIndex = 0;
            // 
            // lbOrderType
            // 
            this.lbOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderType.AutoSize = true;
            this.lbOrderType.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbOrderType.Location = new System.Drawing.Point(3, 0);
            this.lbOrderType.Name = "lbOrderType";
            this.lbOrderType.Size = new System.Drawing.Size(140, 35);
            this.lbOrderType.TabIndex = 1;
            this.lbOrderType.Text = "Order Type";
            this.lbOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrderStatus
            // 
            this.lbOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderStatus.AutoSize = true;
            this.lbOrderStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbOrderStatus.Location = new System.Drawing.Point(364, 0);
            this.lbOrderStatus.Name = "lbOrderStatus";
            this.lbOrderStatus.Size = new System.Drawing.Size(140, 35);
            this.lbOrderStatus.TabIndex = 2;
            this.lbOrderStatus.Text = "Order Status";
            this.lbOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Items.AddRange(new object[] {
            "Paid",
            "New",
            "Delivering"});
            this.cbOrderStatus.Location = new System.Drawing.Point(510, 3);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(145, 32);
            this.cbOrderStatus.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(1083, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // gbRecentRecord
            // 
            this.gbRecentRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecentRecord.BackColor = System.Drawing.Color.Crimson;
            this.gbRecentRecord.Controls.Add(this.dgvOrderList);
            this.gbRecentRecord.ForeColor = System.Drawing.Color.Black;
            this.gbRecentRecord.Location = new System.Drawing.Point(3, 3);
            this.gbRecentRecord.Name = "gbRecentRecord";
            this.gbRecentRecord.Size = new System.Drawing.Size(953, 420);
            this.gbRecentRecord.TabIndex = 1;
            this.gbRecentRecord.TabStop = false;
            this.gbRecentRecord.Text = "Product Orders";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersHeight = 29;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(947, 394);
            this.dgvOrderList.TabIndex = 1;
            // 
            // tbOrderDetailList
            // 
            this.tbOrderDetailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderDetailList.ColumnCount = 2;
            this.tbOrderDetailList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.91666F));
            this.tbOrderDetailList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08333F));
            this.tbOrderDetailList.Controls.Add(this.gbRecentRecord, 0, 0);
            this.tbOrderDetailList.Controls.Add(this.gbReceipt, 1, 0);
            this.tbOrderDetailList.Location = new System.Drawing.Point(0, 214);
            this.tbOrderDetailList.Name = "tbOrderDetailList";
            this.tbOrderDetailList.RowCount = 1;
            this.tbOrderDetailList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbOrderDetailList.Size = new System.Drawing.Size(1200, 426);
            this.tbOrderDetailList.TabIndex = 2;
            // 
            // gbReceipt
            // 
            this.gbReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReceipt.Controls.Add(this.tableLayoutPanel1);
            this.gbReceipt.Controls.Add(this.btnSaveOrder);
            this.gbReceipt.Controls.Add(this.gbGrandTotal);
            this.gbReceipt.Controls.Add(this.gbTotalDiscount);
            this.gbReceipt.Controls.Add(this.gbToal);
            this.gbReceipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbReceipt.Location = new System.Drawing.Point(962, 3);
            this.gbReceipt.Name = "gbReceipt";
            this.gbReceipt.Padding = new System.Windows.Forms.Padding(1);
            this.gbReceipt.Size = new System.Drawing.Size(235, 420);
            this.gbReceipt.TabIndex = 2;
            this.gbReceipt.TabStop = false;
            this.gbReceipt.Text = "Receipt";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.76395F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.23605F));
            this.tableLayoutPanel1.Controls.Add(this.rbtnIsCredit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtnIsCash, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 44);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // rbtnIsCredit
            // 
            this.rbtnIsCredit.AutoSize = true;
            this.rbtnIsCredit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnIsCredit.Location = new System.Drawing.Point(84, 3);
            this.rbtnIsCredit.Name = "rbtnIsCredit";
            this.rbtnIsCredit.Size = new System.Drawing.Size(146, 38);
            this.rbtnIsCredit.TabIndex = 1;
            this.rbtnIsCredit.Text = "Credit";
            this.rbtnIsCredit.UseVisualStyleBackColor = true;
            // 
            // rbtnIsCash
            // 
            this.rbtnIsCash.AutoSize = true;
            this.rbtnIsCash.Checked = true;
            this.rbtnIsCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtnIsCash.Location = new System.Drawing.Point(3, 3);
            this.rbtnIsCash.Name = "rbtnIsCash";
            this.rbtnIsCash.Size = new System.Drawing.Size(75, 38);
            this.rbtnIsCash.TabIndex = 0;
            this.rbtnIsCash.TabStop = true;
            this.rbtnIsCash.Text = "Cash";
            this.rbtnIsCash.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.Teal;
            this.btnSaveOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveOrder.Location = new System.Drawing.Point(1, 364);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(233, 55);
            this.btnSaveOrder.TabIndex = 10;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            // 
            // gbGrandTotal
            // 
            this.gbGrandTotal.Controls.Add(this.tbGrandTotal);
            this.gbGrandTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGrandTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGrandTotal.Location = new System.Drawing.Point(1, 150);
            this.gbGrandTotal.Name = "gbGrandTotal";
            this.gbGrandTotal.Padding = new System.Windows.Forms.Padding(0);
            this.gbGrandTotal.Size = new System.Drawing.Size(233, 117);
            this.gbGrandTotal.TabIndex = 8;
            this.gbGrandTotal.TabStop = false;
            this.gbGrandTotal.Text = "Grand Total";
            // 
            // tbGrandTotal
            // 
            this.tbGrandTotal.ColumnCount = 1;
            this.tbGrandTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbGrandTotal.Controls.Add(this.lbGrandTotoal, 0, 0);
            this.tbGrandTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGrandTotal.Location = new System.Drawing.Point(0, 22);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.RowCount = 1;
            this.tbGrandTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbGrandTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tbGrandTotal.Size = new System.Drawing.Size(233, 95);
            this.tbGrandTotal.TabIndex = 8;
            // 
            // lbGrandTotoal
            // 
            this.lbGrandTotoal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGrandTotoal.AutoSize = true;
            this.lbGrandTotoal.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbGrandTotoal.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrandTotoal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbGrandTotoal.Location = new System.Drawing.Point(3, 0);
            this.lbGrandTotoal.Name = "lbGrandTotoal";
            this.lbGrandTotoal.Size = new System.Drawing.Size(227, 95);
            this.lbGrandTotoal.TabIndex = 3;
            this.lbGrandTotoal.Text = "1000.0";
            this.lbGrandTotoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTotalDiscount
            // 
            this.gbTotalDiscount.Controls.Add(this.txtTotalDiscount);
            this.gbTotalDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTotalDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalDiscount.Location = new System.Drawing.Point(1, 87);
            this.gbTotalDiscount.Name = "gbTotalDiscount";
            this.gbTotalDiscount.Padding = new System.Windows.Forms.Padding(0);
            this.gbTotalDiscount.Size = new System.Drawing.Size(233, 63);
            this.gbTotalDiscount.TabIndex = 6;
            this.gbTotalDiscount.TabStop = false;
            this.gbTotalDiscount.Text = "Total Discount %";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDiscount.Enabled = false;
            this.txtTotalDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(0, 22);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.Size = new System.Drawing.Size(233, 33);
            this.txtTotalDiscount.TabIndex = 0;
            this.txtTotalDiscount.Text = "0.0";
            this.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbToal
            // 
            this.gbToal.Controls.Add(this.txtTotal);
            this.gbToal.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbToal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToal.Location = new System.Drawing.Point(1, 24);
            this.gbToal.Name = "gbToal";
            this.gbToal.Padding = new System.Windows.Forms.Padding(0);
            this.gbToal.Size = new System.Drawing.Size(233, 63);
            this.gbToal.TabIndex = 5;
            this.gbToal.TabStop = false;
            this.gbToal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(0, 22);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(233, 33);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0.0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOrderDetailsInfo
            // 
            this.tbOrderDetailsInfo.ColumnCount = 4;
            this.tbOrderDetailsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95008F));
            this.tbOrderDetailsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.58333F));
            this.tbOrderDetailsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tbOrderDetailsInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.13311F));
            this.tbOrderDetailsInfo.Controls.Add(this.gbSaleInfo, 0, 0);
            this.tbOrderDetailsInfo.Controls.Add(this.gbComment, 2, 0);
            this.tbOrderDetailsInfo.Controls.Add(this.groupBox4, 3, 0);
            this.tbOrderDetailsInfo.Controls.Add(this.panelOrderControl, 1, 0);
            this.tbOrderDetailsInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOrderDetailsInfo.Location = new System.Drawing.Point(0, 35);
            this.tbOrderDetailsInfo.Name = "tbOrderDetailsInfo";
            this.tbOrderDetailsInfo.RowCount = 1;
            this.tbOrderDetailsInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbOrderDetailsInfo.Size = new System.Drawing.Size(1200, 110);
            this.tbOrderDetailsInfo.TabIndex = 1;
            // 
            // gbSaleInfo
            // 
            this.gbSaleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSaleInfo.Controls.Add(this.tbSaleInfo);
            this.gbSaleInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaleInfo.Location = new System.Drawing.Point(3, 3);
            this.gbSaleInfo.Name = "gbSaleInfo";
            this.gbSaleInfo.Size = new System.Drawing.Size(353, 104);
            this.gbSaleInfo.TabIndex = 0;
            this.gbSaleInfo.TabStop = false;
            this.gbSaleInfo.Text = "Sale Info";
            // 
            // tbSaleInfo
            // 
            this.tbSaleInfo.ColumnCount = 2;
            this.tbSaleInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.30699F));
            this.tbSaleInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.69301F));
            this.tbSaleInfo.Controls.Add(this.lbDate, 0, 1);
            this.tbSaleInfo.Controls.Add(this.lbAccount, 0, 0);
            this.tbSaleInfo.Controls.Add(this.lbCreatedByAccount, 1, 0);
            this.tbSaleInfo.Controls.Add(this.dateCreatedAt, 1, 1);
            this.tbSaleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSaleInfo.Location = new System.Drawing.Point(3, 26);
            this.tbSaleInfo.Name = "tbSaleInfo";
            this.tbSaleInfo.RowCount = 2;
            this.tbSaleInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbSaleInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbSaleInfo.Size = new System.Drawing.Size(347, 75);
            this.tbSaleInfo.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(3, 37);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(102, 38);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Date:";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAccount
            // 
            this.lbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.Location = new System.Drawing.Point(3, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(102, 37);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Created By:";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCreatedByAccount
            // 
            this.lbCreatedByAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreatedByAccount.AutoSize = true;
            this.lbCreatedByAccount.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByAccount.Location = new System.Drawing.Point(111, 0);
            this.lbCreatedByAccount.Name = "lbCreatedByAccount";
            this.lbCreatedByAccount.Size = new System.Drawing.Size(233, 37);
            this.lbCreatedByAccount.TabIndex = 1;
            this.lbCreatedByAccount.Text = "USERNAME";
            this.lbCreatedByAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateCreatedAt
            // 
            this.dateCreatedAt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreatedAt.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedAt.CustomFormat = "dd-MM-yyyy";
            this.dateCreatedAt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCreatedAt.Location = new System.Drawing.Point(111, 40);
            this.dateCreatedAt.Name = "dateCreatedAt";
            this.dateCreatedAt.Size = new System.Drawing.Size(233, 30);
            this.dateCreatedAt.TabIndex = 3;
            // 
            // gbComment
            // 
            this.gbComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbComment.Controls.Add(this.txtComment);
            this.gbComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComment.Location = new System.Drawing.Point(705, 3);
            this.gbComment.Name = "gbComment";
            this.gbComment.Size = new System.Drawing.Size(249, 104);
            this.gbComment.TabIndex = 0;
            this.gbComment.TabStop = false;
            this.gbComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(3, 26);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(243, 75);
            this.txtComment.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(960, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 104);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Print";
            // 
            // panelOrderControl
            // 
            this.panelOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderControl.Location = new System.Drawing.Point(359, 0);
            this.panelOrderControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelOrderControl.Name = "panelOrderControl";
            this.panelOrderControl.Size = new System.Drawing.Size(343, 110);
            this.panelOrderControl.TabIndex = 2;
            // 
            // tbProductCart
            // 
            this.tbProductCart.ColumnCount = 1;
            this.tbProductCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.83334F));
            this.tbProductCart.Controls.Add(this.gbProductSearch, 0, 0);
            this.tbProductCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbProductCart.Location = new System.Drawing.Point(0, 145);
            this.tbProductCart.Margin = new System.Windows.Forms.Padding(0);
            this.tbProductCart.Name = "tbProductCart";
            this.tbProductCart.RowCount = 1;
            this.tbProductCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbProductCart.Size = new System.Drawing.Size(1200, 63);
            this.tbProductCart.TabIndex = 3;
            // 
            // gbProductSearch
            // 
            this.gbProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProductSearch.Controls.Add(this.tb_gbCart);
            this.gbProductSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductSearch.Location = new System.Drawing.Point(1, 1);
            this.gbProductSearch.Margin = new System.Windows.Forms.Padding(1);
            this.gbProductSearch.Name = "gbProductSearch";
            this.gbProductSearch.Padding = new System.Windows.Forms.Padding(1);
            this.gbProductSearch.Size = new System.Drawing.Size(1198, 61);
            this.gbProductSearch.TabIndex = 0;
            this.gbProductSearch.TabStop = false;
            this.gbProductSearch.Text = "Cart";
            // 
            // tb_gbCart
            // 
            this.tb_gbCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_gbCart.ColumnCount = 9;
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.197325F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97324F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.762542F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.779264F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13712F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.197325F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.22074F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20067F));
            this.tb_gbCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.36789F));
            this.tb_gbCart.Controls.Add(this.btnRemoveProduct, 7, 0);
            this.tb_gbCart.Controls.Add(this.txtQuantityValue, 6, 0);
            this.tb_gbCart.Controls.Add(this.lbDiscount, 3, 0);
            this.tb_gbCart.Controls.Add(this.lbProduct_ID_Barcode, 0, 0);
            this.tb_gbCart.Controls.Add(this.txtProductSearch, 1, 0);
            this.tb_gbCart.Controls.Add(this.btnShowProductList, 2, 0);
            this.tb_gbCart.Controls.Add(this.txtDiscountValue, 4, 0);
            this.tb_gbCart.Controls.Add(this.lbQuantity, 5, 0);
            this.tb_gbCart.Controls.Add(this.btnResetChange, 8, 0);
            this.tb_gbCart.Location = new System.Drawing.Point(1, 23);
            this.tb_gbCart.Margin = new System.Windows.Forms.Padding(0);
            this.tb_gbCart.Name = "tb_gbCart";
            this.tb_gbCart.RowCount = 1;
            this.tb_gbCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_gbCart.Size = new System.Drawing.Size(1196, 37);
            this.tb_gbCart.TabIndex = 0;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveProduct.Location = new System.Drawing.Point(953, 3);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(114, 31);
            this.btnRemoveProduct.TabIndex = 0;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            // 
            // txtQuantityValue
            // 
            this.txtQuantityValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityValue.Location = new System.Drawing.Point(761, 3);
            this.txtQuantityValue.Name = "txtQuantityValue";
            this.txtQuantityValue.Size = new System.Drawing.Size(186, 33);
            this.txtQuantityValue.TabIndex = 7;
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(357, 0);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(98, 37);
            this.lbDiscount.TabIndex = 3;
            this.lbDiscount.Text = "Discount(%)";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProduct_ID_Barcode
            // 
            this.lbProduct_ID_Barcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProduct_ID_Barcode.AutoSize = true;
            this.lbProduct_ID_Barcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct_ID_Barcode.Location = new System.Drawing.Point(3, 0);
            this.lbProduct_ID_Barcode.Name = "lbProduct_ID_Barcode";
            this.lbProduct_ID_Barcode.Size = new System.Drawing.Size(103, 37);
            this.lbProduct_ID_Barcode.TabIndex = 1;
            this.lbProduct_ID_Barcode.Text = "Barcode/ID:";
            this.lbProduct_ID_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.Location = new System.Drawing.Point(112, 3);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(195, 33);
            this.txtProductSearch.TabIndex = 0;
            // 
            // btnShowProductList
            // 
            this.btnShowProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowProductList.BackColor = System.Drawing.Color.LawnGreen;
            this.btnShowProductList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowProductList.Location = new System.Drawing.Point(313, 3);
            this.btnShowProductList.Name = "btnShowProductList";
            this.btnShowProductList.Size = new System.Drawing.Size(38, 31);
            this.btnShowProductList.TabIndex = 2;
            this.btnShowProductList.Text = "?";
            this.btnShowProductList.UseVisualStyleBackColor = false;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.Location = new System.Drawing.Point(461, 3);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(185, 33);
            this.txtDiscountValue.TabIndex = 5;
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(652, 0);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(103, 37);
            this.lbQuantity.TabIndex = 6;
            this.lbQuantity.Text = "Quantity";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResetChange
            // 
            this.btnResetChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetChange.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResetChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetChange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetChange.Location = new System.Drawing.Point(1073, 3);
            this.btnResetChange.Name = "btnResetChange";
            this.btnResetChange.Size = new System.Drawing.Size(120, 31);
            this.btnResetChange.TabIndex = 1;
            this.btnResetChange.Text = "Reset";
            this.btnResetChange.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.tbProductCart);
            this.Controls.Add(this.tbOrderDetailsInfo);
            this.Controls.Add(this.tbOrderDetailList);
            this.Controls.Add(this.tabTableHeader);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.tabTableHeader.ResumeLayout(false);
            this.tabTableHeader.PerformLayout();
            this.gbRecentRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.tbOrderDetailList.ResumeLayout(false);
            this.gbReceipt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbGrandTotal.ResumeLayout(false);
            this.tbGrandTotal.ResumeLayout(false);
            this.tbGrandTotal.PerformLayout();
            this.gbTotalDiscount.ResumeLayout(false);
            this.gbTotalDiscount.PerformLayout();
            this.gbToal.ResumeLayout(false);
            this.gbToal.PerformLayout();
            this.tbOrderDetailsInfo.ResumeLayout(false);
            this.gbSaleInfo.ResumeLayout(false);
            this.tbSaleInfo.ResumeLayout(false);
            this.tbSaleInfo.PerformLayout();
            this.gbComment.ResumeLayout(false);
            this.gbComment.PerformLayout();
            this.tbProductCart.ResumeLayout(false);
            this.gbProductSearch.ResumeLayout(false);
            this.tb_gbCart.ResumeLayout(false);
            this.tb_gbCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabTableHeader;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.Label lbOrderType;
        private System.Windows.Forms.GroupBox gbRecentRecord;
        private System.Windows.Forms.Label lbOrderStatus;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private System.Windows.Forms.TableLayoutPanel tbOrderDetailList;
        private System.Windows.Forms.TableLayoutPanel tbOrderDetailsInfo;
        private System.Windows.Forms.GroupBox gbSaleInfo;
        private System.Windows.Forms.TableLayoutPanel tbSaleInfo;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbCreatedByAccount;
        private System.Windows.Forms.DateTimePicker dateCreatedAt;
        private System.Windows.Forms.GroupBox gbComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TableLayoutPanel tbProductCart;
        private System.Windows.Forms.GroupBox gbProductSearch;
        private System.Windows.Forms.TableLayoutPanel tb_gbCart;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.Label lbProduct_ID_Barcode;
        private System.Windows.Forms.Button btnShowProductList;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.NumericUpDown txtDiscountValue;
        private System.Windows.Forms.Button btnResetChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown txtQuantityValue;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.GroupBox gbReceipt;
        private System.Windows.Forms.GroupBox gbTotalDiscount;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.GroupBox gbToal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbGrandTotal;
        private System.Windows.Forms.TableLayoutPanel tbGrandTotal;
        private System.Windows.Forms.Label lbGrandTotoal;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rbtnIsCredit;
        private System.Windows.Forms.RadioButton rbtnIsCash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panelOrderControl;
        private System.Windows.Forms.DataGridView dgvOrderList;
    }
}