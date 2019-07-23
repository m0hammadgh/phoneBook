using PhoneBook_DbLayer;
using PhoneBook_DbLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace PhoneBook.App
{
    public partial class AddContact : Form
    {
        public int userId = 0;
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pcUser.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcUser.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcUser.Image.Save(path + imageName);
                using (ContextManager db = new ContextManager())
                {
                    if (userId == 0)
                    {
                        db.UserRepository.AddNewContact(CreateSampleuser());
                    }
                    else
                    {
                        db.UserRepository.UpdateContact(CreateEdituser());
                    }
                    db.saveChanges();
                }


                DialogResult = DialogResult.OK;
            }
        }

        private User CreateSampleuser() => new User
        {
            Address = tvAddress.Text,
            CityCode = tvCityCode.Text,
            Email = tvEmail.Text,
            HomeNumber = tvHomePhone.Text,
            Name = tvName.Text,
            LastName = tvLastName.Text,
            NationalCode = tvNationalCode.Text,
            BirthDate = dtPicker.Value,
            ProfilePic = "noImage.jpg"


        };
        private User CreateEdituser() => new User
        {
            UserId = userId,
            Address = tvAddress.Text,
            CityCode = tvCityCode.Text,
            Email = tvEmail.Text,
            HomeNumber = tvHomePhone.Text,
            Name = tvName.Text,
            LastName = tvLastName.Text,
            NationalCode = tvNationalCode.Text,
            BirthDate = dtPicker.Value,
            ProfilePic = "noImage.jpg"


        };

        private void AddContact_Load(object sender, EventArgs e)
        {
            if (userId != 0)
            {
                this.Text = "ویرایش";
                btnSave.Text = "ثبت تغییرات";
                using (ContextManager db = new ContextManager())
                {
                    var user = db.UserRepository.GetContactById(userId);
                    BindEditUserData(user);
                }

            }
        }

        private void BindEditUserData(User user)
        {
            tvAddress.Text = user.Address;
            tvCityCode.Text = user.CityCode;
            tvEmail.Text = user.Email;
            tvHomePhone.Text = user.HomeNumber;
            tvLastName.Text = user.LastName;
            tvName.Text = user.Name;
            tvNationalCode.Text = user.NationalCode;
        }
    }
}



