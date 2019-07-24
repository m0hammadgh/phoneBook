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
    public partial class ShowMobileNumbers : Form
    {
        public int userId;
        public ShowMobileNumbers()
        {
            InitializeComponent();
        }

        private void ShowMobileNumbers_Load(object sender, EventArgs e)
        {
            using (ContextManager db = new ContextManager())
            {
                dgMobileNUmbers.AutoGenerateColumns = false;
                dgMobileNUmbers.DataSource =
                    db.UserRepository.GetNumbersByUserId(userId);

            }
        }
    }
}
