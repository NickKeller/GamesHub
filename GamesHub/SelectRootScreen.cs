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
        private string filePath { get; set; }

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
                Program.path = filePath;
                Close();
            }
            else
            {
                MessageBox.Show("Error, you must select a valid file path");
            }
        }
    }
}
