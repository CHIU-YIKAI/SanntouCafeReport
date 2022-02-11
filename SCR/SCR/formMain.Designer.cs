
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
            this.SuspendLayout();
            // 
            // laMainTitle
            // 
            this.laMainTitle.AutoSize = true;
            this.laMainTitle.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laMainTitle.Location = new System.Drawing.Point(231, 9);
            this.laMainTitle.Name = "laMainTitle";
            this.laMainTitle.Size = new System.Drawing.Size(265, 60);
            this.laMainTitle.TabIndex = 0;
            this.laMainTitle.Text = "香頭咖啡";
            // 
            // btInputData
            // 
            this.btInputData.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btInputData.Location = new System.Drawing.Point(231, 127);
            this.btInputData.Name = "btInputData";
            this.btInputData.Size = new System.Drawing.Size(265, 60);
            this.btInputData.TabIndex = 1;
            this.btInputData.Text = "輸入資料";
            this.btInputData.UseVisualStyleBackColor = true;
            // 
            // btOutptReport
            // 
            this.btOutptReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btOutptReport.Location = new System.Drawing.Point(231, 243);
            this.btOutptReport.Name = "btOutptReport";
            this.btOutptReport.Size = new System.Drawing.Size(265, 61);
            this.btOutptReport.TabIndex = 2;
            this.btOutptReport.Text = "輸出報表";
            this.btOutptReport.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 357);
            this.Controls.Add(this.btOutptReport);
            this.Controls.Add(this.btInputData);
            this.Controls.Add(this.laMainTitle);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laMainTitle;
        private System.Windows.Forms.Button btInputData;
        private System.Windows.Forms.Button btOutptReport;
    }
}

