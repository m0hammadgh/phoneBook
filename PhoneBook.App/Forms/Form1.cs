﻿using PhoneBook.App.Forms;
using PhoneBook_DbLayer;
using PhoneBook_DbLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.App
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (ContextManager db = new ContextManager())
            {
                dgUsers.AutoGenerateColumns = false;
                dgUsers.DataSource = db.UserRepository.GetAllContacts();
            }
        }

        private void tvSearchKeyWord_TextChanged(object sender, EventArgs e)
        {
            using (ContextManager db = new ContextManager())
            {
                dgUsers.AutoGenerateColumns = false;

                dgUsers.DataSource = db.UserRepository.getUserByFilter(tvSearchKeyWord.Text);


            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            tvSearchKeyWord.Text = "";
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUsers.CurrentRow != null)
            {
                String name = dgUsers.CurrentRow.Cells[1].Value.ToString() + " " + dgUsers.CurrentRow.Cells[2].Value.ToString();
                if (RtlMessageBox.Show($"ایا از حذف  {name} اطمینان دارید ؟ ", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                {
                    int cutomerId = int.Parse(dgUsers.CurrentRow.Cells[0].Value.ToString());
                    using (ContextManager db = new ContextManager())
                    {
                        DeleteRelateMobileNumbers(db.UserRepository.GetNumbersByUserId(cutomerId), db);
                        db.UserRepository.DeleteContact(cutomerId);
                        db.saveChanges();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("رکورد مورد نظر را انتخاب کنید");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            if (addContact.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }

        }

        private void brnEdit_Click(object sender, EventArgs e)
        {
            if (dgUsers.CurrentRow != null)
            {
                int userid = int.Parse(dgUsers.CurrentRow.Cells[0].Value.ToString());
                AddContact addContact = new AddContact();
                addContact.userId = userid;
                if (addContact.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }

            }
            else
            {
                RtlMessageBox.Show("رکورد مورد نظر را انتخاب کنید");
            }
        }

        private void tvShowMobileNumbers_Click(object sender, EventArgs e)
        {
            int userid = int.Parse(dgUsers.CurrentRow.Cells[0].Value.ToString());
            ShowMobileNumbers numbers = new ShowMobileNumbers();
            numbers.userId = userid;
            numbers.ShowDialog();

        }

        private void DeleteRelateMobileNumbers(List<Numbers> numbers, ContextManager db)
        {
            foreach (Numbers number in numbers)
            {
                db.UserRepository.DeleteNumber(number);
            }
        }

        private void tvSendSms_Click(object sender, EventArgs e)
        {
            String name = dgUsers.CurrentRow.Cells[1].Value.ToString() + " " + dgUsers.CurrentRow.Cells[2].Value.ToString();
            SmsText smsFrm = new SmsText();
            smsFrm.fullName = name;
            smsFrm.ShowDialog();
        }
    }
}
