namespace PhoneBook.App
{
    partial class AddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.tvCityCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tvHomePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tvAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tvLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.pcUser = new System.Windows.Forms.PictureBox();
            this.tvMobileNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMobileNumber = new System.Windows.Forms.Button();
            this.tvNationalCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.panelNumbers = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtPicker);
            this.groupBox1.Controls.Add(this.tvCityCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tvHomePhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tvAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tvEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tvLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tvName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(407, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات شخصی";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(375, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "تاریخ تولد";
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(115, 366);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(242, 20);
            this.dtPicker.TabIndex = 17;
            // 
            // tvCityCode
            // 
            this.tvCityCode.Location = new System.Drawing.Point(115, 299);
            this.tvCityCode.Name = "tvCityCode";
            this.tvCityCode.Size = new System.Drawing.Size(242, 20);
            this.tvCityCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "کد شهر";
            // 
            // tvHomePhone
            // 
            this.tvHomePhone.Location = new System.Drawing.Point(115, 251);
            this.tvHomePhone.Name = "tvHomePhone";
            this.tvHomePhone.Size = new System.Drawing.Size(242, 20);
            this.tvHomePhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "تلفن منزل";
            // 
            // tvAddress
            // 
            this.tvAddress.Location = new System.Drawing.Point(115, 199);
            this.tvAddress.Name = "tvAddress";
            this.tvAddress.Size = new System.Drawing.Size(242, 20);
            this.tvAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "آدرس";
            // 
            // tvEmail
            // 
            this.tvEmail.Location = new System.Drawing.Point(115, 152);
            this.tvEmail.Name = "tvEmail";
            this.tvEmail.Size = new System.Drawing.Size(242, 20);
            this.tvEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ایمیل";
            // 
            // tvLastName
            // 
            this.tvLastName.Location = new System.Drawing.Point(115, 100);
            this.tvLastName.Name = "tvLastName";
            this.tvLastName.Size = new System.Drawing.Size(242, 20);
            this.tvLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی";
            // 
            // tvName
            // 
            this.tvName.Location = new System.Drawing.Point(115, 50);
            this.tvName.Name = "tvName";
            this.tvName.Size = new System.Drawing.Size(242, 20);
            this.tvName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectPic);
            this.groupBox2.Controls.Add(this.pcUser);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر کاربر";
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Location = new System.Drawing.Point(6, 131);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(87, 23);
            this.btnSelectPic.TabIndex = 1;
            this.btnSelectPic.Text = "انتخاب عکس";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // pcUser
            // 
            this.pcUser.Image = global::PhoneBook.App.Properties.Resources.no_profile_image;
            this.pcUser.Location = new System.Drawing.Point(6, 29);
            this.pcUser.Name = "pcUser";
            this.pcUser.Size = new System.Drawing.Size(87, 91);
            this.pcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcUser.TabIndex = 0;
            this.pcUser.TabStop = false;
            // 
            // tvMobileNumber
            // 
            this.tvMobileNumber.Location = new System.Drawing.Point(247, 141);
            this.tvMobileNumber.Name = "tvMobileNumber";
            this.tvMobileNumber.Size = new System.Drawing.Size(154, 20);
            this.tvMobileNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "شماره موبایل";
            // 
            // btnAddMobileNumber
            // 
            this.btnAddMobileNumber.Location = new System.Drawing.Point(212, 139);
            this.btnAddMobileNumber.Name = "btnAddMobileNumber";
            this.btnAddMobileNumber.Size = new System.Drawing.Size(29, 26);
            this.btnAddMobileNumber.TabIndex = 16;
            this.btnAddMobileNumber.Text = "+";
            this.btnAddMobileNumber.UseVisualStyleBackColor = true;
            this.btnAddMobileNumber.Click += new System.EventHandler(this.btnAddMobileNumber_Click);
            // 
            // tvNationalCode
            // 
            this.tvNationalCode.Location = new System.Drawing.Point(247, 63);
            this.tvNationalCode.Name = "tvNationalCode";
            this.tvNationalCode.Size = new System.Drawing.Size(154, 20);
            this.tvNationalCode.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "کدملی";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.tvName;
            this.requiredFieldValidator1.ErrorMessage = "نام را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.tvLastName;
            this.requiredFieldValidator2.ErrorMessage = "نام خانوادگی را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.tvMobileNumber;
            this.requiredFieldValidator3.ErrorMessage = "موبایل را وارد کنید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // panelNumbers
            // 
            this.panelNumbers.Location = new System.Drawing.Point(12, 184);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(386, 254);
            this.panelNumbers.TabIndex = 19;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.tvNationalCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddMobileNumber);
            this.Controls.Add(this.tvMobileNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddContact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tvCityCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tvHomePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tvAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tvEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tvLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tvName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pcUser;
        private System.Windows.Forms.TextBox tvMobileNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnAddMobileNumber;
        private System.Windows.Forms.Button btnSave;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private System.Windows.Forms.TextBox tvNationalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel panelNumbers;
    }
}