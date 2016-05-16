namespace Launchpad.Launcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.changelogBrowser = new System.Windows.Forms.WebBrowser();
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.PrimaryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ManifestProgressLabel = new System.Windows.Forms.Label();
            this.DownloadProgressBar = new Launchpad.Launcher.ProgressBarEx();
            this.mainProgressBar = new Launchpad.Launcher.ProgressBarEx();
            this.SuspendLayout();
            // 
            // changelogBrowser
            // 
            resources.ApplyResources(this.changelogBrowser, "changelogBrowser");
            this.changelogBrowser.Name = "changelogBrowser";
            this.changelogBrowser.ScrollBarsEnabled = false;
            // 
            // downloadProgressLabel
            // 
            resources.ApplyResources(this.downloadProgressLabel, "downloadProgressLabel");
            this.downloadProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            // 
            // PrimaryButton
            // 
            resources.ApplyResources(this.PrimaryButton, "PrimaryButton");
            this.PrimaryButton.BackColor = System.Drawing.Color.Transparent;
            this.PrimaryButton.BackgroundImage = global::Launchpad.Launcher.Properties.Resources.Treees_KSButton_Login;
            this.PrimaryButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PrimaryButton.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.PrimaryButton.FlatAppearance.BorderSize = 0;
            this.PrimaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrimaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PrimaryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PrimaryButton.Name = "PrimaryButton";
            this.PrimaryButton.UseVisualStyleBackColor = false;
            this.PrimaryButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = global::Launchpad.Launcher.Properties.Resources.Treees_KSClose_red_fixed;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // UsernameLabel
            // 
            resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Name = "UsernameLabel";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // UsernameTextBox
            // 
            resources.ApplyResources(this.UsernameTextBox, "UsernameTextBox");
            this.UsernameTextBox.Name = "UsernameTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            // 
            // MessageLabel
            // 
            resources.ApplyResources(this.MessageLabel, "MessageLabel");
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Name = "MessageLabel";
            // 
            // ManifestProgressLabel
            // 
            resources.ApplyResources(this.ManifestProgressLabel, "ManifestProgressLabel");
            this.ManifestProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManifestProgressLabel.Name = "ManifestProgressLabel";
            // 
            // DownloadProgressBar
            // 
            resources.ApplyResources(this.DownloadProgressBar, "DownloadProgressBar");
            this.DownloadProgressBar.BackColor = System.Drawing.Color.White;
            this.DownloadProgressBar.ForeColor = System.Drawing.Color.Gold;
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // mainProgressBar
            // 
            resources.ApplyResources(this.mainProgressBar, "mainProgressBar");
            this.mainProgressBar.BackColor = System.Drawing.Color.White;
            this.mainProgressBar.ForeColor = System.Drawing.Color.Gold;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // MainForm
            // 
            this.AcceptButton = this.PrimaryButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Launchpad.Launcher.Properties.Resources.SwatchBlue_Titans_LauncherArt2b;
            this.Controls.Add(this.ManifestProgressLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.PrimaryButton);
            this.Controls.Add(this.downloadProgressLabel);
            this.Controls.Add(this.mainProgressBar);
            this.Controls.Add(this.changelogBrowser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser changelogBrowser;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.Button PrimaryButton;
        private System.Windows.Forms.Button closeButton;
        private ProgressBarEx mainProgressBar;
        private ProgressBarEx DownloadProgressBar;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label ManifestProgressLabel;
    }
}

