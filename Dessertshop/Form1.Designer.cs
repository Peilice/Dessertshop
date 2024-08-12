namespace Dessertshop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn購物車 = new System.Windows.Forms.Button();
            this.btn個人資料 = new System.Windows.Forms.Button();
            this.btn系統管理 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage常溫點心 = new System.Windows.Forms.TabPage();
            this.listView常溫點心 = new System.Windows.Forms.ListView();
            this.tabPage冷藏點心 = new System.Windows.Forms.TabPage();
            this.listView冷藏點心 = new System.Windows.Forms.ListView();
            this.tabPage季節點心 = new System.Windows.Forms.TabPage();
            this.listView季節點心 = new System.Windows.Forms.ListView();
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.btn加入會員 = new System.Windows.Forms.Button();
            this.imageList常溫點心 = new System.Windows.Forms.ImageList(this.components);
            this.imageList冷藏點心 = new System.Windows.Forms.ImageList(this.components);
            this.imageList季節點心 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn歷史訂單 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage常溫點心.SuspendLayout();
            this.tabPage冷藏點心.SuspendLayout();
            this.tabPage季節點心.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn登入.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn登入.Location = new System.Drawing.Point(1022, 58);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(146, 55);
            this.btn登入.TabIndex = 1;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn購物車
            // 
            this.btn購物車.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn購物車.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn購物車.Location = new System.Drawing.Point(860, 119);
            this.btn購物車.Name = "btn購物車";
            this.btn購物車.Size = new System.Drawing.Size(146, 50);
            this.btn購物車.TabIndex = 2;
            this.btn購物車.Text = "購物車";
            this.btn購物車.UseVisualStyleBackColor = false;
            this.btn購物車.Click += new System.EventHandler(this.btn購物車_Click);
            // 
            // btn個人資料
            // 
            this.btn個人資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn個人資料.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn個人資料.Location = new System.Drawing.Point(696, 119);
            this.btn個人資料.Name = "btn個人資料";
            this.btn個人資料.Size = new System.Drawing.Size(146, 50);
            this.btn個人資料.TabIndex = 3;
            this.btn個人資料.Text = "個人資料";
            this.btn個人資料.UseVisualStyleBackColor = false;
            this.btn個人資料.Click += new System.EventHandler(this.btn個人資料_Click);
            // 
            // btn系統管理
            // 
            this.btn系統管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn系統管理.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn系統管理.Location = new System.Drawing.Point(531, 119);
            this.btn系統管理.Name = "btn系統管理";
            this.btn系統管理.Size = new System.Drawing.Size(146, 50);
            this.btn系統管理.TabIndex = 4;
            this.btn系統管理.Text = "系統管理";
            this.btn系統管理.UseVisualStyleBackColor = false;
            this.btn系統管理.Visible = false;
            this.btn系統管理.Click += new System.EventHandler(this.btn系統管理_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage常溫點心);
            this.tabControl.Controls.Add(this.tabPage冷藏點心);
            this.tabControl.Controls.Add(this.tabPage季節點心);
            this.tabControl.Location = new System.Drawing.Point(12, 183);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1171, 471);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage常溫點心
            // 
            this.tabPage常溫點心.Controls.Add(this.listView常溫點心);
            this.tabPage常溫點心.Location = new System.Drawing.Point(4, 38);
            this.tabPage常溫點心.Name = "tabPage常溫點心";
            this.tabPage常溫點心.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage常溫點心.Size = new System.Drawing.Size(1163, 429);
            this.tabPage常溫點心.TabIndex = 0;
            this.tabPage常溫點心.Text = "常溫點心";
            this.tabPage常溫點心.UseVisualStyleBackColor = true;
            // 
            // listView常溫點心
            // 
            this.listView常溫點心.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView常溫點心.BackColor = System.Drawing.Color.Gainsboro;
            this.listView常溫點心.HideSelection = false;
            this.listView常溫點心.Location = new System.Drawing.Point(-4, 0);
            this.listView常溫點心.Name = "listView常溫點心";
            this.listView常溫點心.Size = new System.Drawing.Size(1171, 448);
            this.listView常溫點心.TabIndex = 0;
            this.listView常溫點心.UseCompatibleStateImageBehavior = false;
            this.listView常溫點心.ItemActivate += new System.EventHandler(this.listView常溫點心_ItemActivate);
            // 
            // tabPage冷藏點心
            // 
            this.tabPage冷藏點心.Controls.Add(this.listView冷藏點心);
            this.tabPage冷藏點心.Location = new System.Drawing.Point(4, 38);
            this.tabPage冷藏點心.Name = "tabPage冷藏點心";
            this.tabPage冷藏點心.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage冷藏點心.Size = new System.Drawing.Size(1163, 429);
            this.tabPage冷藏點心.TabIndex = 1;
            this.tabPage冷藏點心.Text = "冷藏點心";
            this.tabPage冷藏點心.UseVisualStyleBackColor = true;
            // 
            // listView冷藏點心
            // 
            this.listView冷藏點心.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView冷藏點心.BackColor = System.Drawing.Color.Gainsboro;
            this.listView冷藏點心.HideSelection = false;
            this.listView冷藏點心.Location = new System.Drawing.Point(-4, 0);
            this.listView冷藏點心.Name = "listView冷藏點心";
            this.listView冷藏點心.Size = new System.Drawing.Size(1171, 447);
            this.listView冷藏點心.TabIndex = 0;
            this.listView冷藏點心.UseCompatibleStateImageBehavior = false;
            this.listView冷藏點心.ItemActivate += new System.EventHandler(this.listView冷藏點心_ItemActivate);
            // 
            // tabPage季節點心
            // 
            this.tabPage季節點心.Controls.Add(this.listView季節點心);
            this.tabPage季節點心.Location = new System.Drawing.Point(4, 38);
            this.tabPage季節點心.Name = "tabPage季節點心";
            this.tabPage季節點心.Size = new System.Drawing.Size(1163, 429);
            this.tabPage季節點心.TabIndex = 2;
            this.tabPage季節點心.Text = "季節點心";
            this.tabPage季節點心.UseVisualStyleBackColor = true;
            // 
            // listView季節點心
            // 
            this.listView季節點心.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView季節點心.BackColor = System.Drawing.Color.Gainsboro;
            this.listView季節點心.HideSelection = false;
            this.listView季節點心.Location = new System.Drawing.Point(2, 0);
            this.listView季節點心.Name = "listView季節點心";
            this.listView季節點心.Size = new System.Drawing.Size(1161, 462);
            this.listView季節點心.TabIndex = 0;
            this.listView季節點心.UseCompatibleStateImageBehavior = false;
            this.listView季節點心.ItemActivate += new System.EventHandler(this.listView季節點心_ItemActivate);
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.BackColor = System.Drawing.Color.Transparent;
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl使用者名稱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.lbl使用者名稱.Location = new System.Drawing.Point(702, 9);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(466, 46);
            this.lbl使用者名稱.TabIndex = 7;
            this.lbl使用者名稱.Text = "歡迎使用";
            this.lbl使用者名稱.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn加入會員
            // 
            this.btn加入會員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn加入會員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn加入會員.Location = new System.Drawing.Point(1022, 119);
            this.btn加入會員.Name = "btn加入會員";
            this.btn加入會員.Size = new System.Drawing.Size(146, 50);
            this.btn加入會員.TabIndex = 8;
            this.btn加入會員.Text = "加入會員";
            this.btn加入會員.UseVisualStyleBackColor = false;
            this.btn加入會員.Click += new System.EventHandler(this.btn加入會員_Click);
            // 
            // imageList常溫點心
            // 
            this.imageList常溫點心.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList常溫點心.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList常溫點心.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList冷藏點心
            // 
            this.imageList冷藏點心.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList冷藏點心.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList冷藏點心.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList季節點心
            // 
            this.imageList季節點心.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList季節點心.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList季節點心.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn歷史訂單
            // 
            this.btn歷史訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn歷史訂單.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn歷史訂單.Location = new System.Drawing.Point(860, 58);
            this.btn歷史訂單.Name = "btn歷史訂單";
            this.btn歷史訂單.Size = new System.Drawing.Size(146, 50);
            this.btn歷史訂單.TabIndex = 10;
            this.btn歷史訂單.Text = "歷史訂單";
            this.btn歷史訂單.UseVisualStyleBackColor = false;
            this.btn歷史訂單.Visible = false;
            this.btn歷史訂單.Click += new System.EventHandler(this.btn歷史訂單_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1195, 666);
            this.Controls.Add(this.btn歷史訂單);
            this.Controls.Add(this.btn加入會員);
            this.Controls.Add(this.lbl使用者名稱);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn系統管理);
            this.Controls.Add(this.btn個人資料);
            this.Controls.Add(this.btn購物車);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Dessert Shop";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage常溫點心.ResumeLayout(false);
            this.tabPage冷藏點心.ResumeLayout(false);
            this.tabPage季節點心.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn購物車;
        private System.Windows.Forms.Button btn個人資料;
        private System.Windows.Forms.Button btn系統管理;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage冷藏點心;
        private System.Windows.Forms.TabPage tabPage季節點心;
        private System.Windows.Forms.Label lbl使用者名稱;
        private System.Windows.Forms.Button btn加入會員;
        private System.Windows.Forms.TabPage tabPage常溫點心;
        private System.Windows.Forms.ImageList imageList常溫點心;
        private System.Windows.Forms.ImageList imageList冷藏點心;
        private System.Windows.Forms.ImageList imageList季節點心;
        private System.Windows.Forms.ListView listView常溫點心;
        private System.Windows.Forms.ListView listView冷藏點心;
        private System.Windows.Forms.ListView listView季節點心;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn歷史訂單;
    }
}

