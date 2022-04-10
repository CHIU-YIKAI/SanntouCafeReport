
namespace SCR
{
    partial class formExpenses
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
            this.btSaveData = new System.Windows.Forms.Button();
            this.lbExpensesName = new System.Windows.Forms.Label();
            this.lbExpensesPrice = new System.Windows.Forms.Label();
            this.lbExpensesTime = new System.Windows.Forms.Label();
            this.lbExpensesGroup = new System.Windows.Forms.Label();
            this.tbExpensesName = new System.Windows.Forms.TextBox();
            this.tbExpensesPrice = new System.Windows.Forms.TextBox();
            this.cbExpensesGroup = new System.Windows.Forms.ComboBox();
            this.tpExpensesTime = new System.Windows.Forms.DateTimePicker();
            this.cbWriter = new System.Windows.Forms.ComboBox();
            this.lbWriter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSaveData
            // 
            this.btSaveData.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btSaveData.Location = new System.Drawing.Point(32, 276);
            this.btSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveData.Name = "btSaveData";
            this.btSaveData.Size = new System.Drawing.Size(308, 49);
            this.btSaveData.TabIndex = 3;
            this.btSaveData.Text = "儲存資料";
            this.btSaveData.UseVisualStyleBackColor = true;
            // 
            // lbExpensesName
            // 
            this.lbExpensesName.AutoSize = true;
            this.lbExpensesName.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbExpensesName.Location = new System.Drawing.Point(28, 30);
            this.lbExpensesName.Name = "lbExpensesName";
            this.lbExpensesName.Size = new System.Drawing.Size(106, 24);
            this.lbExpensesName.TabIndex = 4;
            this.lbExpensesName.Text = "款項名稱";
            // 
            // lbExpensesPrice
            // 
            this.lbExpensesPrice.AutoSize = true;
            this.lbExpensesPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbExpensesPrice.Location = new System.Drawing.Point(28, 81);
            this.lbExpensesPrice.Name = "lbExpensesPrice";
            this.lbExpensesPrice.Size = new System.Drawing.Size(106, 24);
            this.lbExpensesPrice.TabIndex = 5;
            this.lbExpensesPrice.Text = "支出金額";
            // 
            // lbExpensesTime
            // 
            this.lbExpensesTime.AutoSize = true;
            this.lbExpensesTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbExpensesTime.Location = new System.Drawing.Point(28, 138);
            this.lbExpensesTime.Name = "lbExpensesTime";
            this.lbExpensesTime.Size = new System.Drawing.Size(106, 24);
            this.lbExpensesTime.TabIndex = 6;
            this.lbExpensesTime.Text = "支出日期";
            // 
            // lbExpensesGroup
            // 
            this.lbExpensesGroup.AutoSize = true;
            this.lbExpensesGroup.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbExpensesGroup.Location = new System.Drawing.Point(28, 184);
            this.lbExpensesGroup.Name = "lbExpensesGroup";
            this.lbExpensesGroup.Size = new System.Drawing.Size(106, 24);
            this.lbExpensesGroup.TabIndex = 7;
            this.lbExpensesGroup.Text = "款項分類";
            // 
            // tbExpensesName
            // 
            this.tbExpensesName.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbExpensesName.Location = new System.Drawing.Point(140, 27);
            this.tbExpensesName.Name = "tbExpensesName";
            this.tbExpensesName.Size = new System.Drawing.Size(200, 36);
            this.tbExpensesName.TabIndex = 8;
            // 
            // tbExpensesPrice
            // 
            this.tbExpensesPrice.Font = new System.Drawing.Font("標楷體", 18F);
            this.tbExpensesPrice.Location = new System.Drawing.Point(140, 78);
            this.tbExpensesPrice.Name = "tbExpensesPrice";
            this.tbExpensesPrice.Size = new System.Drawing.Size(200, 36);
            this.tbExpensesPrice.TabIndex = 9;
            // 
            // cbExpensesGroup
            // 
            this.cbExpensesGroup.Font = new System.Drawing.Font("標楷體", 18F);
            this.cbExpensesGroup.FormattingEnabled = true;
            this.cbExpensesGroup.Items.AddRange(new object[] {
            "員工名單",
            "菜單分類",
            "菜單資料"});
            this.cbExpensesGroup.Location = new System.Drawing.Point(140, 181);
            this.cbExpensesGroup.Name = "cbExpensesGroup";
            this.cbExpensesGroup.Size = new System.Drawing.Size(200, 32);
            this.cbExpensesGroup.TabIndex = 11;
            // 
            // tpExpensesTime
            // 
            this.tpExpensesTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.tpExpensesTime.Location = new System.Drawing.Point(140, 130);
            this.tpExpensesTime.Name = "tpExpensesTime";
            this.tpExpensesTime.Size = new System.Drawing.Size(200, 36);
            this.tpExpensesTime.TabIndex = 12;
            // 
            // cbWriter
            // 
            this.cbWriter.Font = new System.Drawing.Font("標楷體", 18F);
            this.cbWriter.FormattingEnabled = true;
            this.cbWriter.Items.AddRange(new object[] {
            "員工名單",
            "菜單分類",
            "菜單資料"});
            this.cbWriter.Location = new System.Drawing.Point(140, 229);
            this.cbWriter.Name = "cbWriter";
            this.cbWriter.Size = new System.Drawing.Size(200, 32);
            this.cbWriter.TabIndex = 14;
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbWriter.Location = new System.Drawing.Point(28, 232);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(82, 24);
            this.lbWriter.TabIndex = 13;
            this.lbWriter.Text = "填表人";
            // 
            // formExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 344);
            this.Controls.Add(this.cbWriter);
            this.Controls.Add(this.lbWriter);
            this.Controls.Add(this.tpExpensesTime);
            this.Controls.Add(this.cbExpensesGroup);
            this.Controls.Add(this.tbExpensesPrice);
            this.Controls.Add(this.tbExpensesName);
            this.Controls.Add(this.lbExpensesGroup);
            this.Controls.Add(this.lbExpensesTime);
            this.Controls.Add(this.lbExpensesPrice);
            this.Controls.Add(this.lbExpensesName);
            this.Controls.Add(this.btSaveData);
            this.Name = "formExpenses";
            this.Text = "formExpenses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSaveData;
        private System.Windows.Forms.Label lbExpensesName;
        private System.Windows.Forms.Label lbExpensesPrice;
        private System.Windows.Forms.Label lbExpensesTime;
        private System.Windows.Forms.Label lbExpensesGroup;
        private System.Windows.Forms.TextBox tbExpensesName;
        private System.Windows.Forms.TextBox tbExpensesPrice;
        private System.Windows.Forms.ComboBox cbExpensesGroup;
        private System.Windows.Forms.DateTimePicker tpExpensesTime;
        private System.Windows.Forms.ComboBox cbWriter;
        private System.Windows.Forms.Label lbWriter;
    }
}