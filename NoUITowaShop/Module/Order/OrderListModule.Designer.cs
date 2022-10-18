
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.gbReviewBill = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.gbRecentRecord = new System.Windows.Forms.GroupBox();
            this.tableOrderList = new System.Windows.Forms.TableLayoutPanel();
            this.tableOption = new System.Windows.Forms.TableLayoutPanel();
            this.gbDateFrom = new System.Windows.Forms.GroupBox();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.gbDateTo = new System.Windows.Forms.GroupBox();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.gbOrderType = new System.Windows.Forms.GroupBox();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbPanelLFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new System.Windows.Forms.NumericUpDown();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.gbReviewBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).BeginInit();
            this.gbRecentRecord.SuspendLayout();
            this.tableOrderList.SuspendLayout();
            this.tableOption.SuspendLayout();
            this.gbDateFrom.SuspendLayout();
            this.gbDateTo.SuspendLayout();
            this.gbOrderType.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbPanelLFooter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvOrderList.Size = new System.Drawing.Size(753, 450);
            this.dgvOrderList.TabIndex = 0;
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
            this.gbReviewBill.Size = new System.Drawing.Size(429, 476);
            this.gbReviewBill.TabIndex = 1;
            this.gbReviewBill.TabStop = false;
            this.gbReviewBill.Text = "Review Bill";
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AllowUserToAddRows = false;
            this.dgvOrderDetailsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvOrderDetailsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetailsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrderDetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailsList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetailsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderDetailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvOrderDetailsList.RowTemplate.Height = 24;
            this.dgvOrderDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(423, 450);
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
            this.gbRecentRecord.Size = new System.Drawing.Size(759, 476);
            this.gbRecentRecord.TabIndex = 0;
            this.gbRecentRecord.TabStop = false;
            this.gbRecentRecord.Text = "Recent Orders";
            // 
            // tableOrderList
            // 
            this.tableOrderList.ColumnCount = 2;
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.83333F));
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.16667F));
            this.tableOrderList.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableOrderList.Controls.Add(this.gbRecentRecord, 0, 0);
            this.tableOrderList.Controls.Add(this.gbReviewBill, 1, 0);
            this.tableOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOrderList.Location = new System.Drawing.Point(0, 87);
            this.tableOrderList.Name = "tableOrderList";
            this.tableOrderList.RowCount = 2;
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableOrderList.Size = new System.Drawing.Size(1200, 535);
            this.tableOrderList.TabIndex = 11;
            // 
            // tableOption
            // 
            this.tableOption.ColumnCount = 5;
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75548F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71838F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.20067F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.03204F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.20911F));
            this.tableOption.Controls.Add(this.gbDateFrom, 0, 0);
            this.tableOption.Controls.Add(this.gbDateTo, 0, 0);
            this.tableOption.Controls.Add(this.gbOrderType, 0, 0);
            this.tableOption.Controls.Add(this.gpSearch, 0, 0);
            this.tableOption.Controls.Add(this.gbOptions, 4, 0);
            this.tableOption.Controls.Add(this.lbErrorMessage, 1, 1);
            this.tableOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableOption.Location = new System.Drawing.Point(0, 0);
            this.tableOption.Name = "tableOption";
            this.tableOption.RowCount = 2;
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableOption.Size = new System.Drawing.Size(1200, 87);
            this.tableOption.TabIndex = 10;
            // 
            // gbDateFrom
            // 
            this.gbDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateFrom.Controls.Add(this.datePickerFrom);
            this.gbDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateFrom.Location = new System.Drawing.Point(404, 3);
            this.gbDateFrom.Name = "gbDateFrom";
            this.gbDateFrom.Size = new System.Drawing.Size(200, 58);
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
            this.datePickerFrom.CustomFormat = "dd/mm/yyyy";
            this.datePickerFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFrom.Location = new System.Drawing.Point(0, 23);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(194, 29);
            this.datePickerFrom.TabIndex = 0;
            // 
            // gbDateTo
            // 
            this.gbDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateTo.Controls.Add(this.datePickerTo);
            this.gbDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateTo.Location = new System.Drawing.Point(610, 3);
            this.gbDateTo.Name = "gbDateTo";
            this.gbDateTo.Size = new System.Drawing.Size(198, 58);
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
            this.datePickerTo.CustomFormat = "dd/mm/yyyy";
            this.datePickerTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerTo.Location = new System.Drawing.Point(0, 23);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(192, 29);
            this.datePickerTo.TabIndex = 0;
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
            this.gbOrderType.Size = new System.Drawing.Size(171, 58);
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
            this.cbOrderType.Size = new System.Drawing.Size(159, 31);
            this.cbOrderType.TabIndex = 0;
            // 
            // gpSearch
            // 
            this.gpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpSearch.Location = new System.Drawing.Point(180, 3);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(218, 58);
            this.gpSearch.TabIndex = 8;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "# Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.tableLayoutPanel1);
            this.gbOptions.Location = new System.Drawing.Point(814, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(383, 58);
            this.gbOptions.TabIndex = 12;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Option";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 32);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btnRefresh.Location = new System.Drawing.Point(253, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 26);
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
            this.btnEdit.Location = new System.Drawing.Point(128, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 26);
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
            this.btnNew.Size = new System.Drawing.Size(119, 26);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // tbPanelLFooter
            // 
            this.tbPanelLFooter.BackColor = System.Drawing.Color.Navy;
            this.tbPanelLFooter.ColumnCount = 3;
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.39233F));
            this.tbPanelLFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelLFooter.Controls.Add(this.label1, 1, 0);
            this.tbPanelLFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPanelLFooter.Location = new System.Drawing.Point(0, 622);
            this.tbPanelLFooter.Name = "tbPanelLFooter";
            this.tbPanelLFooter.RowCount = 1;
            this.tbPanelLFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanelLFooter.Size = new System.Drawing.Size(1200, 18);
            this.tbPanelLFooter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbErrorMessage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorMessage.Location = new System.Drawing.Point(180, 64);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(132, 20);
            this.lbErrorMessage.TabIndex = 13;
            this.lbErrorMessage.Text = "This Order is Empty";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.24506F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.75494F));
            this.tableLayoutPanel2.Controls.Add(this.txtTotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTotal, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 485);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(759, 47);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(354, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(402, 43);
            this.txtTotal.TabIndex = 0;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(3, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(89, 37);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderListModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.tableOrderList);
            this.Controls.Add(this.tableOption);
            this.Controls.Add(this.tbPanelLFooter);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderListModule";
            this.Text = "OrderModule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.gbReviewBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).EndInit();
            this.gbRecentRecord.ResumeLayout(false);
            this.tableOrderList.ResumeLayout(false);
            this.tableOption.ResumeLayout(false);
            this.tableOption.PerformLayout();
            this.gbDateFrom.ResumeLayout(false);
            this.gbDateTo.ResumeLayout(false);
            this.gbOrderType.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbPanelLFooter.ResumeLayout(false);
            this.tbPanelLFooter.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.GroupBox gbReviewBill;
        private System.Windows.Forms.DataGridView dgvOrderDetailsList;
        private System.Windows.Forms.GroupBox gbRecentRecord;
        private System.Windows.Forms.TableLayoutPanel tableOrderList;
        private System.Windows.Forms.TableLayoutPanel tableOption;
        private System.Windows.Forms.GroupBox gbDateFrom;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.GroupBox gbDateTo;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.GroupBox gbOrderType;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TableLayoutPanel tbPanelLFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown txtTotal;
        private System.Windows.Forms.Label lbTotal;
    }
}