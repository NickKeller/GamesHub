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
using System.Diagnostics;

namespace GamesHub
{
    public partial class GamesHubMain : Form
    {
        /// <summary>
        /// Specifies the root for the games on the system
        /// </summary>
        private string root { get; set; }

        private Dictionary<string, GamesHubFile> games { get; set; }

        public GamesHubMain()
        {
            root = "";
            games = new Dictionary<string, GamesHubFile>();
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
            var gameDirs = rootDir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            foreach (var gameDir in gameDirs)
            {
                var exeFiles = gameDir.GetFiles("*.exe", SearchOption.TopDirectoryOnly);
                foreach (var item in exeFiles)
                {
                    if (isGame(item.Name))
                    {
                        //get the properties of the exe file
                        FileVersionInfo att = FileVersionInfo.GetVersionInfo(item.FullName);
                        string comments = att.FileDescription;

                        //add to list of games
                        ListViewItem newItem = new ListViewItem(comments);
                        newItem.SubItems.Add(item.FullName);
                        gamesListView.Items.Add(newItem);

                        //add to internal list, for information loading
                        GamesHubFile file = new GamesHubFile(item, att);
                        games.Add(item.FullName, file);
                    }
                }

            }
        }

        private bool isGame(string game)
        {
            string name = game.ToLower();
            return !(name.Contains("config") || name.Contains("setup") || name.Contains("uninstall") || name.Contains("patch"));
        }

        private void addPathButton_Click(object sender, EventArgs e)
        {
            SelectRootScreen screen = new SelectRootScreen();
            root = screen.ShowDialog();
            if (!String.IsNullOrEmpty(root))
                populateList();
        }


        private void gamesListView_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem selectedItem = (sender as ListView).FocusedItem;
            string key = selectedItem.SubItems[1].Text;
            GamesHubFile game = games[key];
            gameInfoPanelLocationTextLabel.Text = game.file.FullName;
            gameInfoPanelNameTextLabel.Text = game.versionInfo.FileDescription;
            gameInfoPanelIcon.Image = Icon.ExtractAssociatedIcon(game.file.FullName).ToBitmap();
        }

        private void gameInfoPanelPlayButton_Click(object sender, EventArgs e)
        {
            //get the game loaded into the info panel
            string gameToPlay = gameInfoPanelLocationTextLabel.Text;
            Process p = new Process();
            p.StartInfo.FileName = gameToPlay;
            p.Start();
        }
    }
}
