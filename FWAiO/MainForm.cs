using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text.Json;
namespace FWAiO
{
    public partial class MainForm : Form
    {
        private bool GameVersionIsLatest = true;
        DirectoryInfo GameAppData = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "\\sobrooms\\FWAiO_(laun)");
        Point lastPoint;
        private string LocalGVer = "alpha_0.5.4\n";
        WebClient client = new();
        bool GameDownloadCanceled;
        public MainForm()
        {
            InitializeComponent();
        }
        private void UI_Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UI_Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ShowAppAbout(object sender, EventArgs e)
        {
            AppAbout appAboutForm = new AppAbout();
            appAboutForm.Show();
        }

        private async Task DownloadFile(string url, string outfile, bool DeleteAnywayIfExists)
        {
            try
            {
                WebClient client = new WebClient();
                if (!File.Exists(Path.Combine(outfile)))
                {
                    await client.DownloadFileTaskAsync(url, outfile);
                }
                else if (File.Exists(Path.Combine(outfile)) && !DeleteAnywayIfExists)
                {
                    Console.WriteLine("Skipped file download since file already exists (" + outfile + ")");
                }
                else if (File.Exists(Path.Combine(outfile)) && DeleteAnywayIfExists)
                {
                    File.Delete(Path.Combine(outfile));
                    Console.WriteLine("Deleted " + outfile + "");
                    await client.DownloadFileTaskAsync(url, outfile);
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString() == "System.Net.WebException")
                {
                    Console.WriteLine("Failed to download file: Invalid file url (" + url + ")");
                }
                else
                {
                    Console.WriteLine("Error: ", ex);
                }
            }
        }

        private async void InitialLoad(object sender, EventArgs e)
        {
            // get game version, overwrite if it exists anyway
            MainForm main = new MainForm();
            string sbrAD = Path.Combine(GameAppData.FullName).ToString() + "/";
            //await DownloadFile("https://site-psa-mang.vercel.app/GameVersion.wai.txt", sbrAD + ".gamev", true);
            await new WebClient().DownloadFileTaskAsync("https://site-psa-mang.vercel.app/GameVersion.wai.txt", sbrAD + ".gamev");


            // dbg
            if (File.ReadAllText(@sbrAD + ".gamev") != LocalGVer)
            {
                await WriteLog("current gv != localgv, please update");
                GameVersionIsLatest = false;
            }
            SetDbgDetails();
            if (Internet())
            {
                this.NoWifiPanel.Visible = false;
            }
            else
            {
                this.NoWifiPanel.Visible = true;
                this.NoWifiLabel.Text = "Not connected to internet. \r\nCannot download the game.\nSorry, " + System.Environment.UserName + ".";
            }
            if (File.Exists(@GameAppData + "/.gamepath"))
            {
                if (GameVersionIsLatest && File.Exists(File.ReadAllText(@GameAppData + "/.gamepath") + "/FindingWhoAskedInOhio.exe"))
                {
                    this.playgamebutton.Visible = true;
                    this.downloadgamebutton.Visible = false;
                }
            }
        }

        private async void SetDbgDetails()
        {
            string sbrAD = Path.Combine(GameAppData.FullName).ToString() + "/";

            await Task.Run(() =>
            {
                if (this.DLPage_GameVnum.InvokeRequired)
                {
                    this.DLPage_GameVnum.Invoke(new Action(() =>
                    {
                        //Thread.Sleep(6000);
                        this.DLPage_GameVnum.Text = "Latest Game Version: " + File.ReadAllText(@sbrAD + ".gamev"); ;
                        this.DLPage_GameVnum.Invalidate();
                        this.DLPage_GameVnum.Update();
                    }));
                }
                else
                {
                    //Thread.Sleep(6000);
                    this.DLPage_GameVnum.Text = "Latest Game Version: " + File.ReadAllText(@sbrAD + ".gamev");
                    this.DLPage_GameVnum.Invalidate();
                    this.DLPage_GameVnum.Update();
                }
            });
        }
        public static bool Internet()
        {
            Ping mp = new Ping();
            String host = "8.8.8.8";
            byte[] buffer = new byte[32];
            int timeout = 1000;
            PingOptions pingOptions = new();
            PingReply reply = mp.Send(host, timeout, buffer, pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else return false;
        }
        public async Task WriteLog(string content)
        {
            var LogPath = Path.Combine(GameAppData.FullName + "/app.log");
            if (!File.Exists(LogPath))
                File.WriteAllText(LogPath, "");
            else
            {
                // get current content
                string curFC = await File.ReadAllTextAsync(LogPath);
                // write content
                string outTxt = curFC + "\n[" + DateTime.Now.ToString("hh:mm:ss dddd, MMMM yyyy") + "] " + content;
                await File.WriteAllTextAsync(LogPath, outTxt);
            }
        }

        private async Task DownloadLaunAndSelctDirObj()
        {
            using (var fbd = this.SelectGameInstallationFolder)
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Directory.GetFiles(fbd.SelectedPath).Length > 0)
                    {
                        var cm = MessageBox.Show("Please select a folder with no files in it.", "Latest Launcher Installation", MessageBoxButtons.OKCancel);
                        if (cm == DialogResult.OK)
                        {
                            await DownloadLaunAndSelctDirObj();
                        }
                    }
                    else
                    {
                        var cm = MessageBox.Show("Are you sure you want to install the launcher in the selected directory? (" + fbd.SelectedPath + ")", "Launcher Installation", MessageBoxButtons.YesNo);
                        if (cm == DialogResult.Yes)
                        {
                            this.wm.Visible = false;
                            GameDownloadCanceled = false;
                            this.downloadgamebutton.Visible = false;
                            this.playgamebutton.Visible = false;
                            this.lncdl.Visible = false;
                            this.downloadingPanel.Visible = true;
                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(LauncherDownloadComplete);
                            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                            await client.DownloadFileTaskAsync(new Uri(await new HttpClient().GetStringAsync("https://site-psa-mang.vercel.app/Download.lu.wai.txt")), GameAppData + "/app.zip");
                            System.IO.Compression.ZipFile.ExtractToDirectory(GameAppData + "/app.zip", fbd.SelectedPath);
                            File.Delete(GameAppData + "/app.zip");
                            this.downloadgamebutton.Visible = true;
                            this.playgamebutton.Visible = true;
                            this.lncdl.Visible = true;
                        }
                    }
                }
            }
        }
        private async Task DownloadGameAndSelctDirObj()
        {
            using (var fbd = this.SelectGameInstallationFolder)
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (Directory.GetFiles(fbd.SelectedPath).Length > 0)
                    {
                        var cm = MessageBox.Show("Please select a folder with no files in it.", "Latest Launcher Installation", MessageBoxButtons.OKCancel);
                        if (cm == DialogResult.OK)
                        {
                            await DownloadGameAndSelctDirObj();
                        }
                    }
                    else
                    {
                        var cm = MessageBox.Show("Are you sure you want to install the game in the selected directory? (" + fbd.SelectedPath + ")", "Game Installation", MessageBoxButtons.YesNo);
                        if (cm == DialogResult.Yes)
                        {
                            this.wm.Visible = false;
                            GameDownloadCanceled = false;
                            this.downloadingPanel.Visible = true;
                            this.downloadgamebutton.Visible = false;
                            this.playgamebutton.Visible = false;
                            this.lncdl.Visible = false;
                            client.DownloadFileCompleted += new AsyncCompletedEventHandler(GameDownloadCompleted);
                            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                            await client.DownloadFileTaskAsync(new Uri(await new HttpClient().GetStringAsync("https://site-psa-mang.vercel.app/Download.wai.txt")), GameAppData + "/game.zip");
                            System.IO.Compression.ZipFile.ExtractToDirectory(GameAppData + "/game.zip", fbd.SelectedPath);
                            File.Delete(GameAppData + "/game.zip");
                            await File.WriteAllTextAsync(GameAppData + "/.gamepath", fbd.SelectedPath, System.Text.Encoding.UTF8);
                        }
                    }
                }
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Stopwatch sw = new();
            this.gmdlpg.Value = e.ProgressPercentage;
            this.dlspeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            this.dlProgressTxt.Text = string.Format("{0}MB / {1}MB", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        private void GameDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.downloadingPanel.Visible = false;
            this.lncdl.Visible = true;
            this.playgamebutton.Visible = true;
            this.downloadgamebutton.Visible = false;
            this.wm.Visible = true;
            if (GameDownloadCanceled) { } else MessageBox.Show("The game has been downloaded completely at " + this.SelectGameInstallationFolder.SelectedPath, "Download complete", MessageBoxButtons.OK);
        }
        private void LauncherDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            this.wm.Visible = true;
            this.downloadingPanel.Visible = false;
            this.lncdl.Visible = true;
            if (File.Exists(@GameAppData + "/.gamepath"))
            {
                if (GameVersionIsLatest && File.Exists(File.ReadAllText(@GameAppData + "/.gamepath") + "/FindingWhoAskedInOhio.exe"))
                {
                    this.playgamebutton.Visible = true;
                    this.downloadgamebutton.Visible = false;
                }
            }
            if (GameDownloadCanceled) { } else MessageBox.Show("The latest launcher has been downloaded completely at " + this.SelectGameInstallationFolder.SelectedPath + ". Please delete this version from your computer and use the latest...", "Download complete", MessageBoxButtons.OK);
        }

        private void cancdlbtnclic(object sender, EventArgs e)
        {
            var cm = MessageBox.Show("Are you sure you want to cancel the download?", "Cancel download", MessageBoxButtons.YesNo);
            if (cm == DialogResult.Yes)
            {
                GameDownloadCanceled = true;
                client.CancelAsync();
                this.downloadingPanel.Visible = false;
                MessageBox.Show("Canceled download.", "", MessageBoxButtons.OK);
                File.Delete(GameAppData + "/app.zip");
                client.Dispose();
            }
            else
            {
                return;
            }
        }

        private async void DownloadLaunAndSelctDir(object sender, EventArgs e)
        {
            await DownloadLaunAndSelctDirObj();
        }
        private async void DownloadGameAndSelctDir(object sender, EventArgs e)
        {
            await DownloadGameAndSelctDirObj();
        }
        private async Task PlayGameObj()
        {
            ProcessStartInfo A = new(@File.ReadAllText(GameAppData + "/.gamepath").ToString() + "/FindingWhoAskedInOhio.exe");
            Process.Start(A);
        }
        private void PlayGame(object sender, EventArgs e)
        {
            PlayGameObj();
        }
    }
}