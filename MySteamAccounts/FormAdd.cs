using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySteamAccounts
{
    public partial class FormAdd : Form
    {
        private Size sizeTextBoxMulti = new Size(328, 82);
        private Size sizeTextBoxSingle = new Size(328, 26);

        private Form OwnerForm;

        public FormAdd(Form owner)
        {
            InitializeComponent();
            OwnerForm = owner;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string encrypto = checkBoxCrypto.Checked.ToString();
            string information = textBoxInformation.Text;

            password = encrypto == "True" ? Crypto.EncryptStringAES(password, "MySteamAccounts") : password;

            if (login.Length > 0 && password.Length > 0)
            {
                using (StreamWriter stream = new StreamWriter(@"Accounts\" + login + ".msa"))
                {
                    stream.WriteLine(login);
                    stream.WriteLine(password);
                    stream.WriteLine(encrypto);
                    stream.WriteLine(information);
                    stream.Close();
                }
                MessageBox.Show("Account successfully added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain formMain = (FormMain)OwnerForm;
                formMain.InitializeAccounts();
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
        }

        private void textBoxInformation_Click(object sender, EventArgs e)
        {
            textBoxInformation.Multiline = true;
            textBoxInformation.Size = sizeTextBoxMulti;
        }

        private void FormAdd_Click(object sender, EventArgs e)
        {
            textBoxInformation.Multiline = false;
            textBoxInformation.Size = sizeTextBoxSingle;
        }
    }
}
