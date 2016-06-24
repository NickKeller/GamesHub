using System;

namespace GamesHub
{
    partial class GamesHubMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addPathButton = new System.Windows.Forms.Button();
            this.gameInfoPanelNameLabel = new System.Windows.Forms.Label();
            this.gameInfoPanelNameTextLabel = new System.Windows.Forms.Label();
            this.gameInfoPanelLocationLabel = new System.Windows.Forms.Label();
            this.gameInfoPanelLocationTextLabel = new System.Windows.Forms.Label();
            this.gameInfoPanelIcon = new System.Windows.Forms.PictureBox();
            this.gameInfoPanelPlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameInfoPanelIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games:";
            // 
            // gamesListView
            // 
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.LocationColumnHeader});
            this.gamesListView.Location = new System.Drawing.Point(12, 25);
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.Size = new System.Drawing.Size(407, 382);
            this.gamesListView.TabIndex = 1;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.ItemActivate += new System.EventHandler(this.gamesListView_ItemActivate);
            // 
            // NameColumnHeader
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 145;
            // 
            // LocationColumnHeader
            // 
            this.LocationColumnHeader.Text = "Location";
            this.LocationColumnHeader.Width = 258;
            // 
            // addPathButton
            // 
            this.addPathButton.Location = new System.Drawing.Point(705, 25);
            this.addPathButton.Name = "addPathButton";
            this.addPathButton.Size = new System.Drawing.Size(75, 23);
            this.addPathButton.TabIndex = 2;
            this.addPathButton.Text = "Add Path";
            this.addPathButton.UseVisualStyleBackColor = true;
            this.addPathButton.Click += new System.EventHandler(this.addPathButton_Click);
            // 
            // gameInfoPanelNameLabel
            // 
            this.gameInfoPanelNameLabel.AutoSize = true;
            this.gameInfoPanelNameLabel.Location = new System.Drawing.Point(425, 216);
            this.gameInfoPanelNameLabel.Name = "gameInfoPanelNameLabel";
            this.gameInfoPanelNameLabel.Size = new System.Drawing.Size(38, 13);
            this.gameInfoPanelNameLabel.TabIndex = 3;
            this.gameInfoPanelNameLabel.Text = "Name:";
            // 
            // gameInfoPanelNameTextLabel
            // 
            this.gameInfoPanelNameTextLabel.AutoSize = true;
            this.gameInfoPanelNameTextLabel.Location = new System.Drawing.Point(479, 216);
            this.gameInfoPanelNameTextLabel.Name = "gameInfoPanelNameTextLabel";
            this.gameInfoPanelNameTextLabel.Size = new System.Drawing.Size(0, 13);
            this.gameInfoPanelNameTextLabel.TabIndex = 4;
            // 
            // gameInfoPanelLocationLabel
            // 
            this.gameInfoPanelLocationLabel.AutoSize = true;
            this.gameInfoPanelLocationLabel.Location = new System.Drawing.Point(425, 259);
            this.gameInfoPanelLocationLabel.Name = "gameInfoPanelLocationLabel";
            this.gameInfoPanelLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.gameInfoPanelLocationLabel.TabIndex = 5;
            this.gameInfoPanelLocationLabel.Text = "Location:";
            // 
            // gameInfoPanelLocationTextLabel
            // 
            this.gameInfoPanelLocationTextLabel.AutoSize = true;
            this.gameInfoPanelLocationTextLabel.Location = new System.Drawing.Point(479, 259);
            this.gameInfoPanelLocationTextLabel.Name = "gameInfoPanelLocationTextLabel";
            this.gameInfoPanelLocationTextLabel.Size = new System.Drawing.Size(0, 13);
            this.gameInfoPanelLocationTextLabel.TabIndex = 6;
            // 
            // gameInfoPanelIcon
            // 
            this.gameInfoPanelIcon.Location = new System.Drawing.Point(428, 60);
            this.gameInfoPanelIcon.Name = "gameInfoPanelIcon";
            this.gameInfoPanelIcon.Size = new System.Drawing.Size(111, 96);
            this.gameInfoPanelIcon.TabIndex = 7;
            this.gameInfoPanelIcon.TabStop = false;
            // 
            // gameInfoPanelPlayButton
            // 
            this.gameInfoPanelPlayButton.Location = new System.Drawing.Point(428, 296);
            this.gameInfoPanelPlayButton.Name = "gameInfoPanelPlayButton";
            this.gameInfoPanelPlayButton.Size = new System.Drawing.Size(75, 23);
            this.gameInfoPanelPlayButton.TabIndex = 8;
            this.gameInfoPanelPlayButton.Text = "Play";
            this.gameInfoPanelPlayButton.UseVisualStyleBackColor = true;
            this.gameInfoPanelPlayButton.Click += new System.EventHandler(this.gameInfoPanelPlayButton_Click);
            // 
            // GamesHubMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.gameInfoPanelPlayButton);
            this.Controls.Add(this.gameInfoPanelIcon);
            this.Controls.Add(this.gameInfoPanelLocationTextLabel);
            this.Controls.Add(this.gameInfoPanelLocationLabel);
            this.Controls.Add(this.gameInfoPanelNameTextLabel);
            this.Controls.Add(this.gameInfoPanelNameLabel);
            this.Controls.Add(this.addPathButton);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.label1);
            this.Name = "GamesHubMain";
            this.Text = "GamesHubMain";
            ((System.ComponentModel.ISupportInitialize)(this.gameInfoPanelIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.Button addPathButton;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader LocationColumnHeader;
        private System.Windows.Forms.Label gameInfoPanelNameLabel;
        private System.Windows.Forms.Label gameInfoPanelNameTextLabel;
        private System.Windows.Forms.Label gameInfoPanelLocationLabel;
        private System.Windows.Forms.Label gameInfoPanelLocationTextLabel;
        private System.Windows.Forms.PictureBox gameInfoPanelIcon;
        private System.Windows.Forms.Button gameInfoPanelPlayButton;
    }
}