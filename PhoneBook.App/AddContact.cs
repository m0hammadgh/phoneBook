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
        public int tvId = 0;
        private List<TextBox> tvNumbersList = new List<TextBox>();
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
                        db.UserRepository.UpdateContact(CreateSampleEditableUser());
                    }
                    db.saveChanges();
                }


                DialogResult = DialogResult.OK;
            }
        }

        private User CreateSampleuser()

        {
            var count = getMobileNumbers().Count;

            User user=new  User()
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


            return user;


        }
        private User CreateSampleEditableUser() => new User
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

        private void btnAddMobileNumber_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Name = "textBox" + tvId;
            panelNumbers.Controls.Add(textBox);
            tvNumbersList.Add(textBox);

        }

        public List<String> getMobileNumbers()
        {
            List<String> numbers = new List<string>();
            for (int i1 = 0; i1 < tvNumbersList.Count; i1++)
            {
                TextBox i = tvNumbersList[i1];
                numbers.Add(i.Text);
            }
            return numbers;
        }
    }
}



