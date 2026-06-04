using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net.Http;
using System.Text;
using System.Net.NetworkInformation;

namespace Proect_po_info
{

    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> wingetCommands = new List<string>();

            var applications = new[]
            {
                // === BROWSERS ===
                new { Box = checkBoxChrome,      Name = "Google Chrome",   Id = "Google.Chrome" },
                new { Box = checkBoxBrave,       Name = "Brave Browser",   Id = "Brave.Brave" },
                new { Box = checkBoxOperaGX,     Name = "Opera GX",        Id = "Opera.OperaGX" },
                new { Box = checkBoxTor,         Name = "Tor Browser",     Id = "TorProject.TorBrowser" },

                // === FILE SHARING & COMPRESSION ===
                new { Box = checkBoxQbittorrent, Name = "qBittorrent",     Id = "qbittorrent.qBittorrent" },
                new { Box = checkBoxWinRAR,      Name = "WinRAR",          Id = "RARLab.WinRAR" },
                new { Box = checkBox7Zip,        Name = "7-Zip",           Id = "7zip.7zip" },

                // === MEDIA ===
                new { Box = checkBoxDiscord,     Name = "Discord",         Id = "Discord.Discord" },
                new { Box = checkBoxSpotify,     Name = "Spotify",         Id = "Spotify.Spotify" },
                new { Box = checkBoxInstagram,   Name = "Instagram",       Id = "Facebook.Instagram" },

                // === PLATFORMS ===
                new { Box = checkBoxSteam,       Name = "Steam",           Id = "Value.Steam" },
                new { Box = checkBoxEpicGames,   Name = "Epic Games",      Id = "EpicGames.EpicGamesLauncher" },
                new { Box = checkBoxUbisoft,     Name = "Ubisoft",         Id = "Ubisoft.Connect" },
                new { Box = checkBoxWargaming,   Name = "Wargaming",       Id = "Wargaming.GameCenter" },

                // === DRIVERS ===
                new { Box = checkBoxLogitech,    Name = "Logitech G HUB",  Id = "Logitech.GHUB" },
                new { Box = checkBoxNvidia,      Name = "NVIDIA Software", Id = "Nvidia.GeForceExperience" },
                new { Box = checkBoxAMD,         Name = "AMD Software",    Id = "AMD.RyzenMaster" },
                new { Box = checkBoxIntel,       Name = "Intel Driver",    Id = "Intel.IntelDriverAndSupportAssistant" },

                // === SECURITY ===
                new { Box = checkBoxAvast,       Name = "Avast Antivirus", Id = "Avast.AvastAntivirus" },
                new { Box = checkBoxNordVPN,     Name = "NordVPN",         Id = "NordSecurity.NordVPN" },
                new { Box = checkBoxProtonVPN,   Name = "Proton VPN",      Id = "Proton.ProtonVPN" },

                // === DEVELOPER TOOLS ===
                new { Box = checkBoxVSCode,      Name = "VS Code",         Id = "Microsoft.VisualStudioCode" },
                new { Box = checkBoxVS,          Name = "Visual Studio",   Id = "Microsoft.VisualStudio.2022.Community" },
                new { Box = checkBoxPython,      Name = "Python",          Id = "Python.Python.3" },
                new { Box = checkBoxGit,         Name = "Git",             Id = "Git.Git" },
                new { Box = checkBoxGitHub,      Name = "GitHub Desktop",  Id = "GitHub.GitHubDesktop" },
                new { Box = checkBoxJava,        Name = "Java",            Id = "Oracle.JDK" },
                new { Box = checkBoxNotepad,     Name = "Notepad++",       Id = "NotepadPlusPlus.NotepadPlusPlus" },
                new { Box = checkBoxNetDesktop,  Name = ".NET Runtime",    Id = "Microsoft.DotNet.DesktopRuntime.9" },
                new { Box = checkBoxNetAsp,      Name = "ASP.NET Core",    Id = "Microsoft.DotNet.AspNetCore.9" },

                // === DESKTOP VISUAL ===
                new { Box = checkBoxTranslucent, Name = "TranslucentTB",   Id = "TranslucentTB.TranslucentTB" },
                new { Box = checkBoxTaskbarX,    Name = "TaskbarX",        Id = "ChrisAndriessen.TaskbarX" }

            };

            if (!IsInternetAvailable())
            {
                CustomMessageBox.Show("No internet connection! Please connect to the network to use WinGet.", "Error");
                return;
            }

            foreach (var app in applications)
            {
                if (app.Box != null && app.Box.Checked)
                {
                    string command = $"Write-Host 'Installing the {app.Name}...' -ForegroundColor Green; " +
                                     $"winget install --id {app.Id} --silent --accept-source-agreements --accept-package-agreements --disable-interactivity";

                    wingetCommands.Add(command);
                }
            }

            StringBuilder psScript = new StringBuilder();
            psScript.Append("Clear-Host; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host '  Vstaller - Automatic installation       ' -ForegroundColor Green; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host 'Please wait, the software is installing...' -ForegroundColor Yellow; ");
            psScript.Append("Write-Host ''; ");

            foreach (string cmd in wingetCommands)
            {
                psScript.Append(cmd + "; ");
            }

            psScript.Append("Write-Host ''; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host 'All selected programs have been installed successfully!' -ForegroundColor Green; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");

            psScript.Append("Write-Host 'All installations are complete! Press ENTER to exit...' -ForegroundColor Cyan; ");
            psScript.Append("Read-Host; ");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "powershell.exe";
                psi.Arguments = $"-Command \"{psScript.ToString()}\"";
                psi.CreateNoWindow = false;
                psi.UseShellExecute = true;

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"An error occurred while starting the installation: {ex.Message}", "Error");
            }

        }
        private void buttonUpdateAll_Click(object sender, EventArgs e)
        {
            StringBuilder psScript = new StringBuilder();
            psScript.Append("Clear-Host; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host '   Vstaller - Full software update ' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host 'Checking for outdated programs and updating...' -ForegroundColor Yellow; ");
            psScript.Append("Write-Host ''; ");

            psScript.Append("winget upgrade --all --silent --accept-source-agreements --accept-package-agreements --disable-interactivity; ");

            psScript.Append("Write-Host ''; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host 'All available programs were updated successfully!' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Cyan; ");
            psScript.Append("Write-Host ''; ");
            psScript.Append("Write-Host 'Press ENTER to exit...' -ForegroundColor Yellow; ");
            psScript.Append("Read-Host; ");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "powershell.exe";
                psi.Arguments = $"-Command \"{psScript.ToString()}\"";
                psi.CreateNoWindow = false;
                psi.UseShellExecute = true;

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"An error occurred while starting the update: {ex.Message}", "Error");
            }
        }

        private void buttonSendRequest_Click(object sender, EventArgs e)
        {
            using (Send_Requests requestForm = new Send_Requests())
            {
                requestForm.StartPosition = FormStartPosition.CenterParent;
                requestForm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "1. Select the software you want to install from the categories." +
                "\r\n2. Double-check your choices." +
                "\r\n3. \"Install\" button  will install everything that you have chose." +
                "\r\n4. \"Update All\" Button will update EVERYSYSTEM that suport winget on you'rs device.";
            string tW = "EVERYSYSTEM";
            int startIndex = richTextBox1.Text.IndexOf(tW);

            if (startIndex != -1)
            {
                richTextBox1.Select(startIndex, tW.Length);
                richTextBox1.SelectionColor = Color.FromArgb(0, 184, 255);
                richTextBox1.SelectionLength = 0;
            }

            this.Opacity = 0;
            using (TermsForm terms = new TermsForm())
            {
                if (terms.ShowDialog() == DialogResult.OK)
                {
                    this.Opacity = 1;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool IsInternetAvailable()
        {
            try
            {
                using (Ping myPing = new Ping())
                {
                    String host = "8.8.8.8";
                    byte[] buffer = new byte[32];
                    int timeout = 2000; // Чака 2 секунди за отговор
                    PingOptions pingOptions = new PingOptions();
                    PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                    return (reply.Status == IPStatus.Success);
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
