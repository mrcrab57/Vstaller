namespace Proect_po_info
{
    partial class Send_Requests
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
            button1 = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxRequest = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonSend = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(354, 12);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 106);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "You'r Name";
            // 
            // textBoxRequest
            // 
            textBoxRequest.Location = new Point(118, 106);
            textBoxRequest.Name = "textBoxRequest";
            textBoxRequest.Size = new Size(178, 23);
            textBoxRequest.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(118, 88);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "You'r Requests";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(81, 106, 130);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(336, 44);
            label3.TabIndex = 5;
            label3.Text = "You can send me yours Request and ideas for improving this app here";
            label3.MouseDown += label3_MouseDown;
            label3.MouseMove += label3_MouseMove;
            label3.MouseUp += label3_MouseUp;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(302, 106);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 6;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Cambria", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(81, 106, 130);
            label4.Location = new Point(14, 56);
            label4.Name = "label4";
            label4.Size = new Size(284, 24);
            label4.TabIndex = 7;
            label4.Text = "Keep in mind i will respound faster if you are my friend so dont troll whit your name";
            label4.MouseDown += label4_MouseDown;
            label4.MouseMove += label4_MouseMove;
            label4.MouseUp += label4_MouseUp;
            // 
            // Send_Requests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 11, 22);
            ClientSize = new Size(389, 141);
            Controls.Add(label4);
            Controls.Add(buttonSend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxRequest);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Send_Requests";
            Text = "Send_Requests";
            Paint += Send_Requests_Paint;
            MouseDown += Send_Requests_MouseDown;
            MouseMove += Send_Requests_MouseMove;
            MouseUp += Send_Requests_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxRequest;
        private Label label2;
        private Label label3;
        private Button buttonSend;
        private Label label4;
    }
}