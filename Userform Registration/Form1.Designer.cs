namespace Userform_Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textFname = new System.Windows.Forms.TextBox();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.cmdGender = new System.Windows.Forms.ComboBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "password";
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(743, 57);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(182, 31);
            this.textLname.TabIndex = 8;
            this.textLname.Text = "Juyal";
            // 
            // textFname
            // 
            this.textFname.Location = new System.Drawing.Point(274, 44);
            this.textFname.Name = "textFname";
            this.textFname.Size = new System.Drawing.Size(167, 31);
            this.textFname.TabIndex = 9;
            this.textFname.Text = "Umesh";
            // 
            // textAdd
            // 
            this.textAdd.Location = new System.Drawing.Point(274, 179);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(183, 31);
            this.textAdd.TabIndex = 10;
            this.textAdd.Text = "India";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(267, 300);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(190, 31);
            this.textEmail.TabIndex = 12;
            this.textEmail.Text = "umeshjuyal@123";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(743, 289);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(182, 31);
            this.textPhone.TabIndex = 13;
            this.textPhone.Text = "948987797";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(743, 392);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(182, 31);
            this.textPass.TabIndex = 14;
            this.textPass.Text = "12345";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(267, 408);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(190, 31);
            this.textUser.TabIndex = 15;
            this.textUser.Text = "umesh@134";
            // 
            // cmdGender
            // 
            this.cmdGender.FormattingEnabled = true;
            this.cmdGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmdGender.Location = new System.Drawing.Point(743, 179);
            this.cmdGender.Name = "cmdGender";
            this.cmdGender.Size = new System.Drawing.Size(182, 33);
            this.cmdGender.TabIndex = 16;
            this.cmdGender.SelectedIndexChanged += new System.EventHandler(this.cmdGender_SelectedIndexChanged);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(818, 465);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(112, 34);
            this.BtnRegister.TabIndex = 17;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 550);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.cmdGender);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textAdd);
            this.Controls.Add(this.textFname);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textLname;
        private TextBox textFname;
        private TextBox textAdd;
        private TextBox textEmail;
        private TextBox textPhone;
        private TextBox textPass;
        private TextBox textUser;
        private ComboBox cmdGender;
        private Button BtnRegister;
    }
}