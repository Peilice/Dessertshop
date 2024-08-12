namespace Dessertshop
{
    partial class Shoppingcart
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView購物清單 = new System.Windows.Forms.ListView();
            this.btn取消單項 = new System.Windows.Forms.Button();
            this.btn取消整筆 = new System.Windows.Forms.Button();
            this.btn確認訂購 = new System.Windows.Forms.Button();
            this.btn離開 = new System.Windows.Forms.Button();
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.imageList購物清單 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl總金額 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "購物明細";
            // 
            // listView購物清單
            // 
            this.listView購物清單.BackColor = System.Drawing.Color.Gainsboro;
            this.listView購物清單.HideSelection = false;
            this.listView購物清單.Location = new System.Drawing.Point(12, 141);
            this.listView購物清單.Name = "listView購物清單";
            this.listView購物清單.Size = new System.Drawing.Size(616, 366);
            this.listView購物清單.TabIndex = 2;
            this.listView購物清單.UseCompatibleStateImageBehavior = false;
            // 
            // btn取消單項
            // 
            this.btn取消單項.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn取消單項.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消單項.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn取消單項.Location = new System.Drawing.Point(652, 141);
            this.btn取消單項.Name = "btn取消單項";
            this.btn取消單項.Size = new System.Drawing.Size(151, 52);
            this.btn取消單項.TabIndex = 3;
            this.btn取消單項.Text = "取消單項";
            this.btn取消單項.UseVisualStyleBackColor = false;
            this.btn取消單項.Click += new System.EventHandler(this.btn取消單項_Click);
            // 
            // btn取消整筆
            // 
            this.btn取消整筆.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn取消整筆.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消整筆.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn取消整筆.Location = new System.Drawing.Point(652, 225);
            this.btn取消整筆.Name = "btn取消整筆";
            this.btn取消整筆.Size = new System.Drawing.Size(151, 52);
            this.btn取消整筆.TabIndex = 4;
            this.btn取消整筆.Text = "取消整筆";
            this.btn取消整筆.UseVisualStyleBackColor = false;
            this.btn取消整筆.Click += new System.EventHandler(this.btn取消整筆_Click);
            // 
            // btn確認訂購
            // 
            this.btn確認訂購.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.btn確認訂購.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確認訂購.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn確認訂購.Location = new System.Drawing.Point(652, 515);
            this.btn確認訂購.Name = "btn確認訂購";
            this.btn確認訂購.Size = new System.Drawing.Size(151, 52);
            this.btn確認訂購.TabIndex = 5;
            this.btn確認訂購.Text = "確認訂購";
            this.btn確認訂購.UseVisualStyleBackColor = false;
            this.btn確認訂購.Click += new System.EventHandler(this.btn確認訂購_Click);
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn離開.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn離開.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn離開.Location = new System.Drawing.Point(726, 12);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(77, 44);
            this.btn離開.TabIndex = 6;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.lbl使用者名稱.Location = new System.Drawing.Point(298, 90);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(330, 36);
            this.lbl使用者名稱.TabIndex = 8;
            this.lbl使用者名稱.Text = "您好";
            this.lbl使用者名稱.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageList購物清單
            // 
            this.imageList購物清單.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList購物清單.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList購物清單.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.label2.Location = new System.Drawing.Point(12, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 47);
            this.label2.TabIndex = 9;
            this.label2.Text = "總金額";
            // 
            // lbl總金額
            // 
            this.lbl總金額.AutoSize = true;
            this.lbl總金額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總金額.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.lbl總金額.Location = new System.Drawing.Point(146, 520);
            this.lbl總金額.Name = "lbl總金額";
            this.lbl總金額.Size = new System.Drawing.Size(153, 38);
            this.lbl總金額.TabIndex = 10;
            this.lbl總金額.Text = "           0元";
            // 
            // Shoppingcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(816, 580);
            this.Controls.Add(this.lbl總金額);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl使用者名稱);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.btn確認訂購);
            this.Controls.Add(this.btn取消整筆);
            this.Controls.Add(this.btn取消單項);
            this.Controls.Add(this.listView購物清單);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Shoppingcart";
            this.Text = "Shoppingcart";
            this.Load += new System.EventHandler(this.Shoppingcart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView購物清單;
        private System.Windows.Forms.Button btn取消單項;
        private System.Windows.Forms.Button btn取消整筆;
        private System.Windows.Forms.Button btn確認訂購;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.ImageList imageList購物清單;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl總金額;
    }
}