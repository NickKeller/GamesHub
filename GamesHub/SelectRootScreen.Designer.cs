namespace GamesHub
{
    partial class SelectRootScreen
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
            this.gamesRootTextBox = new System.Windows.Forms.TextBox();
            this.ChooseRootButton = new System.Windows.Forms.Button();
            this.gamesRootFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filePathOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify file system path to use";
            // 
            // gamesRootTextBox
            // 
            this.gamesRootTextBox.Location = new System.Drawing.Point(15, 41);
            this.gamesRootTextBox.Name = "gamesRootTextBox";
            this.gamesRootTextBox.Size = new System.Drawing.Size(245, 20);
            this.gamesRootTextBox.TabIndex = 1;
            this.gamesRootTextBox.Text = "Path";
            // 
            // ChooseRootButton
            // 
            this.ChooseRootButton.Location = new System.Drawing.Point(266, 15);
            this.ChooseRootButton.Name = "ChooseRootButton";
            this.ChooseRootButton.Size = new System.Drawing.Size(75, 20);
            this.ChooseRootButton.TabIndex = 2;
            this.ChooseRootButton.Text = " Browse";
            this.ChooseRootButton.UseVisualStyleBackColor = true;
            this.ChooseRootButton.Click += new System.EventHandler(this.ChooseRootButton_Click);
            // 
            // gamesRootFolderBrowserDialog
            // 
            this.gamesRootFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.gamesRootFolderBrowserDialog.SelectedPath = "C:\\";
            this.gamesRootFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // filePathOKButton
            // 
            this.filePathOKButton.Location = new System.Drawing.Point(266, 41);
            this.filePathOKButton.Name = "filePathOKButton";
            this.filePathOKButton.Size = new System.Drawing.Size(75, 20);
            this.filePathOKButton.TabIndex = 3;
            this.filePathOKButton.Text = "OK";
            this.filePathOKButton.UseVisualStyleBackColor = true;
            this.filePathOKButton.Click += new System.EventHandler(this.filePathOKButton_Click);
            // 
            // SelectRootScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 75);
            this.Controls.Add(this.filePathOKButton);
            this.Controls.Add(this.ChooseRootButton);
            this.Controls.Add(this.gamesRootTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectRootScreen";
            this.Text = "Select Root";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gamesRootTextBox;
        private System.Windows.Forms.Button ChooseRootButton;
        private System.Windows.Forms.FolderBrowserDialog gamesRootFolderBrowserDialog;
        private System.Windows.Forms.Button filePathOKButton;
    }
}

