namespace bartolome
{
    partial class Login
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

        private Button GetButton1()
        {
            return button1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button1)
        {
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-52, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 26);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(404, 0);
            button2.Name = "button2";
            button2.Size = new Size(36, 26);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Jollibee_2011_logo_svg;
            pictureBox1.Location = new Point(12, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(204, 37);
            label1.TabIndex = 5;
            label1.Text = "JOLLIBEE APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 126);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10.8679247F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(139, 178);
            label3.Name = "label3";
            label3.Size = new Size(93, 24);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // textBox1
            // 
            txtUsername.Location = new Point(263, 128);
            txtUsername.Name = "textBox1";
            txtUsername.Size = new Size(110, 25);
            txtUsername.TabIndex = 8;
            // 
            // textBox2
            // 
            txtPassword.Location = new Point(263, 180);
            txtPassword.Name = "textBox2";
            txtPassword.Size = new Size(110, 25);
            txtPassword.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(194, 221);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 10;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 278);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
    }
}