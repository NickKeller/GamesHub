using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesHub
{
    public partial class GamesHubMain : Form
    {
        /// <summary>
        /// Specifies the root for the games on the system
        /// </summary>
        private string root { get; set; }

        public GamesHubMain(string path)
        {
            root = path;

            InitializeComponent();
            //set the label
            this.label1.Text = String.Format("Success! File system path chosen is: {0}", root);
        }
    }
}
