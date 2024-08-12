namespace Dessertshop
{
    partial class Order_management
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.dateTimePicker結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker開始時間 = new System.Windows.Forms.DateTimePicker();
            this.comboBox搜尋訂單狀態 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView搜尋結果 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox修改訂單狀態 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker訂購日期 = new System.Windows.Forms.DateTimePicker();
            this.btn離開 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.btn整筆刪除 = new System.Windows.Forms.Button();
            this.listView訂單細項 = new System.Windows.Forms.ListView();
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單管理";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn搜尋);
            this.groupBox1.Controls.Add(this.dateTimePicker結束時間);
            this.groupBox1.Controls.Add(this.dateTimePicker開始時間);
            this.groupBox1.Controls.Add(this.comboBox搜尋訂單狀態);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(36, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋";
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn搜尋.Location = new System.Drawing.Point(312, 183);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(101, 49);
            this.btn搜尋.TabIndex = 36;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // dateTimePicker結束時間
            // 
            this.dateTimePicker結束時間.Location = new System.Drawing.Point(142, 79);
            this.dateTimePicker結束時間.Name = "dateTimePicker結束時間";
            this.dateTimePicker結束時間.Size = new System.Drawing.Size(271, 43);
            this.dateTimePicker結束時間.TabIndex = 5;
            // 
            // dateTimePicker開始時間
            // 
            this.dateTimePicker開始時間.Location = new System.Drawing.Point(142, 31);
            this.dateTimePicker開始時間.Name = "dateTimePicker開始時間";
            this.dateTimePicker開始時間.Size = new System.Drawing.Size(271, 43);
            this.dateTimePicker開始時間.TabIndex = 3;
            // 
            // comboBox搜尋訂單狀態
            // 
            this.comboBox搜尋訂單狀態.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox搜尋訂單狀態.FormattingEnabled = true;
            this.comboBox搜尋訂單狀態.Location = new System.Drawing.Point(142, 131);
            this.comboBox搜尋訂單狀態.Name = "comboBox搜尋訂單狀態";
            this.comboBox搜尋訂單狀態.Size = new System.Drawing.Size(271, 43);
            this.comboBox搜尋訂單狀態.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(55, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "訂單狀態";
            // 
            // listView搜尋結果
            // 
            this.listView搜尋結果.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView搜尋結果.BackColor = System.Drawing.Color.Gainsboro;
            this.listView搜尋結果.HideSelection = false;
            this.listView搜尋結果.Location = new System.Drawing.Point(36, 330);
            this.listView搜尋結果.Name = "listView搜尋結果";
            this.listView搜尋結果.Size = new System.Drawing.Size(436, 313);
            this.listView搜尋結果.TabIndex = 20;
            this.listView搜尋結果.UseCompatibleStateImageBehavior = false;
            this.listView搜尋結果.ItemActivate += new System.EventHandler(this.listView搜尋結果_ItemActivate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(556, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "訂單狀態";
            // 
            // comboBox修改訂單狀態
            // 
            this.comboBox修改訂單狀態.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox修改訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox修改訂單狀態.FormattingEnabled = true;
            this.comboBox修改訂單狀態.Location = new System.Drawing.Point(747, 155);
            this.comboBox修改訂單狀態.Name = "comboBox修改訂單狀態";
            this.comboBox修改訂單狀態.Size = new System.Drawing.Size(271, 43);
            this.comboBox修改訂單狀態.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(556, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "訂購日期";
            // 
            // dateTimePicker訂購日期
            // 
            this.dateTimePicker訂購日期.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker訂購日期.Location = new System.Drawing.Point(747, 99);
            this.dateTimePicker訂購日期.Name = "dateTimePicker訂購日期";
            this.dateTimePicker訂購日期.Size = new System.Drawing.Size(271, 43);
            this.dateTimePicker訂購日期.TabIndex = 24;
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn離開.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn離開.Location = new System.Drawing.Point(922, 23);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(96, 53);
            this.btn離開.TabIndex = 27;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn儲存修改.Location = new System.Drawing.Point(870, 590);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(148, 53);
            this.btn儲存修改.TabIndex = 28;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = false;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn整筆刪除
            // 
            this.btn整筆刪除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn整筆刪除.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn整筆刪除.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn整筆刪除.Location = new System.Drawing.Point(562, 590);
            this.btn整筆刪除.Name = "btn整筆刪除";
            this.btn整筆刪除.Size = new System.Drawing.Size(148, 53);
            this.btn整筆刪除.TabIndex = 33;
            this.btn整筆刪除.Text = "取消訂單";
            this.btn整筆刪除.UseVisualStyleBackColor = false;
            this.btn整筆刪除.Click += new System.EventHandler(this.btn整筆刪除_Click);
            // 
            // listView訂單細項
            // 
            this.listView訂單細項.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView訂單細項.BackColor = System.Drawing.Color.Gainsboro;
            this.listView訂單細項.HideSelection = false;
            this.listView訂單細項.Location = new System.Drawing.Point(562, 214);
            this.listView訂單細項.Name = "listView訂單細項";
            this.listView訂單細項.Size = new System.Drawing.Size(456, 370);
            this.listView訂單細項.TabIndex = 34;
            this.listView訂單細項.UseCompatibleStateImageBehavior = false;
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.lbl使用者名稱.Location = new System.Drawing.Point(682, 24);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(203, 49);
            this.lbl使用者名稱.TabIndex = 55;
            this.lbl使用者名稱.Text = "使用者";
            this.lbl使用者名稱.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Order_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1058, 655);
            this.Controls.Add(this.lbl使用者名稱);
            this.Controls.Add(this.listView訂單細項);
            this.Controls.Add(this.btn整筆刪除);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.dateTimePicker訂購日期);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox修改訂單狀態);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView搜尋結果);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order_management";
            this.Text = "Order_management";
            this.Load += new System.EventHandler(this.Order_management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker開始時間;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox搜尋訂單狀態;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView搜尋結果;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox修改訂單狀態;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker訂購日期;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.DateTimePicker dateTimePicker結束時間;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn整筆刪除;
        private System.Windows.Forms.ListView listView訂單細項;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label lbl使用者名稱;
    }
}