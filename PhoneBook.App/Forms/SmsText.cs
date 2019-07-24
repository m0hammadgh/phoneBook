using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.App.Forms
{
    public partial class SmsText : Form
    {
        public string fullName;
        public SmsText()
        {
            InitializeComponent();
        }

        private void SmsText_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSendSms_Click(object sender, EventArgs e) => RtlMessageBox.Show($"پیامک به {fullName} ارسال شد");
    }
}
