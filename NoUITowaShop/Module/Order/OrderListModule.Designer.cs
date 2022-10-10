
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
            this.tabOrderList = new System.Windows.Forms.TabPage();
            this.tableOrderList = new System.Windows.Forms.TableLayoutPanel();
            this.gbRecentRecord = new System.Windows.Forms.GroupBox();
            this.gbReviewBill = new System.Windows.Forms.GroupBox();
            this.tableOption = new System.Windows.Forms.TableLayoutPanel();
            this.gbDateFrom = new System.Windows.Forms.GroupBox();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.gbDateTo = new System.Windows.Forms.GroupBox();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.gbOrderType = new System.Windows.Forms.GroupBox();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbPanelLFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tbPanelList = new System.Windows.Forms.TableLayoutPanel();
            this.tabOrders = new System.Windows.Forms.TabControl();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetailsList = new System.Windows.Forms.DataGridView();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabOrderDetails = new System.Windows.Forms.TabPage();
            this.tabOrderList.SuspendLayout();
            this.tableOrderList.SuspendLayout();
            this.gbRecentRecord.SuspendLayout();
            this.gbReviewBill.SuspendLayout();
            this.tableOption.SuspendLayout();
            this.gbDateFrom.SuspendLayout();
            this.gbDateTo.SuspendLayout();
            this.gbOrderType.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrderList
            // 
            this.tabOrderList.Controls.Add(this.tableOrderList);
            this.tabOrderList.Controls.Add(this.tableOption);
            this.tabOrderList.Controls.Add(this.tbPanelLFooter);
            this.tabOrderList.Controls.Add(this.tbPanelList);
            this.tabOrderList.Location = new System.Drawing.Point(4, 29);
            this.tabOrderList.Name = "tabOrderList";
            this.tabOrderList.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderList.Size = new System.Drawing.Size(1192, 607);
            this.tabOrderList.TabIndex = 0;
            this.tabOrderList.Text = "Order List";
            this.tabOrderList.UseVisualStyleBackColor = true;
            // 
            // tableOrderList
            // 
            this.tableOrderList.ColumnCount = 2;
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.62395F));
            this.tableOrderList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.37605F));
            this.tableOrderList.Controls.Add(this.gbRecentRecord, 0, 0);
            this.tableOrderList.Controls.Add(this.gbReviewBill, 1, 0);
            this.tableOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOrderList.Location = new System.Drawing.Point(3, 99);
            this.tableOrderList.Name = "tableOrderList";
            this.tableOrderList.RowCount = 2;
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOrderList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableOrderList.Size = new System.Drawing.Size(1186, 471);
            this.tableOrderList.TabIndex = 7;
            // 
            // gbRecentRecord
            // 
            this.gbRecentRecord.Controls.Add(this.dgvOrderList);
            this.gbRecentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecentRecord.Location = new System.Drawing.Point(3, 3);
            this.gbRecentRecord.Name = "gbRecentRecord";
            this.gbRecentRecord.Size = new System.Drawing.Size(713, 436);
            this.gbRecentRecord.TabIndex = 0;
            this.gbRecentRecord.TabStop = false;
            this.gbRecentRecord.Text = "Recent Orders";
            // 
            // gbReviewBill
            // 
            this.gbReviewBill.Controls.Add(this.dgvOrderDetailsList);
            this.gbReviewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReviewBill.Location = new System.Drawing.Point(722, 3);
            this.gbReviewBill.Name = "gbReviewBill";
            this.gbReviewBill.Size = new System.Drawing.Size(461, 436);
            this.gbReviewBill.TabIndex = 1;
            this.gbReviewBill.TabStop = false;
            this.gbReviewBill.Text = "Review Bill";
            // 
            // tableOption
            // 
            this.tableOption.ColumnCount = 5;
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78882F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83883F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.97968F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.26918F));
            this.tableOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.12349F));
            this.tableOption.Controls.Add(this.gbDateFrom, 0, 0);
            this.tableOption.Controls.Add(this.gbDateTo, 0, 0);
            this.tableOption.Controls.Add(this.gbOrderType, 0, 0);
            this.tableOption.Controls.Add(this.gpSearch, 0, 0);
            this.tableOption.Controls.Add(this.gbOptions, 4, 0);
            this.tableOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableOption.Location = new System.Drawing.Point(3, 34);
            this.tableOption.Name = "tableOption";
            this.tableOption.RowCount = 1;
            this.tableOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOption.Size = new System.Drawing.Size(1186, 65);
            this.tableOption.TabIndex = 6;
            // 
            // gbDateFrom
            // 
            this.gbDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateFrom.Controls.Add(this.datePickerFrom);
            this.gbDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateFrom.Location = new System.Drawing.Point(507, 3);
            this.gbDateFrom.Name = "gbDateFrom";
            this.gbDateFrom.Size = new System.Drawing.Size(207, 59);
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
            this.datePickerFrom.Size = new System.Drawing.Size(201, 29);
            this.datePickerFrom.TabIndex = 0;
            // 
            // gbDateTo
            // 
            this.gbDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDateTo.Controls.Add(this.datePickerTo);
            this.gbDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDateTo.Location = new System.Drawing.Point(720, 3);
            this.gbDateTo.Name = "gbDateTo";
            this.gbDateTo.Size = new System.Drawing.Size(175, 59);
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
            this.datePickerTo.Size = new System.Drawing.Size(169, 29);
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
            this.gbOrderType.Size = new System.Drawing.Size(311, 59);
            this.gbOrderType.TabIndex = 9;
            this.gbOrderType.TabStop = false;
            this.gbOrderType.Text = "# Order type:";
            // 
            // cbOrderType
            // 
            this.cbOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrderType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Location = new System.Drawing.Point(6, 25);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(299, 31);
            this.cbOrderType.TabIndex = 0;
            // 
            // gpSearch
            // 
            this.gpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpSearch.Controls.Add(this.txtSearch);
            this.gpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpSearch.Location = new System.Drawing.Point(320, 3);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(181, 59);
            this.gpSearch.TabIndex = 8;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "# Order number:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 30);
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
            this.tbPanelLFooter.Location = new System.Drawing.Point(3, 570);
            this.tbPanelLFooter.Name = "tbPanelLFooter";
            this.tbPanelLFooter.RowCount = 1;
            this.tbPanelLFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanelLFooter.Size = new System.Drawing.Size(1186, 34);
            this.tbPanelLFooter.TabIndex = 5;
            // 
            // tbPanelList
            // 
            this.tbPanelList.BackColor = System.Drawing.Color.DarkBlue;
            this.tbPanelList.ColumnCount = 3;
            this.tbPanelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.39233F));
            this.tbPanelList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30383F));
            this.tbPanelList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPanelList.ForeColor = System.Drawing.SystemColors.Control;
            this.tbPanelList.Location = new System.Drawing.Point(3, 3);
            this.tbPanelList.Name = "tbPanelList";
            this.tbPanelList.RowCount = 1;
            this.tbPanelList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanelList.Size = new System.Drawing.Size(1186, 31);
            this.tbPanelList.TabIndex = 1;
            // 
            // tabOrders
            // 
            this.tabOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOrders.Controls.Add(this.tabOrderList);
            this.tabOrders.Controls.Add(this.tabOrderDetails);
            this.tabOrders.Location = new System.Drawing.Point(0, 0);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.SelectedIndex = 0;
            this.tabOrders.Size = new System.Drawing.Size(1200, 640);
            this.tabOrders.TabIndex = 1;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderList.Location = new System.Drawing.Point(3, 23);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(707, 413);
            this.dgvOrderList.TabIndex = 0;
            // 
            // dgvOrderDetailsList
            // 
            this.dgvOrderDetailsList.AllowUserToAddRows = false;
            this.dgvOrderDetailsList.AllowUserToDeleteRows = false;
            this.dgvOrderDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetailsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrderDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetailsList.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOrderDetailsList.Location = new System.Drawing.Point(3, 26);
            this.dgvOrderDetailsList.Name = "dgvOrderDetailsList";
            this.dgvOrderDetailsList.ReadOnly = true;
            this.dgvOrderDetailsList.RowHeadersWidth = 51;
            this.dgvOrderDetailsList.RowTemplate.Height = 24;
            this.dgvOrderDetailsList.Size = new System.Drawing.Size(455, 410);
            this.dgvOrderDetailsList.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.tableLayoutPanel1);
            this.gbOptions.Location = new System.Drawing.Point(901, 3);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(282, 59);
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
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 33);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.btnNew.Size = new System.Drawing.Size(85, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Add";
            this.btnNew.UseVisualStyleBackColor = false;
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
            this.btnEdit.Location = new System.Drawing.Point(94, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modify";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Sienna;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(185, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Add";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // tabOrderDetails
            // 
            this.tabOrderDetails.Location = new System.Drawing.Point(4, 29);
            this.tabOrderDetails.Name = "tabOrderDetails";
            this.tabOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderDetails.Size = new System.Drawing.Size(1192, 607);
            this.tabOrderDetails.TabIndex = 1;
            this.tabOrderDetails.Text = "Order Details";
            this.tabOrderDetails.UseVisualStyleBackColor = true;
            // 
            // OrderListModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.tabOrders);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderListModule";
            this.Text = "OrderModule";
            this.tabOrderList.ResumeLayout(false);
            this.tableOrderList.ResumeLayout(false);
            this.gbRecentRecord.ResumeLayout(false);
            this.gbReviewBill.ResumeLayout(false);
            this.tableOption.ResumeLayout(false);
            this.gbDateFrom.ResumeLayout(false);
            this.gbDateTo.ResumeLayout(false);
            this.gbOrderType.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailsList)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabOrderList;
        private System.Windows.Forms.TableLayoutPanel tableOption;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tbPanelLFooter;
        private System.Windows.Forms.TableLayoutPanel tbPanelList;
        private System.Windows.Forms.TabControl tabOrders;
        private System.Windows.Forms.GroupBox gbDateFrom;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.GroupBox gbDateTo;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.GroupBox gbOrderType;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.TableLayoutPanel tableOrderList;
        private System.Windows.Forms.GroupBox gbRecentRecord;
        private System.Windows.Forms.GroupBox gbReviewBill;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridView dgvOrderDetailsList;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabPage tabOrderDetails;
    }
}