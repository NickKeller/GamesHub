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
            this.addPathButton = new System.Windows.Forms.Button();
            this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // Name
            // 
            this.NameColumnHeader.Text = "Name";
            this.NameColumnHeader.Width = 145;
            // 
            // Location
            // 
            this.LocationColumnHeader.Text = "Location";
            this.LocationColumnHeader.Width = 258;
            // 
            // GamesHubMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.addPathButton);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.label1);
            this.Name = "GamesHubMain";
            this.Text = "GamesHubMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.Button addPathButton;
        private System.Windows.Forms.ColumnHeader NameColumnHeader;
        private System.Windows.Forms.ColumnHeader LocationColumnHeader;
    }
}