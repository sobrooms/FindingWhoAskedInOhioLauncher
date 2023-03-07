namespace FWAiO
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.WinMin = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.Label();
            this.WinExi = new System.Windows.Forms.Button();
            this.TabSwitcher = new System.Windows.Forms.TabControl();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.AboutTab_GameDescription = new System.Windows.Forms.Label();
            this.AboutTab_GameName = new System.Windows.Forms.Label();
            this.DownloadTab = new System.Windows.Forms.TabPage();
            this.playgamebutton = new System.Windows.Forms.Button();
            this.downloadingPanel = new System.Windows.Forms.Panel();
            this.CancelDownload = new System.Windows.Forms.Button();
            this.dlProgressTxt = new System.Windows.Forms.Label();
            this.dlspeed = new System.Windows.Forms.Label();
            this.gmdlpg = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadgamebutton = new System.Windows.Forms.Button();
            this.wm = new System.Windows.Forms.Label();
            this.NoWifiPanel = new System.Windows.Forms.Panel();
            this.NoWifiLabel = new System.Windows.Forms.Label();
            this.lncdl = new System.Windows.Forms.Button();
            this.DLPage_GameVnum = new System.Windows.Forms.Label();
            this.GameName_DownloadTab = new System.Windows.Forms.Label();
            this.SelectGameInstallationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.TabSwitcher.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.DownloadTab.SuspendLayout();
            this.downloadingPanel.SuspendLayout();
            this.NoWifiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WinMin);
            this.panel1.Controls.Add(this.gameName);
            this.panel1.Controls.Add(this.WinExi);
            this.panel1.Controls.Add(this.TabSwitcher);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 486);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // WinMin
            // 
            this.WinMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinMin.Location = new System.Drawing.Point(919, 13);
            this.WinMin.Name = "WinMin";
            this.WinMin.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.WinMin.Size = new System.Drawing.Size(30, 30);
            this.WinMin.TabIndex = 5;
            this.WinMin.Text = "--";
            this.WinMin.UseVisualStyleBackColor = true;
            this.WinMin.Click += new System.EventHandler(this.UI_Button_Minimize_Click);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Cursor = System.Windows.Forms.Cursors.Help;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameName.Location = new System.Drawing.Point(339, 18);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(308, 32);
            this.gameName.TabIndex = 4;
            this.gameName.Text = "Finding Who Asked In Ohio";
            this.gameName.Click += new System.EventHandler(this.ShowAppAbout);
            // 
            // WinExi
            // 
            this.WinExi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinExi.Location = new System.Drawing.Point(955, 13);
            this.WinExi.Name = "WinExi";
            this.WinExi.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.WinExi.Size = new System.Drawing.Size(30, 30);
            this.WinExi.TabIndex = 0;
            this.WinExi.Text = "X";
            this.WinExi.UseVisualStyleBackColor = true;
            this.WinExi.Click += new System.EventHandler(this.UI_Button_Exit_Click);
            // 
            // TabSwitcher
            // 
            this.TabSwitcher.Controls.Add(this.AboutTab);
            this.TabSwitcher.Controls.Add(this.DownloadTab);
            this.TabSwitcher.Location = new System.Drawing.Point(-3, 41);
            this.TabSwitcher.Name = "TabSwitcher";
            this.TabSwitcher.SelectedIndex = 0;
            this.TabSwitcher.Size = new System.Drawing.Size(1004, 452);
            this.TabSwitcher.TabIndex = 2;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.AboutTab_GameDescription);
            this.AboutTab.Controls.Add(this.AboutTab_GameName);
            this.AboutTab.Location = new System.Drawing.Point(4, 24);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(996, 424);
            this.AboutTab.TabIndex = 0;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // AboutTab_GameDescription
            // 
            this.AboutTab_GameDescription.AutoSize = true;
            this.AboutTab_GameDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutTab_GameDescription.Location = new System.Drawing.Point(165, 163);
            this.AboutTab_GameDescription.Name = "AboutTab_GameDescription";
            this.AboutTab_GameDescription.Size = new System.Drawing.Size(688, 50);
            this.AboutTab_GameDescription.TabIndex = 1;
            this.AboutTab_GameDescription.Text = "Mystery adventure game where player solves puzzles\r\nand uncovers clues to find th" +
    "e person who made the mysterious request in Ohio.";
            this.AboutTab_GameDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutTab_GameName
            // 
            this.AboutTab_GameName.AutoSize = true;
            this.AboutTab_GameName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutTab_GameName.Location = new System.Drawing.Point(286, 95);
            this.AboutTab_GameName.Name = "AboutTab_GameName";
            this.AboutTab_GameName.Size = new System.Drawing.Size(447, 47);
            this.AboutTab_GameName.TabIndex = 0;
            this.AboutTab_GameName.Text = "Finding Who Asked In Ohio";
            // 
            // DownloadTab
            // 
            this.DownloadTab.Controls.Add(this.playgamebutton);
            this.DownloadTab.Controls.Add(this.downloadingPanel);
            this.DownloadTab.Controls.Add(this.downloadgamebutton);
            this.DownloadTab.Controls.Add(this.wm);
            this.DownloadTab.Controls.Add(this.NoWifiPanel);
            this.DownloadTab.Controls.Add(this.lncdl);
            this.DownloadTab.Controls.Add(this.DLPage_GameVnum);
            this.DownloadTab.Controls.Add(this.GameName_DownloadTab);
            this.DownloadTab.Location = new System.Drawing.Point(4, 24);
            this.DownloadTab.Name = "DownloadTab";
            this.DownloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTab.Size = new System.Drawing.Size(996, 424);
            this.DownloadTab.TabIndex = 1;
            this.DownloadTab.Text = "Download";
            this.DownloadTab.UseVisualStyleBackColor = true;
            // 
            // playgamebutton
            // 
            this.playgamebutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playgamebutton.Location = new System.Drawing.Point(11, 353);
            this.playgamebutton.Name = "playgamebutton";
            this.playgamebutton.Size = new System.Drawing.Size(299, 58);
            this.playgamebutton.TabIndex = 1;
            this.playgamebutton.Text = "Play";
            this.playgamebutton.UseVisualStyleBackColor = true;
            this.playgamebutton.Visible = false;
            this.playgamebutton.Click += new System.EventHandler(this.PlayGame);
            // 
            // downloadingPanel
            // 
            this.downloadingPanel.Controls.Add(this.CancelDownload);
            this.downloadingPanel.Controls.Add(this.dlProgressTxt);
            this.downloadingPanel.Controls.Add(this.dlspeed);
            this.downloadingPanel.Controls.Add(this.gmdlpg);
            this.downloadingPanel.Controls.Add(this.label1);
            this.downloadingPanel.Location = new System.Drawing.Point(0, 324);
            this.downloadingPanel.Name = "downloadingPanel";
            this.downloadingPanel.Size = new System.Drawing.Size(997, 100);
            this.downloadingPanel.TabIndex = 6;
            this.downloadingPanel.Visible = false;
            // 
            // CancelDownload
            // 
            this.CancelDownload.Location = new System.Drawing.Point(913, 64);
            this.CancelDownload.Name = "CancelDownload";
            this.CancelDownload.Size = new System.Drawing.Size(75, 23);
            this.CancelDownload.TabIndex = 9;
            this.CancelDownload.Text = "Cancel";
            this.CancelDownload.UseVisualStyleBackColor = true;
            this.CancelDownload.Click += new System.EventHandler(this.cancdlbtnclic);
            // 
            // dlProgressTxt
            // 
            this.dlProgressTxt.AutoSize = true;
            this.dlProgressTxt.Location = new System.Drawing.Point(232, 35);
            this.dlProgressTxt.Name = "dlProgressTxt";
            this.dlProgressTxt.Size = new System.Drawing.Size(0, 15);
            this.dlProgressTxt.TabIndex = 8;
            // 
            // dlspeed
            // 
            this.dlspeed.AutoSize = true;
            this.dlspeed.Location = new System.Drawing.Point(192, 35);
            this.dlspeed.Name = "dlspeed";
            this.dlspeed.Size = new System.Drawing.Size(0, 15);
            this.dlspeed.TabIndex = 7;
            // 
            // gmdlpg
            // 
            this.gmdlpg.Location = new System.Drawing.Point(15, 56);
            this.gmdlpg.Name = "gmdlpg";
            this.gmdlpg.Size = new System.Drawing.Size(883, 31);
            this.gmdlpg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Downloading...";
            // 
            // downloadgamebutton
            // 
            this.downloadgamebutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.downloadgamebutton.Location = new System.Drawing.Point(11, 353);
            this.downloadgamebutton.Name = "downloadgamebutton";
            this.downloadgamebutton.Size = new System.Drawing.Size(299, 58);
            this.downloadgamebutton.TabIndex = 2;
            this.downloadgamebutton.Text = "Download/Update";
            this.downloadgamebutton.UseVisualStyleBackColor = true;
            this.downloadgamebutton.Click += new System.EventHandler(this.DownloadGameAndSelctDir);
            // 
            // wm
            // 
            this.wm.AutoSize = true;
            this.wm.Enabled = false;
            this.wm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wm.Location = new System.Drawing.Point(954, 11);
            this.wm.Name = "wm";
            this.wm.Size = new System.Drawing.Size(0, 32);
            this.wm.TabIndex = 7;
            this.wm.Visible = false;
            // 
            // NoWifiPanel
            // 
            this.NoWifiPanel.Controls.Add(this.NoWifiLabel);
            this.NoWifiPanel.Cursor = System.Windows.Forms.Cursors.No;
            this.NoWifiPanel.Location = new System.Drawing.Point(974, 56);
            this.NoWifiPanel.Name = "NoWifiPanel";
            this.NoWifiPanel.Size = new System.Drawing.Size(992, 418);
            this.NoWifiPanel.TabIndex = 4;
            this.NoWifiPanel.Visible = false;
            // 
            // NoWifiLabel
            // 
            this.NoWifiLabel.AutoSize = true;
            this.NoWifiLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoWifiLabel.Location = new System.Drawing.Point(4, 7);
            this.NoWifiLabel.Name = "NoWifiLabel";
            this.NoWifiLabel.Size = new System.Drawing.Size(457, 40);
            this.NoWifiLabel.TabIndex = 0;
            this.NoWifiLabel.Text = "HAHA NO INTERNET!!!!!!!!!!!!!!!11!\\";
            // 
            // lncdl
            // 
            this.lncdl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lncdl.Location = new System.Drawing.Point(316, 353);
            this.lncdl.Name = "lncdl";
            this.lncdl.Size = new System.Drawing.Size(299, 58);
            this.lncdl.TabIndex = 2;
            this.lncdl.Text = "Download latest launcher";
            this.lncdl.UseVisualStyleBackColor = true;
            this.lncdl.Click += new System.EventHandler(this.DownloadLaunAndSelctDir);
            // 
            // DLPage_GameVnum
            // 
            this.DLPage_GameVnum.AutoSize = true;
            this.DLPage_GameVnum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DLPage_GameVnum.Location = new System.Drawing.Point(6, 43);
            this.DLPage_GameVnum.Name = "DLPage_GameVnum";
            this.DLPage_GameVnum.Size = new System.Drawing.Size(134, 21);
            this.DLPage_GameVnum.TabIndex = 1;
            this.DLPage_GameVnum.Text = "Version: unknown";
            // 
            // GameName_DownloadTab
            // 
            this.GameName_DownloadTab.AutoSize = true;
            this.GameName_DownloadTab.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameName_DownloadTab.Location = new System.Drawing.Point(3, 3);
            this.GameName_DownloadTab.Name = "GameName_DownloadTab";
            this.GameName_DownloadTab.Size = new System.Drawing.Size(263, 40);
            this.GameName_DownloadTab.TabIndex = 0;
            this.GameName_DownloadTab.Text = "Download - FWAiO";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(997, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Finding Who Asked In Ohio";
            this.Load += new System.EventHandler(this.InitialLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabSwitcher.ResumeLayout(false);
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            this.DownloadTab.ResumeLayout(false);
            this.DownloadTab.PerformLayout();
            this.downloadingPanel.ResumeLayout(false);
            this.downloadingPanel.PerformLayout();
            this.NoWifiPanel.ResumeLayout(false);
            this.NoWifiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button WinExi;
        private TabControl TabSwitcher;
        private TabPage AboutTab;
        private Label AboutTab_GameDescription;
        private Label AboutTab_GameName;
        private TabPage DownloadTab;
        private Label gameName;
        private Button WinMin;
        private Label DLPage_GameVnum;
        private Label GameName_DownloadTab;
        private Button lncdl;
        private Panel NoWifiPanel;
        private Label NoWifiLabel;
        private FolderBrowserDialog SelectGameInstallationFolder;
        private Label label1;
        private Panel downloadingPanel;
        private ProgressBar gmdlpg;
        private Label dlspeed;
        private Label dlProgressTxt;
        private Button CancelDownload;
        private Label wm;
        private Button downloadgamebutton;
        private Button playgamebutton;
    }
}