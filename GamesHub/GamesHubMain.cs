using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GamesHub
{
    public partial class GamesHubMain : Form
    {
        /// <summary>
        /// Specifies the root for the games on the system
        /// </summary>
        private string root { get; set; }

        public GamesHubMain()
        {
            root = "";
            InitializeComponent();

            if (!String.IsNullOrEmpty(root))
            {
                populateList();
            }
        }

        private void populateList()
        {
            //set the label
            this.label1.Text = String.Format("Success! File system path chosen is: {0}", root);

            //populate the list view
            DirectoryInfo rootDir = new DirectoryInfo(root);
            var exeFiles = rootDir.GetFiles("*.exe", SearchOption.AllDirectories);
            foreach (var exeFile in exeFiles)
            {
                string name = exeFile.FullName;
                ListViewItem item = new ListViewItem(name);
                gamesListView.Items.Add(item);
            }
        }
    }
}
