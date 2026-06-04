using System;
using System.Collections.Generic;
using System.Text;

namespace Proect_po_info
{
    public static class CustomMessageBox
    {
        public static void Show(string text, string title)
        {
            using (Form msgForm = new Form())
            {
                msgForm.Width = 400;
                msgForm.Height = 180;
                msgForm.Text = title;
                msgForm.FormBorderStyle = FormBorderStyle.None;
                msgForm.StartPosition = FormStartPosition.CenterParent;
                msgForm.BackColor = Color.FromArgb(5, 11, 22);

                msgForm.Paint += (s, e) =>
                {
                    using (Pen p = new Pen(Color.FromArgb(0, 184, 255), 2))
                    {
                        e.Graphics.DrawRectangle(p, 1, 1, msgForm.Width - 2, msgForm.Height - 2);
                    }
                };

                Label lblText = new Label() { Left = 20, Top = 30, Width = 360, Height = 60 };
                lblText.Text = text;
                lblText.ForeColor = Color.White;
                lblText.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblText.TextAlign = ContentAlignment.TopCenter;

                Button btnOk = new Button() { Text = "OK", Left = 150, Top = 110, Width = 100, Height = 32 };
                btnOk.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnOk.ForeColor = Color.FromArgb(0, 184, 255);
                btnOk.BackColor = Color.FromArgb(5, 11, 22);
                btnOk.FlatStyle = FlatStyle.Flat;
                btnOk.FlatAppearance.BorderSize = 0;
                btnOk.Click += (s, e) => { msgForm.Close(); };

                msgForm.Controls.Add(lblText);
                msgForm.Controls.Add(btnOk);
                msgForm.ShowDialog();
            }
        }
    }
}
