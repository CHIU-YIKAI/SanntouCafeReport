
namespace SCR
{
    partial class formMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.laMainTitle = new System.Windows.Forms.Label();
            this.btInputData = new System.Windows.Forms.Button();
            this.btOutptReport = new System.Windows.Forms.Button();
            this.btDataSetting = new System.Windows.Forms.Button();
            this.btExpensesData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laMainTitle
            // 
            this.laMainTitle.AutoSize = true;
            this.laMainTitle.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laMainTitle.Location = new System.Drawing.Point(173, 7);
            this.laMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMainTitle.Name = "laMainTitle";
            this.laMainTitle.Size = new System.Drawing.Size(212, 48);
            this.laMainTitle.TabIndex = 0;
            this.laMainTitle.Text = "香投咖啡";
            // 
            // btInputData
            // 
            this.btInputData.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btInputData.Location = new System.Drawing.Point(173, 102);
            this.btInputData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInputData.Name = "btInputData";
            this.btInputData.Size = new System.Drawing.Size(199, 48);
            this.btInputData.TabIndex = 1;
            this.btInputData.Text = "輸入點餐資料";
            this.btInputData.UseVisualStyleBackColor = true;
            this.btInputData.Click += new System.EventHandler(this.btInputData_Click);
            // 
            // btOutptReport
            // 
            this.btOutptReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btOutptReport.Location = new System.Drawing.Point(173, 226);
            this.btOutptReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOutptReport.Name = "btOutptReport";
            this.btOutptReport.Size = new System.Drawing.Size(199, 49);
            this.btOutptReport.TabIndex = 2;
            this.btOutptReport.Text = "輸出報表";
            this.btOutptReport.UseVisualStyleBackColor = true;
            this.btOutptReport.Click += new System.EventHandler(this.btOutptReport_Click);
            // 
            // btDataSetting
            // 
            this.btDataSetting.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btDataSetting.Location = new System.Drawing.Point(173, 289);
            this.btDataSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDataSetting.Name = "btDataSetting";
            this.btDataSetting.Size = new System.Drawing.Size(199, 48);
            this.btDataSetting.TabIndex = 3;
            this.btDataSetting.Text = "資料設定";
            this.btDataSetting.UseVisualStyleBackColor = true;
            this.btDataSetting.Click += new System.EventHandler(this.btDataSetting_Click);
            // 
            // btExpensesData
            // 
            this.btExpensesData.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btExpensesData.Location = new System.Drawing.Point(173, 163);
            this.btExpensesData.Margin = new System.Windows.Forms.Padding(2);
            this.btExpensesData.Name = "btExpensesData";
            this.btExpensesData.Size = new System.Drawing.Size(199, 49);
            this.btExpensesData.TabIndex = 4;
            this.btExpensesData.Text = "輸出報表";
            this.btExpensesData.UseVisualStyleBackColor = true;
            this.btExpensesData.Click += new System.EventHandler(this.btExpensesData_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 359);
            this.Controls.Add(this.btExpensesData);
            this.Controls.Add(this.btDataSetting);
            this.Controls.Add(this.btOutptReport);
            this.Controls.Add(this.btInputData);
            this.Controls.Add(this.laMainTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laMainTitle;
        private System.Windows.Forms.Button btInputData;
        private System.Windows.Forms.Button btOutptReport;
        private System.Windows.Forms.Button btDataSetting;
        private System.Windows.Forms.Button btExpensesData;
    }
}

