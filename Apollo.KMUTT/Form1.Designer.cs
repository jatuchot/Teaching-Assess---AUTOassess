namespace Apollo.KMUTT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.webApollo = new System.Windows.Forms.WebBrowser();
            this.tLoginApollo = new System.Windows.Forms.Timer(this.components);
            this.tCPreviousApollo = new System.Windows.Forms.Timer(this.components);
            this.tChooseLecturers = new System.Windows.Forms.Timer(this.components);
            this.checkedListLecturers = new System.Windows.Forms.CheckedListBox();
            this.btnSTDAssess = new System.Windows.Forms.Button();
            this.tClickAssess = new System.Windows.Forms.Timer(this.components);
            this.tCheckType = new System.Windows.Forms.Timer(this.components);
            this.tSavePoint = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listStatusBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEnableAjan = new System.Windows.Forms.TextBox();
            this.btnConfigAjan = new System.Windows.Forms.Button();
            this.txtCommentAjan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxScoreAjan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinScoreAjan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameAjan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndexAjan = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureLecturers = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(4, 93);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(362, 26);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ล็อกอิน";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(4, 34);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(362, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(4, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(362, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // webApollo
            // 
            this.webApollo.Location = new System.Drawing.Point(1020, 214);
            this.webApollo.Margin = new System.Windows.Forms.Padding(2);
            this.webApollo.MinimumSize = new System.Drawing.Size(15, 16);
            this.webApollo.Name = "webApollo";
            this.webApollo.Size = new System.Drawing.Size(401, 329);
            this.webApollo.TabIndex = 5;
            // 
            // tLoginApollo
            // 
            this.tLoginApollo.Tick += new System.EventHandler(this.tLoginApollo_Tick);
            // 
            // tCPreviousApollo
            // 
            this.tCPreviousApollo.Tick += new System.EventHandler(this.tCPreviousApollo_Tick);
            // 
            // tChooseLecturers
            // 
            this.tChooseLecturers.Tick += new System.EventHandler(this.tChooseLecturers_Tick);
            // 
            // checkedListLecturers
            // 
            this.checkedListLecturers.FormattingEnabled = true;
            this.checkedListLecturers.Location = new System.Drawing.Point(4, 17);
            this.checkedListLecturers.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListLecturers.Name = "checkedListLecturers";
            this.checkedListLecturers.Size = new System.Drawing.Size(362, 244);
            this.checkedListLecturers.TabIndex = 6;
            this.checkedListLecturers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListLecturers_ItemCheck);
            this.checkedListLecturers.SelectedIndexChanged += new System.EventHandler(this.checkedListLecturers_SelectedIndexChanged);
            // 
            // btnSTDAssess
            // 
            this.btnSTDAssess.Location = new System.Drawing.Point(782, 222);
            this.btnSTDAssess.Margin = new System.Windows.Forms.Padding(2);
            this.btnSTDAssess.Name = "btnSTDAssess";
            this.btnSTDAssess.Size = new System.Drawing.Size(152, 31);
            this.btnSTDAssess.TabIndex = 7;
            this.btnSTDAssess.Text = "เริ่มประเมิณอาจารย์";
            this.btnSTDAssess.UseVisualStyleBackColor = true;
            this.btnSTDAssess.Click += new System.EventHandler(this.btnSTDAssess_Click);
            // 
            // tClickAssess
            // 
            this.tClickAssess.Tick += new System.EventHandler(this.tClickAssess_Tick);
            // 
            // tCheckType
            // 
            this.tCheckType.Tick += new System.EventHandler(this.tCheckType_Tick);
            // 
            // tSavePoint
            // 
            this.tSavePoint.Tick += new System.EventHandler(this.tSavePoint_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลไอดีและรหัสผ่าน!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListLecturers);
            this.groupBox2.Location = new System.Drawing.Point(9, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 271);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายชื่ออาจารย์ กรุณาเลือกก่อนประเมิณ!";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listStatusBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 143);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(370, 137);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "สถานะโปรแกรม";
            // 
            // listStatusBox
            // 
            this.listStatusBox.FormattingEnabled = true;
            this.listStatusBox.Location = new System.Drawing.Point(4, 21);
            this.listStatusBox.Margin = new System.Windows.Forms.Padding(2);
            this.listStatusBox.Name = "listStatusBox";
            this.listStatusBox.Size = new System.Drawing.Size(362, 108);
            this.listStatusBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEnableAjan);
            this.groupBox4.Controls.Add(this.btnConfigAjan);
            this.groupBox4.Controls.Add(this.txtCommentAjan);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtMaxScoreAjan);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtMinScoreAjan);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtNameAjan);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtIndexAjan);
            this.groupBox4.Location = new System.Drawing.Point(384, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 550);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ตั้งค่าข้อมูลอาจารย์ก่อนเริ่มประเมิณ";
            // 
            // txtEnableAjan
            // 
            this.txtEnableAjan.Location = new System.Drawing.Point(341, 68);
            this.txtEnableAjan.Name = "txtEnableAjan";
            this.txtEnableAjan.Size = new System.Drawing.Size(45, 20);
            this.txtEnableAjan.TabIndex = 13;
            // 
            // btnConfigAjan
            // 
            this.btnConfigAjan.Location = new System.Drawing.Point(6, 514);
            this.btnConfigAjan.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigAjan.Name = "btnConfigAjan";
            this.btnConfigAjan.Size = new System.Drawing.Size(380, 31);
            this.btnConfigAjan.TabIndex = 12;
            this.btnConfigAjan.Text = "ตั้งค่าอาจารย์";
            this.btnConfigAjan.UseVisualStyleBackColor = true;
            this.btnConfigAjan.Click += new System.EventHandler(this.btnConfigAjan_Click);
            // 
            // txtCommentAjan
            // 
            this.txtCommentAjan.Location = new System.Drawing.Point(6, 186);
            this.txtCommentAjan.Multiline = true;
            this.txtCommentAjan.Name = "txtCommentAjan";
            this.txtCommentAjan.Size = new System.Drawing.Size(380, 323);
            this.txtCommentAjan.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "คอมเม้น";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "คะแนนสูงสุด (1-6)";
            // 
            // txtMaxScoreAjan
            // 
            this.txtMaxScoreAjan.Location = new System.Drawing.Point(190, 147);
            this.txtMaxScoreAjan.Name = "txtMaxScoreAjan";
            this.txtMaxScoreAjan.Size = new System.Drawing.Size(196, 20);
            this.txtMaxScoreAjan.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "คะแนนต่ำสุด (1-6)";
            // 
            // txtMinScoreAjan
            // 
            this.txtMinScoreAjan.Location = new System.Drawing.Point(6, 147);
            this.txtMinScoreAjan.Name = "txtMinScoreAjan";
            this.txtMinScoreAjan.Size = new System.Drawing.Size(178, 20);
            this.txtMinScoreAjan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "*** เลือกอาจารย์จากรายชื่ออาจารย์ กรุณากรอกข้อมูลทุกอย่างก่อนเริ่มประเมิณ ***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ชื่ออาจารย์";
            // 
            // txtNameAjan
            // 
            this.txtNameAjan.Location = new System.Drawing.Point(6, 107);
            this.txtNameAjan.Name = "txtNameAjan";
            this.txtNameAjan.Size = new System.Drawing.Size(380, 20);
            this.txtNameAjan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "รหัสอาจารย์";
            // 
            // txtIndexAjan
            // 
            this.txtIndexAjan.Location = new System.Drawing.Point(6, 68);
            this.txtIndexAjan.Name = "txtIndexAjan";
            this.txtIndexAjan.Size = new System.Drawing.Size(329, 20);
            this.txtIndexAjan.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureLecturers);
            this.groupBox5.Location = new System.Drawing.Point(782, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 207);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "รูปอาจารย์ที่กำลังประเมิณ";
            // 
            // pictureLecturers
            // 
            this.pictureLecturers.ImageLocation = "";
            this.pictureLecturers.Location = new System.Drawing.Point(6, 19);
            this.pictureLecturers.Name = "pictureLecturers";
            this.pictureLecturers.Size = new System.Drawing.Size(140, 180);
            this.pictureLecturers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLecturers.TabIndex = 0;
            this.pictureLecturers.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(798, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 26);
            this.label9.TabIndex = 14;
            this.label9.Text = "Created By Chang && Boss\r\nCPE 30";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 569);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSTDAssess);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webApollo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(963, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(963, 608);
            this.Name = "Form1";
            this.Text = ": Auto Assess Apollo :";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.WebBrowser webApollo;
        private System.Windows.Forms.Timer tLoginApollo;
        private System.Windows.Forms.Timer tCPreviousApollo;
        private System.Windows.Forms.Timer tChooseLecturers;
        private System.Windows.Forms.CheckedListBox checkedListLecturers;
        private System.Windows.Forms.Button btnSTDAssess;
        private System.Windows.Forms.Timer tClickAssess;
        private System.Windows.Forms.Timer tCheckType;
        private System.Windows.Forms.Timer tSavePoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listStatusBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameAjan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndexAjan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxScoreAjan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinScoreAjan;
        private System.Windows.Forms.TextBox txtCommentAjan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfigAjan;
        private System.Windows.Forms.TextBox txtEnableAjan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureLecturers;
        private System.Windows.Forms.Label label9;
    }
}

