using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text;

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

            if (CheckBoxChrome.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Google Chrome...' -ForegroundColor Green; winget install --id Google.Chrome --silent --accept-source-agreements --accept-package-agreements");

            }
            if (checkBoxBrave.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Brave Browser...' -ForegroundColor Green; winget install --id Brave.Brave -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxOperaGX.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Opera GX...' -ForegroundColor Green; winget install --id Opera.OperaGX -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxTor.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Tor Browser...' -ForegroundColor Green; winget install --id TorProject.TorBrowser -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxQbittorrent.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на qBittorrent...' -ForegroundColor Green; winget install --id qBittorrent.qBittorrent -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxWinRAR.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на WinRAR...' -ForegroundColor Green; winget install --id RARLab.WinRAR -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBox7Zip.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на 7-Zip...' -ForegroundColor Green; winget install --id 7zip.7zip -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxDiscord.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Discord...' -ForegroundColor Green; winget install --id Discord.Discord -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxInstagram.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Instagram...' -ForegroundColor Green; winget install --id IG.IGClient -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxSpotify.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Spotify...' -ForegroundColor Green; winget install --id Spotify.Spotify -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxSteam.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Steam...' -ForegroundColor Green; winget install --id Valve.Steam -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxEpicGames.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на EpicGames...' -ForegroundColor Green; winget install --id EpicGames.EpicGamesLauncher -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxUbisoft.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Ubisoft...' -ForegroundColor Green; winget install --id Ubisoft.Connect -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxWargaming.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Wargaming...' -ForegroundColor Green; winget install --id Wargaming.GameCenter -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxLogitech.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Logitech...' -ForegroundColor Green; winget install --id Logitech.GHUB -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxNVIDIA.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на NVIDIA...' -ForegroundColor Green; winget install --id Nvidia.App -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxAMD.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на AMD...' -ForegroundColor Green; winget install --id AMD.AMDSoftwareCloudEdition -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxIntel.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Intel...' -ForegroundColor Green; winget install --id Intel.IntelDriverAndSupportAssistant -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxAvast.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Avast...' -ForegroundColor Green; winget install --id Avast.AvastAntivirus -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxNordVPN.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на NordVPN...' -ForegroundColor Green; winget install --id NordVPN.NordVPN -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxVisualStudioCode.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на VisualStudioCode...' -ForegroundColor Green; winget install --id Microsoft.VisualStudioCode -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxVisualStudio.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на VisualStudio...' -ForegroundColor Green; winget install --id Microsoft.VisualStudio.Community -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxPython.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Python...' -ForegroundColor Green; winget install --id Python.Python.3.13 -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxGit.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Git...' -ForegroundColor Green; winget install --id Git.Git -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxGitHub.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на GitHub...' -ForegroundColor Green; winget install --id GitHub.GitHubDesktop -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxJava.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Java...' -ForegroundColor Green; winget install --id Oracle.JavaRuntimeEnvironment -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxNotepad.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на Notepad...' -ForegroundColor Green; winget install --id Notepad++.Notepad++ -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxNET10Desktop.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на NET10Desktop...' -ForegroundColor Green; winget install --id Microsoft.DotNet.DesktopRuntime.10 -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxNET10ASPNET.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на .NET 10.0 ASP.NET...' -ForegroundColor Green; winget install --id Microsoft.DotNet.AspNetCore.10 -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxTranslucentTB.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на TranslucentTB...' -ForegroundColor Green; winget install --id CharlesMilette.TranslucentTB -e --silent --accept-source-agreements --accept-package-agreements");
            }
            if (checkBoxTaskbarX.Checked)
            {
                wingetCommands.Add("Write-Host 'Инсталиране на TaskbarX...' -ForegroundColor Green; winget install --id chanplecai.smarttaskbar -e --silent --accept-source-agreements --accept-package-agreements");
            }

            if (wingetCommands.Count == 0)
            {
                MessageBox.Show("Моля, изберете поне една програма за инсталиране!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            StringBuilder psScript = new StringBuilder();
            psScript.Append("Clear-Host; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host '  Vstaller - Автоматична инсталация       ' -ForegroundColor Green; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host 'Моля, изчакайте, софтуерът се инсталира...' -ForegroundColor Yellow; ");
            psScript.Append("Write-Host ''; ");

            foreach (string cmd in wingetCommands)
            {
                psScript.Append(cmd + "; ");
            }

            psScript.Append("Write-Host ''; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");
            psScript.Append("Write-Host 'Всички избрани програми са инсталирани успешно!' -ForegroundColor Green; ");
            psScript.Append("Write-Host '==========================================' -ForegroundColor Green; ");

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "powershell.exe";
                psi.Arguments = $"-NoExit -Command \"{psScript.ToString()}\"";
                psi.CreateNoWindow = false;
                psi.UseShellExecute = true;

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка при стартиране на инсталацията: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBoxChrome_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
