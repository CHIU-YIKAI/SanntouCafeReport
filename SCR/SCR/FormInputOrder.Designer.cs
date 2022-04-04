
namespace SCR
{
    partial class FormInputOrder
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
            this.cbReceptionist = new System.Windows.Forms.ComboBox();
            this.lbIdea = new System.Windows.Forms.Label();
            this.lbReceptionist = new System.Windows.Forms.Label();
            this.tbRealityPrice = new System.Windows.Forms.TextBox();
            this.lbRealityPrice = new System.Windows.Forms.Label();
            this.tbOrignPrice = new System.Windows.Forms.TextBox();
            this.lbOrignPrice = new System.Windows.Forms.Label();
            this.lbPeopleCount = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbIdea = new System.Windows.Forms.RichTextBox();
            this.lbOrderTime = new System.Windows.Forms.Label();
            this.lbDishCount = new System.Windows.Forms.Label();
            this.lbDishName = new System.Windows.Forms.Label();
            this.lbDishGroup = new System.Windows.Forms.Label();
            this.tpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.cbDishName = new System.Windows.Forms.ComboBox();
            this.cbDishGroup = new System.Windows.Forms.ComboBox();
            this.btWriteOrder = new System.Windows.Forms.Button();
            this.btSaveAll = new System.Windows.Forms.Button();
            this.lbOrderInformation = new System.Windows.Forms.Label();
            this.tbDishCount = new System.Windows.Forms.NumericUpDown();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.orderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orignPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPeopleCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbDishCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeopleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbReceptionist
            // 
            this.cbReceptionist.Font = new System.Drawing.Font("標楷體", 18F);
            this.cbReceptionist.FormattingEnabled = true;
            this.cbReceptionist.Location = new System.Drawing.Point(121, 226);
            this.cbReceptionist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbReceptionist.Name = "cbReceptionist";
            this.cbReceptionist.Size = new System.Drawing.Size(154, 32);
            this.cbReceptionist.TabIndex = 32;
            // 
            // lbIdea
            // 
            this.lbIdea.AutoSize = true;
            this.lbIdea.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbIdea.Location = new System.Drawing.Point(11, 284);
            this.lbIdea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdea.Name = "lbIdea";
            this.lbIdea.Size = new System.Drawing.Size(106, 24);
            this.lbIdea.TabIndex = 30;
            this.lbIdea.Text = "回饋意見";
            // 
            // lbReceptionist
            // 
            this.lbReceptionist.AutoSize = true;
            this.lbReceptionist.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbReceptionist.Location = new System.Drawing.Point(11, 231);
            this.lbReceptionist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReceptionist.Name = "lbReceptionist";
            this.lbReceptionist.Size = new System.Drawing.Size(106, 24);
            this.lbReceptionist.TabIndex = 29;
            this.lbReceptionist.Text = "接待人員";
            // 
            // tbRealityPrice
            // 
            this.tbRealityPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbRealityPrice.Location = new System.Drawing.Point(121, 168);
            this.tbRealityPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRealityPrice.Name = "tbRealityPrice";
            this.tbRealityPrice.Size = new System.Drawing.Size(154, 36);
            this.tbRealityPrice.TabIndex = 28;
            // 
            // lbRealityPrice
            // 
            this.lbRealityPrice.AutoSize = true;
            this.lbRealityPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbRealityPrice.Location = new System.Drawing.Point(11, 178);
            this.lbRealityPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRealityPrice.Name = "lbRealityPrice";
            this.lbRealityPrice.Size = new System.Drawing.Size(106, 24);
            this.lbRealityPrice.TabIndex = 27;
            this.lbRealityPrice.Text = "實收金額";
            // 
            // tbOrignPrice
            // 
            this.tbOrignPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbOrignPrice.Location = new System.Drawing.Point(121, 115);
            this.tbOrignPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrignPrice.Name = "tbOrignPrice";
            this.tbOrignPrice.ReadOnly = true;
            this.tbOrignPrice.Size = new System.Drawing.Size(154, 36);
            this.tbOrignPrice.TabIndex = 26;
            this.tbOrignPrice.Text = "0";
            // 
            // lbOrignPrice
            // 
            this.lbOrignPrice.AutoSize = true;
            this.lbOrignPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbOrignPrice.Location = new System.Drawing.Point(11, 126);
            this.lbOrignPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrignPrice.Name = "lbOrignPrice";
            this.lbOrignPrice.Size = new System.Drawing.Size(106, 24);
            this.lbOrignPrice.TabIndex = 25;
            this.lbOrignPrice.Text = "原始金額";
            // 
            // lbPeopleCount
            // 
            this.lbPeopleCount.AutoSize = true;
            this.lbPeopleCount.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbPeopleCount.Location = new System.Drawing.Point(11, 73);
            this.lbPeopleCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeopleCount.Name = "lbPeopleCount";
            this.lbPeopleCount.Size = new System.Drawing.Size(106, 24);
            this.lbPeopleCount.TabIndex = 23;
            this.lbPeopleCount.Text = "同行人數";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbCustomerName.Location = new System.Drawing.Point(121, 10);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(154, 36);
            this.tbCustomerName.TabIndex = 22;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbCustomerName.Location = new System.Drawing.Point(11, 20);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(106, 24);
            this.lbCustomerName.TabIndex = 21;
            this.lbCustomerName.Text = "顧客名稱";
            // 
            // tbIdea
            // 
            this.tbIdea.Font = new System.Drawing.Font("標楷體", 12F);
            this.tbIdea.Location = new System.Drawing.Point(121, 274);
            this.tbIdea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdea.Name = "tbIdea";
            this.tbIdea.Size = new System.Drawing.Size(154, 178);
            this.tbIdea.TabIndex = 33;
            this.tbIdea.Text = "";
            // 
            // lbOrderTime
            // 
            this.lbOrderTime.AutoSize = true;
            this.lbOrderTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbOrderTime.Location = new System.Drawing.Point(294, 65);
            this.lbOrderTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderTime.Name = "lbOrderTime";
            this.lbOrderTime.Size = new System.Drawing.Size(106, 24);
            this.lbOrderTime.TabIndex = 40;
            this.lbOrderTime.Text = "點餐時間";
            // 
            // lbDishCount
            // 
            this.lbDishCount.AutoSize = true;
            this.lbDishCount.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbDishCount.Location = new System.Drawing.Point(291, 227);
            this.lbDishCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDishCount.Name = "lbDishCount";
            this.lbDishCount.Size = new System.Drawing.Size(106, 24);
            this.lbDishCount.TabIndex = 38;
            this.lbDishCount.Text = "餐點數量";
            // 
            // lbDishName
            // 
            this.lbDishName.AutoSize = true;
            this.lbDishName.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbDishName.Location = new System.Drawing.Point(291, 174);
            this.lbDishName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDishName.Name = "lbDishName";
            this.lbDishName.Size = new System.Drawing.Size(106, 24);
            this.lbDishName.TabIndex = 36;
            this.lbDishName.Text = "餐點名稱";
            // 
            // lbDishGroup
            // 
            this.lbDishGroup.AutoSize = true;
            this.lbDishGroup.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbDishGroup.Location = new System.Drawing.Point(291, 122);
            this.lbDishGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDishGroup.Name = "lbDishGroup";
            this.lbDishGroup.Size = new System.Drawing.Size(106, 24);
            this.lbDishGroup.TabIndex = 34;
            this.lbDishGroup.Text = "餐點分類";
            // 
            // tpOrderTime
            // 
            this.tpOrderTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.tpOrderTime.Font = new System.Drawing.Font("新細明體", 14F);
            this.tpOrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpOrderTime.Location = new System.Drawing.Point(400, 63);
            this.tpOrderTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpOrderTime.Name = "tpOrderTime";
            this.tpOrderTime.Size = new System.Drawing.Size(179, 30);
            this.tpOrderTime.TabIndex = 42;
            // 
            // cbDishName
            // 
            this.cbDishName.Enabled = false;
            this.cbDishName.Font = new System.Drawing.Font("標楷體", 18F);
            this.cbDishName.FormattingEnabled = true;
            this.cbDishName.Location = new System.Drawing.Point(400, 168);
            this.cbDishName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDishName.Name = "cbDishName";
            this.cbDishName.Size = new System.Drawing.Size(176, 32);
            this.cbDishName.TabIndex = 43;
            // 
            // cbDishGroup
            // 
            this.cbDishGroup.Font = new System.Drawing.Font("標楷體", 18F);
            this.cbDishGroup.FormattingEnabled = true;
            this.cbDishGroup.Location = new System.Drawing.Point(400, 115);
            this.cbDishGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDishGroup.Name = "cbDishGroup";
            this.cbDishGroup.Size = new System.Drawing.Size(176, 32);
            this.cbDishGroup.TabIndex = 44;
            this.cbDishGroup.SelectedIndexChanged += new System.EventHandler(this.cbDishGroup_SelectedIndexChanged);
            // 
            // btWriteOrder
            // 
            this.btWriteOrder.Font = new System.Drawing.Font("標楷體", 18F);
            this.btWriteOrder.Location = new System.Drawing.Point(298, 307);
            this.btWriteOrder.Name = "btWriteOrder";
            this.btWriteOrder.Size = new System.Drawing.Size(281, 54);
            this.btWriteOrder.TabIndex = 45;
            this.btWriteOrder.Text = "寫入點餐資訊";
            this.btWriteOrder.UseVisualStyleBackColor = true;
            this.btWriteOrder.Click += new System.EventHandler(this.btWriteOrder_Click);
            // 
            // btSaveAll
            // 
            this.btSaveAll.Font = new System.Drawing.Font("標楷體", 18F);
            this.btSaveAll.Location = new System.Drawing.Point(298, 387);
            this.btSaveAll.Name = "btSaveAll";
            this.btSaveAll.Size = new System.Drawing.Size(281, 62);
            this.btSaveAll.TabIndex = 46;
            this.btSaveAll.Text = "儲存";
            this.btSaveAll.UseVisualStyleBackColor = true;
            this.btSaveAll.Click += new System.EventHandler(this.btSaveAll_Click);
            // 
            // lbOrderInformation
            // 
            this.lbOrderInformation.AutoSize = true;
            this.lbOrderInformation.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbOrderInformation.Location = new System.Drawing.Point(678, 12);
            this.lbOrderInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrderInformation.Name = "lbOrderInformation";
            this.lbOrderInformation.Size = new System.Drawing.Size(154, 24);
            this.lbOrderInformation.TabIndex = 48;
            this.lbOrderInformation.Text = "檢視點餐資訊";
            // 
            // tbDishCount
            // 
            this.tbDishCount.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbDishCount.Location = new System.Drawing.Point(400, 217);
            this.tbDishCount.Name = "tbDishCount";
            this.tbDishCount.Size = new System.Drawing.Size(176, 36);
            this.tbDishCount.TabIndex = 49;
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.AllowUserToAddRows = false;
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderTime,
            this.dishesName,
            this.dishesCount,
            this.orignPrice});
            this.dgvOrderData.Location = new System.Drawing.Point(598, 39);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.RowHeadersVisible = false;
            this.dgvOrderData.RowHeadersWidth = 51;
            this.dgvOrderData.RowTemplate.Height = 24;
            this.dgvOrderData.Size = new System.Drawing.Size(310, 410);
            this.dgvOrderData.TabIndex = 50;
            this.dgvOrderData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderData_CellEndEdit);
            // 
            // orderTime
            // 
            this.orderTime.HeaderText = "點餐時間";
            this.orderTime.MinimumWidth = 6;
            this.orderTime.Name = "orderTime";
            this.orderTime.Width = 125;
            // 
            // dishesName
            // 
            this.dishesName.HeaderText = "餐點名稱";
            this.dishesName.MinimumWidth = 6;
            this.dishesName.Name = "dishesName";
            this.dishesName.Width = 125;
            // 
            // dishesCount
            // 
            this.dishesCount.HeaderText = "數量";
            this.dishesCount.MinimumWidth = 6;
            this.dishesCount.Name = "dishesCount";
            this.dishesCount.Width = 125;
            // 
            // orignPrice
            // 
            this.orignPrice.HeaderText = "OrignPrice";
            this.orignPrice.MinimumWidth = 6;
            this.orignPrice.Name = "orignPrice";
            this.orignPrice.Visible = false;
            this.orignPrice.Width = 125;
            // 
            // tbPeopleCount
            // 
            this.tbPeopleCount.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbPeopleCount.Location = new System.Drawing.Point(121, 65);
            this.tbPeopleCount.Name = "tbPeopleCount";
            this.tbPeopleCount.Size = new System.Drawing.Size(154, 36);
            this.tbPeopleCount.TabIndex = 51;
            // 
            // FormInputOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 461);
            this.Controls.Add(this.tbPeopleCount);
            this.Controls.Add(this.dgvOrderData);
            this.Controls.Add(this.tbDishCount);
            this.Controls.Add(this.lbOrderInformation);
            this.Controls.Add(this.btSaveAll);
            this.Controls.Add(this.btWriteOrder);
            this.Controls.Add(this.cbDishGroup);
            this.Controls.Add(this.cbDishName);
            this.Controls.Add(this.tpOrderTime);
            this.Controls.Add(this.lbOrderTime);
            this.Controls.Add(this.lbDishCount);
            this.Controls.Add(this.lbDishName);
            this.Controls.Add(this.lbDishGroup);
            this.Controls.Add(this.tbIdea);
            this.Controls.Add(this.cbReceptionist);
            this.Controls.Add(this.lbIdea);
            this.Controls.Add(this.lbReceptionist);
            this.Controls.Add(this.tbRealityPrice);
            this.Controls.Add(this.lbRealityPrice);
            this.Controls.Add(this.tbOrignPrice);
            this.Controls.Add(this.lbOrignPrice);
            this.Controls.Add(this.lbPeopleCount);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lbCustomerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInputOrder";
            this.Text = "FormInputOrder";
            this.Load += new System.EventHandler(this.loadForm);
            ((System.ComponentModel.ISupportInitialize)(this.tbDishCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPeopleCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbReceptionist;
        private System.Windows.Forms.Label lbIdea;
        private System.Windows.Forms.Label lbReceptionist;
        private System.Windows.Forms.TextBox tbRealityPrice;
        private System.Windows.Forms.Label lbRealityPrice;
        private System.Windows.Forms.TextBox tbOrignPrice;
        private System.Windows.Forms.Label lbOrignPrice;
        private System.Windows.Forms.Label lbPeopleCount;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.RichTextBox tbIdea;
        private System.Windows.Forms.Label lbOrderTime;
        private System.Windows.Forms.Label lbDishCount;
        private System.Windows.Forms.Label lbDishName;
        private System.Windows.Forms.Label lbDishGroup;
        private System.Windows.Forms.DateTimePicker tpOrderTime;
        private System.Windows.Forms.ComboBox cbDishName;
        private System.Windows.Forms.ComboBox cbDishGroup;
        private System.Windows.Forms.Button btWriteOrder;
        private System.Windows.Forms.Button btSaveAll;
        private System.Windows.Forms.Label lbOrderInformation;
        private System.Windows.Forms.NumericUpDown tbDishCount;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn orignPrice;
        private System.Windows.Forms.NumericUpDown tbPeopleCount;
    }
}