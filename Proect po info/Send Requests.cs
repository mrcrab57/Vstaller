using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace Proect_po_info
{
    public partial class Send_Requests : Form
    {
        private Point startPoint = new Point(0, 0);
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Send_Requests()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text.Trim();
            string userRequest = textBoxRequest.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userRequest))
            {
                CustomMessageBox.Show("Please fill out both the Name and Request fields!", "Warning");
                return;
            }

            buttonSend.Enabled = false;
            buttonSend.Text = "Sending...";
            textBoxName.Enabled = false;
            textBoxRequest.Enabled = false;

            string webhookUrl = "https://discord.com/api/webhooks/1511765341892644864/dIpaYRKbiTPiZeokzwoTn26dQ3S2D42XYjlRPZsL_RPnXEcvcn3WXOjsAve8D0PWYwz5";

            string discordMessage = $"**🔔 New Application Request!**\\n**User:** {userName}\\n**Request Details:** {userRequest}";
            string jsonPayload = "{\"content\": \"" + discordMessage + "\"}";

            try
            {
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                {
                    var content = new System.Net.Http.StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                    System.Net.Http.HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        CustomMessageBox.Show("Your request was sent successfully! Thank you.", "Success");
                        this.Close();
                    }
                    else
                    {
                        CustomMessageBox.Show("Failed to send request to Discord. Please try again later.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Network error occurred: {ex.Message}", "Connection Error");
            }
            finally
            {
                buttonSend.Enabled = true;
                buttonSend.Text = "Send";
                textBoxName.Enabled = true;
                textBoxRequest.Enabled = true;
            }

        }

        private void Send_Requests_Paint(object sender, PaintEventArgs e)
        {

            using (Pen borderPen = new Pen(Color.FromArgb(0, 184, 255), 3))
            {
                int thickness = (int)borderPen.Width;

                Rectangle halfThicknessRect = new Rectangle(
                    thickness / 2,
                    thickness / 2,
                    this.ClientSize.Width - thickness,
                    this.ClientSize.Height - thickness
                );

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                e.Graphics.DrawRectangle(borderPen, halfThicknessRect);
            }
        }

        private void Send_Requests_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Send_Requests_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Send_Requests_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
