
namespace SCR
{
    partial class formDataSetting
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCreat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(768, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbList
            // 
            this.cbList.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbList.FormattingEnabled = true;
            this.cbList.Items.AddRange(new object[] {
            "員工名單",
            "菜單分類",
            "菜單資料"});
            this.cbList.Location = new System.Drawing.Point(16, 15);
            this.cbList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(176, 34);
            this.cbList.TabIndex = 1;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.cbList_SelectedIndexChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("標楷體", 16F);
            this.btUpdate.Location = new System.Drawing.Point(652, 65);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(135, 42);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btCreat
            // 
            this.btCreat.Font = new System.Drawing.Font("標楷體", 16F);
            this.btCreat.Location = new System.Drawing.Point(652, 15);
            this.btCreat.Margin = new System.Windows.Forms.Padding(4);
            this.btCreat.Name = "btCreat";
            this.btCreat.Size = new System.Drawing.Size(135, 42);
            this.btCreat.TabIndex = 4;
            this.btCreat.Text = "新增";
            this.btCreat.UseVisualStyleBackColor = true;
            // 
            // formDataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btCreat);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cbList);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formDataSetting";
            this.Text = "formDataSetting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCreat;
    }
}