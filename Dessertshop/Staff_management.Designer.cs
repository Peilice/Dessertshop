namespace Dessertshop
{
    partial class Staff_management
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
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.listView搜尋結果 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.comboBox搜尋類別 = new System.Windows.Forms.ComboBox();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.btn新增員工 = new System.Windows.Forms.Button();
            this.btn離開 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.combobox權限 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt職稱 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker生日 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt薪資 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radio在職 = new System.Windows.Forms.RadioButton();
            this.radio離職 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker入職 = new System.Windows.Forms.DateTimePicker();
            this.lbl使用者名稱 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn清空欄位.Location = new System.Drawing.Point(771, 531);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(142, 53);
            this.btn清空欄位.TabIndex = 41;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = false;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // listView搜尋結果
            // 
            this.listView搜尋結果.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView搜尋結果.BackColor = System.Drawing.Color.Gainsboro;
            this.listView搜尋結果.HideSelection = false;
            this.listView搜尋結果.Location = new System.Drawing.Point(504, 206);
            this.listView搜尋結果.Name = "listView搜尋結果";
            this.listView搜尋結果.Size = new System.Drawing.Size(566, 318);
            this.listView搜尋結果.TabIndex = 40;
            this.listView搜尋結果.UseCompatibleStateImageBehavior = false;
            this.listView搜尋結果.ItemActivate += new System.EventHandler(this.listView搜尋結果_ItemActivate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn搜尋);
            this.groupBox1.Controls.Add(this.comboBox搜尋類別);
            this.groupBox1.Controls.Add(this.txt搜尋);
            this.groupBox1.Location = new System.Drawing.Point(504, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 121);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋";
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn搜尋.Location = new System.Drawing.Point(443, 45);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(106, 47);
            this.btn搜尋.TabIndex = 2;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // comboBox搜尋類別
            // 
            this.comboBox搜尋類別.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox搜尋類別.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox搜尋類別.FormattingEnabled = true;
            this.comboBox搜尋類別.Location = new System.Drawing.Point(232, 51);
            this.comboBox搜尋類別.Name = "comboBox搜尋類別";
            this.comboBox搜尋類別.Size = new System.Drawing.Size(184, 43);
            this.comboBox搜尋類別.TabIndex = 1;
            // 
            // txt搜尋
            // 
            this.txt搜尋.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt搜尋.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt搜尋.Location = new System.Drawing.Point(16, 51);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(197, 43);
            this.txt搜尋.TabIndex = 0;
            // 
            // btn新增員工
            // 
            this.btn新增員工.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn新增員工.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增員工.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn新增員工.Location = new System.Drawing.Point(928, 531);
            this.btn新增員工.Name = "btn新增員工";
            this.btn新增員工.Size = new System.Drawing.Size(142, 53);
            this.btn新增員工.TabIndex = 38;
            this.btn新增員工.Text = "新增員工";
            this.btn新增員工.UseVisualStyleBackColor = false;
            this.btn新增員工.Click += new System.EventHandler(this.btn新增員工_Click);
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn離開.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn離開.Location = new System.Drawing.Point(979, 15);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(85, 53);
            this.btn離開.TabIndex = 36;
            this.btn離開.Text = "離開";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.btn儲存修改.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存修改.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.btn儲存修改.Location = new System.Drawing.Point(612, 531);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(142, 53);
            this.btn儲存修改.TabIndex = 34;
            this.btn儲存修改.Text = "儲存修改";
            this.btn儲存修改.UseVisualStyleBackColor = false;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(62)))), ((int)(((byte)(95)))));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 76);
            this.label6.TabIndex = 32;
            this.label6.Text = "人員管理";
            // 
            // combobox權限
            // 
            this.combobox權限.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combobox權限.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.combobox權限.FormattingEnabled = true;
            this.combobox權限.Location = new System.Drawing.Point(128, 451);
            this.combobox權限.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.combobox權限.Name = "combobox權限";
            this.combobox權限.Size = new System.Drawing.Size(283, 43);
            this.combobox權限.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(18, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "入職日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(128, 255);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 43);
            this.txtEmail.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "*E-mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt地址
            // 
            this.txt地址.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(128, 206);
            this.txt地址.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(352, 43);
            this.txt地址.TabIndex = 26;
            // 
            // txt電話
            // 
            this.txt電話.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(128, 158);
            this.txt電話.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(283, 43);
            this.txt電話.TabIndex = 25;
            // 
            // txt姓名
            // 
            this.txt姓名.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(128, 109);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(283, 43);
            this.txt姓名.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(53, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "*地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "*電話";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(53, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "*姓名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(53, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "*職稱";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(53, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 43;
            this.label8.Text = "*權限";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt職稱
            // 
            this.txt職稱.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt職稱.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt職稱.Location = new System.Drawing.Point(128, 404);
            this.txt職稱.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt職稱.Name = "txt職稱";
            this.txt職稱.Size = new System.Drawing.Size(283, 43);
            this.txt職稱.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(53, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 46;
            this.label9.Text = "*生日";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker生日
            // 
            this.dateTimePicker生日.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker生日.Location = new System.Drawing.Point(128, 305);
            this.dateTimePicker生日.Name = "dateTimePicker生日";
            this.dateTimePicker生日.Size = new System.Drawing.Size(283, 43);
            this.dateTimePicker生日.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(53, 507);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 29);
            this.label10.TabIndex = 48;
            this.label10.Text = "*薪資";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt薪資
            // 
            this.txt薪資.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt薪資.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt薪資.Location = new System.Drawing.Point(128, 500);
            this.txt薪資.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt薪資.Name = "txt薪資";
            this.txt薪資.Size = new System.Drawing.Size(283, 43);
            this.txt薪資.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(13, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 29);
            this.label11.TabIndex = 50;
            this.label11.Text = "在職狀態";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radio在職
            // 
            this.radio在職.AutoSize = true;
            this.radio在職.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio在職.Location = new System.Drawing.Point(128, 544);
            this.radio在職.Name = "radio在職";
            this.radio在職.Size = new System.Drawing.Size(92, 40);
            this.radio在職.TabIndex = 51;
            this.radio在職.TabStop = true;
            this.radio在職.Text = "在職";
            this.radio在職.UseVisualStyleBackColor = true;
            // 
            // radio離職
            // 
            this.radio離職.AutoSize = true;
            this.radio離職.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio離職.Location = new System.Drawing.Point(251, 544);
            this.radio離職.Name = "radio離職";
            this.radio離職.Size = new System.Drawing.Size(120, 40);
            this.radio離職.TabIndex = 52;
            this.radio離職.TabStop = true;
            this.radio離職.Text = "已離職";
            this.radio離職.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker入職
            // 
            this.dateTimePicker入職.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker入職.Location = new System.Drawing.Point(128, 354);
            this.dateTimePicker入職.Name = "dateTimePicker入職";
            this.dateTimePicker入職.Size = new System.Drawing.Size(283, 43);
            this.dateTimePicker入職.TabIndex = 53;
            // 
            // lbl使用者名稱
            // 
            this.lbl使用者名稱.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl使用者名稱.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(54)))));
            this.lbl使用者名稱.Location = new System.Drawing.Point(277, 42);
            this.lbl使用者名稱.Name = "lbl使用者名稱";
            this.lbl使用者名稱.Size = new System.Drawing.Size(203, 49);
            this.lbl使用者名稱.TabIndex = 54;
            this.lbl使用者名稱.Text = "使用者";
            this.lbl使用者名稱.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Staff_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1085, 594);
            this.Controls.Add(this.lbl使用者名稱);
            this.Controls.Add(this.dateTimePicker入職);
            this.Controls.Add(this.radio離職);
            this.Controls.Add(this.radio在職);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt薪資);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker生日);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt職稱);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.listView搜尋結果);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn新增員工);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.btn儲存修改);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobox權限);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Staff_management";
            this.Text = "Staff_management";
            this.Load += new System.EventHandler(this.Staff_management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.ListView listView搜尋結果;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox comboBox搜尋類別;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Button btn新增員工;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combobox權限;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt職稱;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker生日;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt薪資;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radio在職;
        private System.Windows.Forms.RadioButton radio離職;
        private System.Windows.Forms.DateTimePicker dateTimePicker入職;
        private System.Windows.Forms.Label lbl使用者名稱;
    }
}