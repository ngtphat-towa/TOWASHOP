
using System;

namespace NoUITowaShop.Module.Order
{
    partial class OrderListModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableOption = new System.Windows.Forms.TableLayoutPanel();
            this.gbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tbOptionBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbDateTo = new System.Windows.Forms.GroupBox();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.gbDateFrom = new System.Windows.Forms.GroupBox();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.gbOrderType = new System.Windows.Forms.GroupBox();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbPanelLFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.gbReviewBill = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.gbRecentRecord = new System.Windows.Forms.GroupBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.tableOrderList = new System.Windows.Forms.TableLayoutPanel();
            this.tbStatistical = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotal_Number = new System.Windows.Forms.Label();
            this.lbNumber__Sold = new System.Windows.Forms.Label();
            this.lbTotalNumber = new System.Windows.Forms.Label();
            this.lbNumber_Paid = new System.Windows.Forms.Label();
            this.lbNumber_Profit = new System.Windows.Forms.Label();
            this.lbPaid = new System.Windows.Forms.Label();
            this.lbSupplied = new System.Windows.Forms.Label();
            this.lbSold = new System.Windows.Forms.Label();
            this.tableOption.SuspendLayout();
            this.gbPaymentMethod.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tbOptionBtn.SuspendLayout();
            this.gbDateTo.SuspendLayout();
            this.gbDateFrom.SuspendLayout();
            this.gbOrderType.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbReviewBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).BeginInit();
            this.gbRecentRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.tableOrderList.SuspendLayout();
            this.tbStatistical.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOption
            // 
            this.tableOption.ColumnCount = 6;
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65378F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65378F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.65378F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.01406F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.78383F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.24077F));
            this.tableOption.Controls.Add(this.gbPaymentMethod, 2, 0);
            this.tableOption.Controls.Add(this.gbStatus, 1, 0);
            this.tableOption.Controls.Add(this.gbOptions, 5, 0);
            this.tableOption.Controls.Add(this.gbDateTo, 4, 0);
            this.tableOption.Controls.Add(this.gbDateFrom, 3, 0);
            this.tableOption.Controls.Add(this.gbOrderType, 0, 0);
            this.tableOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableOption.Location = new System.Drawing.Point(0, 0);
            this.tableOption.Name = "tableOption";
            this.tableOption.RowCount = 1;
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOption.Size = new System.Drawing.Size(1200, 69);
            this.tableOption.TabIndex = 10;
            // 
            // gbPaymentMethod
            // 
            this.gbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPaymentMethod.Controls.Add(this.cbPaymentMethod);
            this.gbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPaymentMethod.Location = new System.Drawing.Point(305, 3);
            this.gbPaymentMethod.Name = "gbPaymentMethod";
            this.gbPaymentMethod.Size = new System.Drawing.Size(145, 63);
            this.gbPaymentMethod.TabIndex = 15;
            this.gbPaymentMethod.TabStop = false;
            this.gbPaymentMethod.Text = "# Payment:";
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(6, 25);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(133, 31);
            this.cbPaymentMethod.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatus.Location = new System.Drawing.Point(154, 3);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(145, 63);
            this.gbStatus.TabIndex = 14;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "# Order Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(6, 25);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(133, 31);
            this.cbStatus.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.tbOptionBtn);
            this.gbOptions.Location = new System.Drawing.Point(873, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(324, 63);
            this.gbOptions.TabIndex = 12;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Option";
            // 
            // tbOptionBtn
            // 
            this.tbOptionBtn.ColumnCount = 3;
            this.tbOptionBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbOptionBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbOptionBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbOptionBtn.Controls.Add(this.btnRefresh, 2, 0);
            this.tbOptionBtn.Controls.Add(this.btnEdit, 1, 0);
            this.tbOptionBtn.Controls.Add(this.btnNew, 0, 0);
            this.tbOptionBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOptionBtn.Location = new System.Drawing.Point(3, 23);
            this.tbOptionBtn.Name = "tbOptionBtn";
            this.tbOptionBtn.RowCount = 1;
            this.tbOptionBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbOptionBtn.Size = new System.Drawing.Size(318, 37);
            this.tbOptionBtn.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Sienna;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(215, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 31);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(109, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modify";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Orange;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // gbDateTo
            // 
            this.gbDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateTo.Controls.Add(this.datePickerTo);
            this.gbDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateTo.Location = new System.Drawing.Point(672, 3);
            this.gbDateTo.Name = "gbDateTo";
            this.gbDateTo.Size = new System.Drawing.Size(195, 63);
            this.gbDateTo.TabIndex = 10;
            this.gbDateTo.TabStop = false;
            this.gbDateTo.Text = "# Date To:";
            // 
            // datePickerTo
            // 
            this.datePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerTo.Checked = false;
            this.datePickerTo.CustomFormat = "dd/MM/yyyy";
            this.datePickerTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerTo.Location = new System.Drawing.Point(0, 23);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(189, 29);
            this.datePickerTo.TabIndex = 0;
            // 
            // gbDateFrom
            // 
            this.gbDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateFrom.Controls.Add(this.datePickerFrom);
            this.gbDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateFrom.Location = new System.Drawing.Point(456, 3);
            this.gbDateFrom.Name = "gbDateFrom";
            this.gbDateFrom.Size = new System.Drawing.Size(210, 63);
            this.gbDateFrom.TabIndex = 11;
            this.gbDateFrom.TabStop = false;
            this.gbDateFrom.Text = "# Date From:";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePickerFrom.Checked = false;
            this.datePickerFrom.CustomFormat = "dd/MM/yyyy";
            this.datePickerFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerFrom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datePickerFrom.Location = new System.Drawing.Point(0, 23);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(204, 29);
            this.datePickerFrom.TabIndex = 0;
            // 
            // gbOrderType
            // 
            this.gbOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrderType.Controls.Add(this.cbOrderType);
            this.gbOrderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderType.Location = new System.Drawing.Point(3, 3);
            this.gbOrderType.Name = "gbOrderType";
            this.gbOrderType.Size = new System.Drawing.Size(145, 63);
            this.gbOrderType.TabIndex = 9;
            this.gbOrderType.TabStop = false;
            this.gbOrderType.Text = "# Order type:";
            // 
            // cbOrderType
            // 
            this.cbOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Location = new System.Drawing.Point(6, 25);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(133, 31);
            this.cbOrderType.TabIndex = 0;
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbErrorMessage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorMessage.Location = new System.Drawing.Point(664, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.lbErrorMessage.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(116, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(407, 33);
            this.txtSearch.TabIndex = 0;
            // 
            // tbPanelLFooter
            // 
            this.tbPanelLFooter.BackColor = System.Drawing.Color.Navy;
            this.tbPanelLFooter.ColumnCount = 3;
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.39233F));
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelLFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPanelLFooter.Location = new System.Drawing.Point(0, 622);
            this.tbPanelLFooter.Name = "tbPanelLFooter";
            this.tbPanelLFooter.RowCount = 1;
            this.tbPanelLFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanelLFooter.Size = new System.Drawing.Size(1200, 18);
            this.tbPanelLFooter.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41033F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5165F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 538F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbSearch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbErrorMessage, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 69);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1200, 36);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(529, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(3, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(107, 36);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "# Search";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbReviewBill
            // 
            this.gbReviewBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReviewBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbReviewBill.Controls.Add(this.dgvOrderDetailsList);
            this.gbReviewBill.Location = new System.Drawing.Point(768, 3);
            this.gbReviewBill.Name = "gbReviewBill";
            this.gbReviewBill.Size = new System.Drawing.Size(429, 456);
            this.gbReviewBill.TabIndex = 1;
            this.gbReviewBill.TabStop = false;
            this.gbReviewBill.Text = "Review Bill";
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AllowUserToAddRows = false;
            this.dgvOrderDetailsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvOrderDetailsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrderDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailsList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetailsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrderDetailsList.RowTemplate.Height = 24;
            this.dgvOrderDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(423, 430);
            this.dgvOrderDetailsList.TabIndex = 0;
            // 
            // gbRecentRecord
            // 
            this.gbRecentRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRecentRecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRecentRecord.Controls.Add(this.dgvOrderList);
            this.gbRecentRecord.Location = new System.Drawing.Point(3, 3);
            this.gbRecentRecord.Name = "gbRecentRecord";
            this.gbRecentRecord.Size = new System.Drawing.Size(759, 456);
            this.gbRecentRecord.TabIndex = 0;
            this.gbRecentRecord.TabStop = false;
            this.gbRecentRecord.Text = "Recent Orders";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersHeight = 29;
            this.dgvOrderList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(753, 430);
            this.dgvOrderList.TabIndex = 0;
            // 
            // tableOrderList
            // 
            this.tableOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOrderList.ColumnCount = 2;
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.83333F));
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.16667F));
            this.tableOrderList.Controls.Add(this.gbRecentRecord, 0, 0);
            this.tableOrderList.Controls.Add(this.gbReviewBill, 1, 0);
            this.tableOrderList.Controls.Add(this.tbStatistical, 0, 1);
            this.tableOrderList.Location = new System.Drawing.Point(0, 108);
            this.tableOrderList.Name = "tableOrderList";
            this.tableOrderList.RowCount = 2;
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableOrderList.Size = new System.Drawing.Size(1200, 514);
            this.tableOrderList.TabIndex = 11;
            // 
            // tbStatistical
            // 
            this.tbStatistical.ColumnCount = 4;
            this.tbStatistical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbStatistical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbStatistical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbStatistical.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbStatistical.Controls.Add(this.lbTotal_Number, 0, 0);
            this.tbStatistical.Controls.Add(this.lbNumber__Sold, 3, 0);
            this.tbStatistical.Controls.Add(this.lbTotalNumber, 0, 1);
            this.tbStatistical.Controls.Add(this.lbNumber_Paid, 1, 0);
            this.tbStatistical.Controls.Add(this.lbNumber_Profit, 2, 0);
            this.tbStatistical.Controls.Add(this.lbPaid, 1, 1);
            this.tbStatistical.Controls.Add(this.lbSupplied, 2, 1);
            this.tbStatistical.Controls.Add(this.lbSold, 3, 1);
            this.tbStatistical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStatistical.Location = new System.Drawing.Point(0, 462);
            this.tbStatistical.Margin = new System.Windows.Forms.Padding(0);
            this.tbStatistical.Name = "tbStatistical";
            this.tbStatistical.RowCount = 2;
            this.tbStatistical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbStatistical.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbStatistical.Size = new System.Drawing.Size(765, 52);
            this.tbStatistical.TabIndex = 2;
            // 
            // lbTotal_Number
            // 
            this.lbTotal_Number.AutoSize = true;
            this.lbTotal_Number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal_Number.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal_Number.Location = new System.Drawing.Point(3, 0);
            this.lbTotal_Number.Name = "lbTotal_Number";
            this.lbTotal_Number.Size = new System.Drawing.Size(185, 26);
            this.lbTotal_Number.TabIndex = 2;
            this.lbTotal_Number.Text = "#Order number:";
            this.lbTotal_Number.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNumber__Sold
            // 
            this.lbNumber__Sold.AutoSize = true;
            this.lbNumber__Sold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumber__Sold.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber__Sold.Location = new System.Drawing.Point(576, 0);
            this.lbNumber__Sold.Name = "lbNumber__Sold";
            this.lbNumber__Sold.Size = new System.Drawing.Size(186, 26);
            this.lbNumber__Sold.TabIndex = 4;
            this.lbNumber__Sold.Text = "Total Sold";
            this.lbNumber__Sold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalNumber
            // 
            this.lbTotalNumber.AutoSize = true;
            this.lbTotalNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalNumber.Location = new System.Drawing.Point(3, 26);
            this.lbTotalNumber.Name = "lbTotalNumber";
            this.lbTotalNumber.Size = new System.Drawing.Size(185, 26);
            this.lbTotalNumber.TabIndex = 5;
            this.lbTotalNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNumber_Paid
            // 
            this.lbNumber_Paid.AutoSize = true;
            this.lbNumber_Paid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumber_Paid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber_Paid.Location = new System.Drawing.Point(194, 0);
            this.lbNumber_Paid.Name = "lbNumber_Paid";
            this.lbNumber_Paid.Size = new System.Drawing.Size(185, 26);
            this.lbNumber_Paid.TabIndex = 6;
            this.lbNumber_Paid.Text = "Total Paid";
            this.lbNumber_Paid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbNumber_Profit
            // 
            this.lbNumber_Profit.AutoSize = true;
            this.lbNumber_Profit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumber_Profit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber_Profit.Location = new System.Drawing.Point(385, 0);
            this.lbNumber_Profit.Name = "lbNumber_Profit";
            this.lbNumber_Profit.Size = new System.Drawing.Size(185, 26);
            this.lbNumber_Profit.TabIndex = 7;
            this.lbNumber_Profit.Text = "Total Supplied";
            this.lbNumber_Profit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPaid
            // 
            this.lbPaid.AutoSize = true;
            this.lbPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPaid.Location = new System.Drawing.Point(194, 26);
            this.lbPaid.Name = "lbPaid";
            this.lbPaid.Size = new System.Drawing.Size(185, 26);
            this.lbPaid.TabIndex = 8;
            this.lbPaid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSupplied
            // 
            this.lbSupplied.AutoSize = true;
            this.lbSupplied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSupplied.Location = new System.Drawing.Point(385, 26);
            this.lbSupplied.Name = "lbSupplied";
            this.lbSupplied.Size = new System.Drawing.Size(185, 26);
            this.lbSupplied.TabIndex = 9;
            this.lbSupplied.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSold
            // 
            this.lbSold.AutoSize = true;
            this.lbSold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSold.Location = new System.Drawing.Point(576, 26);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(186, 26);
            this.lbSold.TabIndex = 10;
            this.lbSold.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderListModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableOrderList);
            this.Controls.Add(this.tableOption);
            this.Controls.Add(this.tbPanelLFooter);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderListModule";
            this.Text = "OrderModule";
            this.tableOption.ResumeLayout(false);
            this.gbPaymentMethod.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbOptions.ResumeLayout(false);
            this.tbOptionBtn.ResumeLayout(false);
            this.gbDateTo.ResumeLayout(false);
            this.gbDateFrom.ResumeLayout(false);
            this.gbOrderType.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbReviewBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).EndInit();
            this.gbRecentRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.tableOrderList.ResumeLayout(false);
            this.tbStatistical.ResumeLayout(false);
            this.tbStatistical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableOption;
        private System.Windows.Forms.GroupBox gbDateFrom;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.GroupBox gbDateTo;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tbPanelLFooter;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox gbPaymentMethod ;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TableLayoutPanel tbOptionBtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbOrderType;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.GroupBox gbReviewBill;
        private System.Windows.Forms.DataGridView dgvOrderDetailsList;
        private System.Windows.Forms.GroupBox gbRecentRecord;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.TableLayoutPanel tableOrderList;
        private System.Windows.Forms.TableLayoutPanel tbStatistical;
        private System.Windows.Forms.Label lbTotal_Number;
        private System.Windows.Forms.Label lbNumber__Sold;
        private System.Windows.Forms.Label lbTotalNumber;
        private System.Windows.Forms.Label lbNumber_Paid;
        private System.Windows.Forms.Label lbNumber_Profit;
        private System.Windows.Forms.Label lbPaid;
        private System.Windows.Forms.Label lbSupplied;
        private System.Windows.Forms.Label lbSold;
    }
}