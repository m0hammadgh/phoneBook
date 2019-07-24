namespace PhoneBook.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.brnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSync = new System.Windows.Forms.ToolStripMenuItem();
            this.brnSearch = new System.Windows.Forms.ToolStripButton();
            this.tvSearchKeyWord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_DBDataSet = new PhoneBook.App.Contact_DBDataSet();
            this.numbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numbersTableAdapter = new PhoneBook.App.Contact_DBDataSetTableAdapters.NumbersTableAdapter();
            this.tvShowMobileNumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.brnSearch,
            this.tvSearchKeyWord,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(844, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUser,
            this.btnDelete,
            this.brnEdit,
            this.btnSync,
            this.tvShowMobileNumbers});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(104, 22);
            this.toolStripDropDownButton1.Text = "مدیریت مخاطبین";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(197, 22);
            this.btnAddUser.Text = "افزودن مخاطب";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 22);
            this.btnDelete.Text = "حذف مخاطب";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // brnEdit
            // 
            this.brnEdit.Name = "brnEdit";
            this.brnEdit.Size = new System.Drawing.Size(197, 22);
            this.brnEdit.Text = "ویرایش مخاطب";
            this.brnEdit.Click += new System.EventHandler(this.brnEdit_Click);
            // 
            // btnSync
            // 
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(197, 22);
            this.btnSync.Text = "به روز رسانی";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // brnSearch
            // 
            this.brnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.brnSearch.Image = ((System.Drawing.Image)(resources.GetObject("brnSearch.Image")));
            this.brnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brnSearch.Name = "brnSearch";
            this.brnSearch.Size = new System.Drawing.Size(64, 22);
            this.brnSearch.Text = "جست و جو";
            // 
            // tvSearchKeyWord
            // 
            this.tvSearchKeyWord.Name = "tvSearchKeyWord";
            this.tvSearchKeyWord.Size = new System.Drawing.Size(200, 25);
            this.tvSearchKeyWord.Text = "کلمه مورد جست و جو";
            this.tvSearchKeyWord.TextChanged += new System.EventHandler(this.tvSearchKeyWord_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "خروج";
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserLastName,
            this.UserNationalCode,
            this.BirthDate,
            this.HomeNumber,
            this.Address,
            this.Email,
            this.CityCode});
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.Location = new System.Drawing.Point(0, 25);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgUsers.Size = new System.Drawing.Size(844, 536);
            this.dgUsers.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "ای دی";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "نام";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserLastName
            // 
            this.UserLastName.DataPropertyName = "LastName";
            this.UserLastName.HeaderText = "نام خانوادگی";
            this.UserLastName.Name = "UserLastName";
            this.UserLastName.ReadOnly = true;
            // 
            // UserNationalCode
            // 
            this.UserNationalCode.DataPropertyName = "NationalCode";
            this.UserNationalCode.HeaderText = "کد ملی";
            this.UserNationalCode.Name = "UserNationalCode";
            this.UserNationalCode.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "تاریخ تولد";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // HomeNumber
            // 
            this.HomeNumber.DataPropertyName = "HomeNumber";
            this.HomeNumber.HeaderText = "شماره منزل";
            this.HomeNumber.Name = "HomeNumber";
            this.HomeNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "ادرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // CityCode
            // 
            this.CityCode.DataPropertyName = "CityCode";
            this.CityCode.HeaderText = "کد شهر";
            this.CityCode.Name = "CityCode";
            this.CityCode.ReadOnly = true;
            // 
            // contact_DBDataSet
            // 
            this.contact_DBDataSet.DataSetName = "Contact_DBDataSet";
            this.contact_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numbersBindingSource
            // 
            this.numbersBindingSource.DataMember = "Numbers";
            this.numbersBindingSource.DataSource = this.contact_DBDataSet;
            // 
            // numbersTableAdapter
            // 
            this.numbersTableAdapter.ClearBeforeFill = true;
            // 
            // tvShowMobileNumbers
            // 
            this.tvShowMobileNumbers.Name = "tvShowMobileNumbers";
            this.tvShowMobileNumbers.Size = new System.Drawing.Size(197, 22);
            this.tvShowMobileNumbers.Text = "نمایش شماره های موبایل";
            this.tvShowMobileNumbers.Click += new System.EventHandler(this.tvShowMobileNumbers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnAddUser;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem brnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnSync;
        private System.Windows.Forms.ToolStripTextBox tvSearchKeyWord;
        private System.Windows.Forms.ToolStripButton brnSearch;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCode;
        private Contact_DBDataSet contact_DBDataSet;
        private System.Windows.Forms.BindingSource numbersBindingSource;
        private Contact_DBDataSetTableAdapters.NumbersTableAdapter numbersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem tvShowMobileNumbers;
    }
}

