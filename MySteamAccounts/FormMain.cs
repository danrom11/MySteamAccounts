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
    public partial class FormMain : Form
    {
        private List<masFiles> Accounts = new List<masFiles>();
        private string pathSteam;
        private int selectedIndex = -1;
        

        public FormMain()
        {
            InitializeComponent();
            InitializeAccounts();
            InitializeAccountsSystem();
            InitializeContextMenuStrip();
        }

        private void InitializeContextMenuStrip()
        {
            addToolStripMenuItem.Click += (s, e) =>
            {
                FormAdd formAdd = new FormAdd(this);
                formAdd.Show();
            };
            deleteToolStripMenuItem.Click += (s, e) =>
            {
                
                if(selectedIndex > -1)
                {
                    DialogResult deletedACC = MessageBox.Show("Are you sure you want to delete " + listBoxAccounts.Items[selectedIndex].ToString() + "'s account ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(deletedACC == DialogResult.Yes)
                    {
                        File.Delete(@"Accounts/" + listBoxAccounts.Items[selectedIndex].ToString() + ".msa");
                        MessageBox.Show("Account " + listBoxAccounts.Items[selectedIndex].ToString() + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InitializeAccounts();
                    }            
                }
            };
            startSteamToolStripMenuItem.Click += (s, e) =>
            {
                selectedIndex = listBoxAccounts.SelectedIndex;
                if (selectedIndex > -1)
                    MySteamAccounts.FilesSystem.StartSteam(Accounts[selectedIndex].login, Accounts[selectedIndex].crypto == "True" ? Crypto.DecryptStringAES(Accounts[selectedIndex].password, "MySteamAccounts") : Accounts[selectedIndex].password, pathSteam);
            };
        }

        private void InitializeAccountsSystem()
        {
            pathSteam = MySteamAccounts.FilesSystem.GetPathSteam();
            if (pathSteam == "null")
                MessageBox.Show("Could not find the path to steam.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);     
        }

        public void InitializeAccounts()
        {
            Accounts.Clear();
            listBoxAccounts.Items.Clear();

            string[] filse = Directory.GetFiles(@"Accounts", "*.msa");
            for (int i = 0; i < filse.Length; i++)
            {
                Console.WriteLine("Yes File");
                string[] content = File.ReadAllLines(filse[i]);
                string[] information = new string[content.Length - 3];
                for (int m = 3; m < content.Length; m++)
                    information[m - 3] = content[m];
                
                Accounts.Add(new masFiles(content[0], content[1], content[2], information));
                listBoxAccounts.Items.Add(Accounts[i].login);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.Show();      
        }

        private void listBoxAccounts_Click(object sender, EventArgs e)
        {
            textBoxInformation.Clear();
            selectedIndex = listBoxAccounts.SelectedIndex;
            if(selectedIndex > -1)
                for (int i = 0; i < Accounts[selectedIndex].information.Length; i++)
                    textBoxInformation.Text += Accounts[selectedIndex].information[i] + "\r\n";

        }

        private void listBoxAccounts_DoubleClick(object sender, EventArgs e)
        {
            selectedIndex = listBoxAccounts.SelectedIndex;
            if(selectedIndex > -1)             
                MySteamAccounts.FilesSystem.StartSteam(Accounts[selectedIndex].login, Accounts[selectedIndex].crypto == "True" ? Crypto.DecryptStringAES(Accounts[selectedIndex].password, "MySteamAccounts") : Accounts[selectedIndex].password, pathSteam);
        }
    }
}
