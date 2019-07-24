namespace PhoneBook.App
{
    partial class ShowMobileNumbers
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
            this.dgMobileNUmbers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMobileNUmbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMobileNUmbers
            // 
            this.dgMobileNUmbers.AllowUserToAddRows = false;
            this.dgMobileNUmbers.AllowUserToDeleteRows = false;
            this.dgMobileNUmbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMobileNUmbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgMobileNUmbers.Location = new System.Drawing.Point(-2, -3);
            this.dgMobileNUmbers.Name = "dgMobileNUmbers";
            this.dgMobileNUmbers.ReadOnly = true;
            this.dgMobileNUmbers.Size = new System.Drawing.Size(801, 456);
            this.dgMobileNUmbers.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ShowMobileNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMobileNUmbers);
            this.Name = "ShowMobileNumbers";
            this.Text = "ShowMobileNumbers";
            this.Load += new System.EventHandler(this.ShowMobileNumbers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMobileNUmbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMobileNUmbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}