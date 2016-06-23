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

namespace GamesHub
{
    public partial class SelectRootScreen : Form
    {
        public string filePath { get; set; }

        public SelectRootScreen()
        {
            filePath = "";


            InitializeComponent();
        }

        private void ChooseRootButton_Click(object sender, EventArgs e)
        {
            if(gamesRootFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string path = gamesRootFolderBrowserDialog.SelectedPath;
                gamesRootTextBox.Text = path;
                filePath = path;
            }
        }

        private void filePathOKButton_Click(object sender, EventArgs e)
        {
            string path = gamesRootTextBox.Text;
            if (Directory.Exists(path))
            {
                filePath = path;
                Close();
            }
            else
            {
                MessageBox.Show("Error, you must select a valid file path");
            }
        }

        private void gamesRootTextBox_TextChanged(object sender, EventArgs e)
        {
            filePath = gamesRootTextBox.Text;
        }

        public new string ShowDialog()
        {
            return base.ShowDialog() == DialogResult.OK ? filePath : "";
        }
    }
}
