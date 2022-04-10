
namespace SCR
{
    partial class formOutputReport
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
            this.btCheckoutReport = new System.Windows.Forms.Button();
            this.btPersonReport = new System.Windows.Forms.Button();
            this.btDishesReport = new System.Windows.Forms.Button();
            this.btExpencesReport = new System.Windows.Forms.Button();
            this.btAllReport = new System.Windows.Forms.Button();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.tpStartTime = new System.Windows.Forms.DateTimePicker();
            this.tpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btCheckoutReport
            // 
            this.btCheckoutReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btCheckoutReport.Location = new System.Drawing.Point(295, 30);
            this.btCheckoutReport.Margin = new System.Windows.Forms.Padding(2);
            this.btCheckoutReport.Name = "btCheckoutReport";
            this.btCheckoutReport.Size = new System.Drawing.Size(199, 49);
            this.btCheckoutReport.TabIndex = 3;
            this.btCheckoutReport.Text = "產生點單報表";
            this.btCheckoutReport.UseVisualStyleBackColor = true;
            // 
            // btPersonReport
            // 
            this.btPersonReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btPersonReport.Location = new System.Drawing.Point(295, 92);
            this.btPersonReport.Margin = new System.Windows.Forms.Padding(2);
            this.btPersonReport.Name = "btPersonReport";
            this.btPersonReport.Size = new System.Drawing.Size(199, 49);
            this.btPersonReport.TabIndex = 4;
            this.btPersonReport.Text = "產生人流報表";
            this.btPersonReport.UseVisualStyleBackColor = true;
            // 
            // btDishesReport
            // 
            this.btDishesReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btDishesReport.Location = new System.Drawing.Point(295, 155);
            this.btDishesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btDishesReport.Name = "btDishesReport";
            this.btDishesReport.Size = new System.Drawing.Size(199, 49);
            this.btDishesReport.TabIndex = 5;
            this.btDishesReport.Text = "產生餐點報表";
            this.btDishesReport.UseVisualStyleBackColor = true;
            // 
            // btExpencesReport
            // 
            this.btExpencesReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btExpencesReport.Location = new System.Drawing.Point(295, 219);
            this.btExpencesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btExpencesReport.Name = "btExpencesReport";
            this.btExpencesReport.Size = new System.Drawing.Size(199, 49);
            this.btExpencesReport.TabIndex = 6;
            this.btExpencesReport.Text = "產生支出報表";
            this.btExpencesReport.UseVisualStyleBackColor = true;
            // 
            // btAllReport
            // 
            this.btAllReport.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btAllReport.Location = new System.Drawing.Point(295, 284);
            this.btAllReport.Margin = new System.Windows.Forms.Padding(2);
            this.btAllReport.Name = "btAllReport";
            this.btAllReport.Size = new System.Drawing.Size(199, 49);
            this.btAllReport.TabIndex = 7;
            this.btAllReport.Text = "產生總報表";
            this.btAllReport.UseVisualStyleBackColor = true;
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbStartTime.Location = new System.Drawing.Point(12, 42);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(106, 24);
            this.lbStartTime.TabIndex = 8;
            this.lbStartTime.Text = "起始日期";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.lbEndTime.Location = new System.Drawing.Point(12, 128);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(106, 24);
            this.lbEndTime.TabIndex = 9;
            this.lbEndTime.Text = "結束日期";
            // 
            // tpStartTime
            // 
            this.tpStartTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.tpStartTime.Location = new System.Drawing.Point(56, 69);
            this.tpStartTime.Name = "tpStartTime";
            this.tpStartTime.Size = new System.Drawing.Size(184, 36);
            this.tpStartTime.TabIndex = 10;
            // 
            // tpEndTime
            // 
            this.tpEndTime.Font = new System.Drawing.Font("標楷體", 18F);
            this.tpEndTime.Location = new System.Drawing.Point(56, 155);
            this.tpEndTime.Name = "tpEndTime";
            this.tpEndTime.Size = new System.Drawing.Size(184, 36);
            this.tpEndTime.TabIndex = 11;
            // 
            // formOutputReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tpEndTime);
            this.Controls.Add(this.tpStartTime);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.btAllReport);
            this.Controls.Add(this.btExpencesReport);
            this.Controls.Add(this.btDishesReport);
            this.Controls.Add(this.btPersonReport);
            this.Controls.Add(this.btCheckoutReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formOutputReport";
            this.Text = "formOutputReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheckoutReport;
        private System.Windows.Forms.Button btPersonReport;
        private System.Windows.Forms.Button btDishesReport;
        private System.Windows.Forms.Button btExpencesReport;
        private System.Windows.Forms.Button btAllReport;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.DateTimePicker tpStartTime;
        private System.Windows.Forms.DateTimePicker tpEndTime;
    }
}