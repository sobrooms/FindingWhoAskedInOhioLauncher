using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text.Json;
namespace FWAiO
{
    public partial class MainForm : Form
    {
        DirectoryInfo GameAppData = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)) + "\\sobrooms\\FWAiO_(laun)");
        Point lastPoint;
        private string LocalGVer = "alpha_0.0.5";
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
                await WriteLog("current gv != localgv, please update");
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

        private async void DownloadGameAndSelctDir(object sender, EventArgs e)
        {
            await DownloadGameAndSelctDirObj();
        }
        private async Task DownloadGameAndSelctDirObj()
        {
            using (var fbd = this.SelectGameInstallationFolder)
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    if (Directory.GetFiles(fbd.SelectedPath).Length > 0)
                    {
                        var cm = MessageBox.Show("Please select a folder with no files in it.", "Game Installation", MessageBoxButtons.OKCancel);
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
                            await new WebClient().DownloadFileTaskAsync("https://cdn.discordapp.com/attachments/1078550595092369488/1078669027276238928/Lyuuxploit_v0.6.zip", GameAppData + "/app.zip");
                            System.IO.Compression.ZipFile.ExtractToDirectory(GameAppData + "/app.zip", fbd.SelectedPath);
                            File.Delete(GameAppData + "/app.zip");
                        }
                    }
                }
            }
        }
    }
}