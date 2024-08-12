namespace Dessertshop
{
    partial class ProductInfo
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
            this.btn加入購物車 = new System.Windows.Forms.Button();
            this.btn離開 = new System.Windows.Forms.Button();
            this.pictureBox商品照 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt商品描述 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.lbl商品名稱 = new System.Windows.Forms.Label();
            this.lbl價格 = new System.Windows.Forms.Label();
            this.lbl規格 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品照)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品資訊";
            // 
            // btn加入購物車
            // 
            this.btn加入購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn加入購物車.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入購物車.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn加入購物車.Location = new System.Drawing.Point(764, 513);
            this.btn加入購物車.Name = "btn加入購物車";
            this.btn加入購物車.Size = new System.Drawing.Size(191, 63);
            this.btn加入購物車.TabIndex = 1;
            this.btn加入購物車.Text = "加入購物車";
            this.btn加入購物車.UseVisualStyleBackColor = false;
            this.btn加入購物車.Click += new System.EventHandler(this.btn加入購物車_Click);
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn離開.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn離開.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn離開.Location = new System.Drawing.Point(864, 9);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(91, 52);
            this.btn離開.TabIndex = 2;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // pictureBox商品照
            // 
            this.pictureBox商品照.Location = new System.Drawing.Point(631, 89);
            this.pictureBox商品照.Name = "pictureBox商品照";
            this.pictureBox商品照.Size = new System.Drawing.Size(324, 264);
            this.pictureBox商品照.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品照.TabIndex = 3;
            this.pictureBox商品照.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "價格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "規格";
            // 
            // txt商品描述
            // 
            this.txt商品描述.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.txt商品描述.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品描述.Location = new System.Drawing.Point(52, 342);
            this.txt商品描述.Multiline = true;
            this.txt商品描述.Name = "txt商品描述";
            this.txt商品描述.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt商品描述.Size = new System.Drawing.Size(480, 234);
            this.txt商品描述.TabIndex = 9;
            this.txt商品描述.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(625, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "數量";
            // 
            // txt數量
            // 
            this.txt數量.BackColor = System.Drawing.Color.Gainsboro;
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(702, 394);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(253, 47);
            this.txt數量.TabIndex = 16;
            // 
            // lbl商品名稱
            // 
            this.lbl商品名稱.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品名稱.ForeColor = System.Drawing.Color.Black;
            this.lbl商品名稱.Location = new System.Drawing.Point(186, 97);
            this.lbl商品名稱.Name = "lbl商品名稱";
            this.lbl商品名稱.Size = new System.Drawing.Size(353, 36);
            this.lbl商品名稱.TabIndex = 17;
            this.lbl商品名稱.Text = "商品名稱";
            // 
            // lbl價格
            // 
            this.lbl價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl價格.ForeColor = System.Drawing.Color.Black;
            this.lbl價格.Location = new System.Drawing.Point(186, 183);
            this.lbl價格.Name = "lbl價格";
            this.lbl價格.Size = new System.Drawing.Size(353, 36);
            this.lbl價格.TabIndex = 18;
            this.lbl價格.Text = "價格";
            // 
            // lbl規格
            // 
            this.lbl規格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl規格.ForeColor = System.Drawing.Color.Black;
            this.lbl規格.Location = new System.Drawing.Point(186, 270);
            this.lbl規格.Name = "lbl規格";
            this.lbl規格.Size = new System.Drawing.Size(353, 36);
            this.lbl規格.TabIndex = 19;
            this.lbl規格.Text = "規格";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1002, 588);
            this.Controls.Add(this.lbl規格);
            this.Controls.Add(this.lbl價格);
            this.Controls.Add(this.lbl商品名稱);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt商品描述);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox商品照);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.btn加入購物車);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfo";
            this.Text = "ProductInfo";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品照)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn加入購物車;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.PictureBox pictureBox商品照;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt商品描述;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label lbl商品名稱;
        private System.Windows.Forms.Label lbl價格;
        private System.Windows.Forms.Label lbl規格;
    }
}